using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea7
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;

            int b = a + 2;

            b = b - 3;

            int c = -3;

            c = c * 2;

            Console.WriteLine(c + 1);

            a = a * b;

            // El resultado es:
            // b = 4
            // c = -6
            // a = 20
        }
    }
}
