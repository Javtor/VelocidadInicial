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
            return -1;
        }

        public double AverageVo2()
        {
            return -1;
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

        
        
    }
}
