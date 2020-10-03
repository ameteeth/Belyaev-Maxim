using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathaMatha
{
    public class MathL
    {
        public static double add(double Firstvalue, double Secondvalue)
        {
            return Firstvalue + Secondvalue;
        }
        public static double diff(double Firstvalue, double Secondvalue)
        {
            return Firstvalue - Secondvalue;
        }
        public static double multiply(double Firstvalue, double Secondvalue)
        {
            return Firstvalue * Secondvalue;
        }
        public static double division(double Firstvalue, double Secondvalue)
        {
            if (Secondvalue == 0)
            {
                return 0;
            }
            else
            {
                return Firstvalue / Secondvalue;
            }
        }
        public static double Circle(double Radius)
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public static double Square(double Side)
        {
            return Math.Pow(Side, 2);
        }
        public static double areaParallelogram(double Footing, double Height)
        {
            return Footing * Height;
        }
    }
}
