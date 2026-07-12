using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeBase
{
    public class Hw2
    {
        public static void Print1()
        {
            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 7; i <= n; i += 7)
            {
                Console.Write(i + " ");
            }
        }
    }
}
