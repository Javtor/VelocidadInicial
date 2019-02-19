using System;
using System.Collections.Generic;
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

        public List<Register> registers;

        public Analysis()
        {
            registers = new List<Register>();
        }

        public void ReadCsv()
        {

        }

        public double AverageVo(int method)
        {
            double distance = CalculateAverage(DISTANCE);
            double time = CalculateAverage(TIME);
            double angle = CalculateAverage(ANGLE);
            angle = ConvertDegreesToRadians(angle);
            double vel = 0;
            switch(method)
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

        public double CalculateAverageUncertainty()
        {
            return -1;
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
                        sum += Math.Pow(r.Time-average, 2);
                        break;

                    case ANGLE:
                        sum += Math.Pow(r.Angle - average, 2);
                        break;

                    case DISTANCE:
                        sum += Math.Pow(r.Distance - average, 2);
                        break;
                }
            }
            return Math.Sqrt(sum / (size-1));
        }

        public void AddRegister(double time, double angle, double distance)
        {
            registers.Add(new Register(time, angle, distance));
        }

        public static double ConvertDegreesToRadians(double degrees)
        {
            double radians = degrees * Math.PI / 180;
            return (radians);
        }
    }
}
