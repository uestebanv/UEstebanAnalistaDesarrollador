using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Cadena
    {
        public static string InvertirCadena(string cadena)
        {
            string cinvertida = "";

            foreach(char letra in cadena)
            {
                cinvertida = letra + cinvertida;
            }
            return cinvertida;
        }
    }
}
