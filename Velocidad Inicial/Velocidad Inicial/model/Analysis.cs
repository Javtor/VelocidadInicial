using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Velocidad_Inicial.model
{
    class Analysis
    {
        public const int TIME = 1;
        public const int ANGLE = 2;
        public const int DISTANCE = 3;

        public const int METHOD_1 = 1;
        public const int METHOD_2 = 2;

        public static string REGISTERS_DIRECTORY = System.IO.Path.Combine(Environment.GetFolderPath(
    Environment.SpecialFolder.MyDoc‌​uments), "Velocidad inicial App");
        public static string REGISTERS_LOCATION = System.IO.Path.Combine(REGISTERS_DIRECTORY, "registers.csv");

        public List<Register> registers;

        public Analysis()
        {
            registers = new List<Register>();
            ClearRegisters();
        }

        public void ReadCsv(string url, bool hasHeader)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(url);

                line = "";

                if (hasHeader) sr.ReadLine();

                while ((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split(',');
                    double time = Double.Parse(info[0]);
                    double angle = Double.Parse(info[1]);
                    double distance = Double.Parse(info[2]);
                    AddRegister(time, angle, distance);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is IndexOutOfRangeException)
                {
                    throw new FormatException();
                }
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        public void SaveRegister(Register register)
        {
            try
            {
                if (!Directory.Exists(REGISTERS_DIRECTORY))
                {
                    Directory.CreateDirectory(REGISTERS_DIRECTORY);
                }
                StreamWriter sw = new StreamWriter(REGISTERS_LOCATION, true);
                sw.WriteLine(register.GetCsvString());

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void DeleteRegister(int index)
        {
            registers.RemoveAt(index);
            ClearRegistersFile();
            foreach (Register r in registers)
            {
                SaveRegister(r);
            }
        }

        public void ClearRegisters()
        {
            registers.Clear();
            ClearRegistersFile();
        }

        private void ClearRegistersFile()
        {
            try
            {
                if (Directory.Exists(REGISTERS_DIRECTORY))
                {
                    File.Delete(REGISTERS_LOCATION);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public double AverageVo(int method)
        {
            double distance = CalculateAverage(DISTANCE);
            double time = CalculateAverage(TIME);
            double angle = CalculateAverage(ANGLE);
            angle = ConvertDegreesToRadians(angle);
            double vel = 0;
            switch (method)
            {
                case METHOD_1:
                    vel = Register.GRAVITY * time / (2 * Math.Sin(angle));
                    break;
                case METHOD_2:
                    vel = Math.Sqrt(Register.GRAVITY * distance / Math.Sin(2 * angle));
                    break;
            }
            return vel;
        }

        public double CalculateAverageUncertainty(int method)
        {
            double g = Register.GRAVITY;
            double distance = CalculateAverage(DISTANCE);
            double time = CalculateAverage(TIME);
            double angle = CalculateAverage(ANGLE);
            angle = ConvertDegreesToRadians(angle);
            double uncertainty = 0;
            switch (method)
            {
                case METHOD_1:
                    uncertainty = (g / (2 * Math.Sin(angle))) * CalculateDeviation(TIME)
                        + (-(g * time * Math.Cos(angle)) / (2 * Math.Pow(Math.Sin(2 * angle), 2))) * CalculateDeviation(ANGLE);
                    break;
                case METHOD_2:
                    uncertainty = (1 / 2 * Math.Sqrt(g / (distance * Math.Sin(angle)))) * CalculateDeviation(DISTANCE)
                        + (-(Math.Sqrt(g * distance) * Math.Cos(2 * angle)) / Math.Sqrt(Math.Pow(Math.Sin(2 * angle), 3))) * CalculateDeviation(ANGLE);
                    break;
            }
            return uncertainty;
        }

        public double CalculateAverage(int c)
        {
            double sum = 0;
            int size = registers.Count;
            foreach (Register r in registers)
            {
                switch (c)
                {
                    case TIME:
                        sum += r.Time;
                        break;

                    case ANGLE:
                        sum += r.Angle;
                        break;

                    case DISTANCE:
                        sum += r.Distance;
                        break;
                }
            }
            return sum / size;
        }

        public double CalculateDeviation(int c)
        {
            double average = CalculateAverage(c);
            double sum = 0;
            int size = registers.Count;
            foreach (Register r in registers)
            {
                switch (c)
                {
                    case TIME:
                        sum += Math.Pow(r.Time - average, 2);
                        break;

                    case ANGLE:
                        sum += Math.Pow(r.Angle - average, 2);
                        break;

                    case DISTANCE:
                        sum += Math.Pow(r.Distance - average, 2);
                        break;
                }
            }
            return Math.Sqrt(sum / (size - 1));
        }

        public void AddRegister(double time, double angle, double distance)
        {
            registers.Add(new Register(time, angle, distance));
        }

        private static double ConvertDegreesToRadians(double degrees)
        {
            double radians = degrees * Math.PI / 180;
            return (radians);
        }
    }
}
