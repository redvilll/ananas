﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Введите X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Введите Y: ");
            int Y = int.Parse(Console.ReadLine());

            int i = A;

            do
            {
                if ((i - X) % 10 == 0 || (i - Y) % 10 == 0)
                    Console.WriteLine(i);
                i++;
            }
            while (i < B);

            Console.ReadKey();
        }
    }
}
