using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea10
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Ingresa tu nombre:");

            nombre = Console.ReadLine();

            if (nombre == "Martin")
            {
                Console.WriteLine("Hola {0}", nombre);
            }
            else
            {
                Console.WriteLine("No te conozco");
             
            }
            Console.ReadKey();
        }      
    }
}
