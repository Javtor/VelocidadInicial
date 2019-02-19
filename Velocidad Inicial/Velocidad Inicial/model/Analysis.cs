using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Velocidad_Inicial.model
{
    class Analysis
    {
        public int TIME = 1;
        public int ANGLE = 2;
        public int DISTANCE = 3;
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
                case 1:
                    foreach(Register r in registers)
                    {
                        sum += r.Time;
                    }
                    break;
                    
                case 2:
                    foreach (Register r in registers)
                    {
                        sum += r.Angle;
                    }
                    break;
                    
                case 3:
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
