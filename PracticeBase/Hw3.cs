using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeBase
{
    public class Hw3
    {
        public static void Print3()
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            while (a < n)
            {
                int count = a + b;
                a = b;
                b = count;

                Console.Write(a + " ");

            }


        }
    }
}
