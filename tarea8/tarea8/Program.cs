using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea8
{
    class Program
    {
        static void Main(string[] args)
        {

            string letra;

            Console.Write("Ingresa una letra:");

            letra = Console.ReadLine();

            letra = letra.ToUpper();

            if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
            {
                Console.WriteLine("¡Es una vocal!");
            }
            Console.ReadKey();
        } 

    }
}
