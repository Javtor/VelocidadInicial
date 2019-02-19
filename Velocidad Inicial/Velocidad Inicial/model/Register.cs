using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velocidad_Inicial.model
{
    class Register
    {
        public double GRAVITY = 9.8;
        public double Time { get; set; }
        public double Angle { get; set; }
        public double Distance { get; set; }
        public double Vo1 { get; set; }
        public double Vo2 { get; set; }

        public Register(int time, int angle, int distance)
        {
            Time = time;
            Angle = angle;
            Distance = distance;
        }

        public double CalculateVo1()
        {
            return GRAVITY * Time / (2 * Math.Sin(Angle));
        }

        public double CalculateVo2()
        {
            return Math.Sqrt(GRAVITY * Distance / Math.Sin(2 * Angle)); ;
        }

        public double CalculateUncertainty()
        {
            return -1;
        }


    }
}
