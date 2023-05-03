using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Triangulo
    {
        public static float baseT, altura;
        public static  float area(float baseT, float altura)
        {
            return (baseT * altura) / 2;
        }

        public static double Achatar(float baseT, float altura)
        {
            double a = 0.10 * altura;

            double result = (baseT * (altura - a)) / 2;
            return result;
        }
    }
}
