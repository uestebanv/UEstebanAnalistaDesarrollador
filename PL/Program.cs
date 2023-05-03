using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Arregleo");
            //string c = Console.ReadLine();
            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(a);
            //Console.WriteLine("Valor");
            //string g = Console.ReadLine();
            //int b = Convert.ToInt16(g);

            //PL.Pregunta2.metodoA(a, b);

            //Console.ReadKey();
            //Console.WriteLine("ingrese la cadena de texto");
            //string texto = Console.ReadLine();

            ////PL.Cadena.InvertirCadena(texto);

            //Console.WriteLine(PL.Cadena.InvertirCadena(texto));

            //Console.ReadKey();

            //Console.WriteLine("Ecriba la altura del triangulo");

            //float altura = Convert.ToInt32(Console.ReadLine()); 
            //Console.WriteLine("Escriba la base del triangulo");
            //float Base = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(PL.Triangulo.area(altura, Base));

            //Console.WriteLine(PL.Triangulo.Achatar(altura, Base));

            //Console.ReadKey();

            //PL.Persona.CambiarNombre();
            Pregunta7 refb = new Pregunta7();
            int x = 2;
            int y = 1;
            y = refb.test(x, y);
            Console.WriteLine("Paso 1, res =" +y);
            y = refb.test(x, y);
            Console.WriteLine("Paso 2, res =" +y);
            x = refb.test(x, 0);
            Console.WriteLine("Paso 3, res =" + x);
            Console.Read();
        }
    }
}

