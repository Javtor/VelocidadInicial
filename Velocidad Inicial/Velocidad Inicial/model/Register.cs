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
        private double Time { get; set; }
        private double Angle { get; set; }
        private double Distance { get; set; }
        private double Vo1 { get; set; }
        private double Vo2 { get; set; }

        public Register(int time, int angle, int distance)
        {
            Time = time;
            Angle = angle;
            Distance = distance;
        }

        public double CalculateVo1()
        {
            return -1;
        }

        public double CalculateVo2()
        {
            return -1;
        }



    }
}
