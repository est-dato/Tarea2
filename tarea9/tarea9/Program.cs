using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea9
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass, passAux;

            Console.Write("Ingresa tu nombre:");

            Console.ReadLine();

            Console.Write("Ingresa una contraseña:");

            pass = Console.ReadLine();

            Console.Write("Porfavor, reingresa la contraseña:");

            passAux = Console.ReadLine();

            while (pass != passAux)
            {
                Console.WriteLine("¡ERROR! Las contraseñas no coinciden. Reintenta");

                Console.Write("Ingresa una contraseña:");

                pass = Console.ReadLine();

                Console.Write("Porfavor, reingresa la contraseña:");

                passAux = Console.ReadLine();

            }

            Console.WriteLine("¡Bien hecho!");
            Console.ReadKey();
        }
    }
}
