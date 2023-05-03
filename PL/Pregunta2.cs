using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Pregunta2
    {
        public static int metodoA(int[] vec, int pos)
        {
            int sum = 0, i = 0 ;

            while ( i == pos)
            {
                sum = sum + vec[1];
            }
            return sum;
        }

    }
}
