using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Persona
    {
        public static void CambiarNombre ()
        {
            ML.Persona persona = new ML.Persona ();
            
            persona.Edad = "22";
            persona.Peso = "70.30 kg";
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Hola {0}" , persona.Nombre); 
            
            if (persona.Nombre == "Luis Martinez Zamora")
            {
                Console.WriteLine("Su edad es "+ persona.Edad);
                Console.WriteLine("Su peso es "+ persona.Peso);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se encuetra la persona");
                Console.ReadKey();
            }
        }

        public static void CNombre()
        {
            Persona.CambiarNombre();

            Console.WriteLine("Hola");
            

        }
    }
}
