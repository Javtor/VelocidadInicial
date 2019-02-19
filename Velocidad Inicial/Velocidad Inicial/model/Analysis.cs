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
        public List<Register> registers;

        public Analysis()
        {
            registers = new List<Register>();
        }

        public void ReadCsv()
        {

        }

        public double AverageVo1()
        {
            double time = CalculateAverage(TIME);
            double angle = CalculateAverage(ANGLE);
            angle = ConvertDegreesToRadians(angle);
            return Register.GRAVITY * time / (2 * Math.Sin(angle)); ;
        }

        public double AverageVo2()
        {
            double distance = CalculateAverage(DISTANCE);
            double angle = CalculateAverage(ANGLE);
            angle = ConvertDegreesToRadians(angle);
            return Math.Sqrt(Register.GRAVITY * distance / Math.Sin(2 * angle)); ;
        }

        public double CalculateAverageUncertainty()
        {
            return -1;
        }

        public double CalculateAverage(int c)
        {
            double sum = 0 ;
            int size = registers.Count;
            switch (c)
            {
                case TIME:
                    foreach(Register r in registers)
                    {
                        sum += r.Time;
                    }
                    break;
                    
                case ANGLE:
                    foreach (Register r in registers)
                    {
                        sum += r.Angle;
                    }
                    break;
                    
                case DISTANCE:
                    foreach (Register r in registers)
                    {
                        sum += r.Distance;
                    }
                    break;
            }

            return sum/size;
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
