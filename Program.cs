using System;
using System.Collections.Generic;

namespace Colecciones_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> misNumeros = new LinkedList<int>();

            int[] Num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i<Num.Length; i++)
            {
                misNumeros.AddFirst(Num[i]);
            }

            foreach(int elementos in misNumeros)
            {
                Console.WriteLine(elementos);
            }
        }
    }
}