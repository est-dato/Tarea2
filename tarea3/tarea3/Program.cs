﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
			for (int i = 9; i <= 9; i++)
			{
				Console.WriteLine("\nTabla de multiplicar del {0}", i);
				Console.WriteLine("------------------------------");
				for (int j = 1; j <= 10; j++)
				{
					Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
				}
			}
			Console.ReadKey();
		}
    }
}

