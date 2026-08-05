using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace PracticeBase
{
    public class Hw4
    {
        public static void Print4()

        {
            Random rand = new Random();

            Console.Write("Введите количество строк n (n < 6): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов m (m < 6): ");
            int m = int.Parse(Console.ReadLine());


            int[,] matr = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matr[i, j] = rand.Next(-9, 10);


            while (true)
            {
                Console.WriteLine("1. Вывести матрицу");
                Console.WriteLine("2. Найти количество положительных и отрицательных чисел");
                Console.WriteLine("3. Вывести матрицу (чётные строки – чётные элементы, нечётные – нечётные)");
                Console.WriteLine("4. Подсчитать частоту чисел с помощью словаря");
                Console.WriteLine("5. Выход");
                Console.Write("Выберите пункт: ");
                int select = int.Parse(Console.ReadLine());


                switch (select)
                {
                    case 1:

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                                Console.Write($"{matr[i, j]}");
                        }
                        break;


                    case 2:

                        int positive = 0, negative = 0;
                        for (int i = 0; i < n; i++)
                            for (int j = 0; j < m; j++)
                            {
                                if (matr[i, j] > 0) positive++;
                                else if (matr[i, j] < 0) negative++;
                            }
                        Console.WriteLine($"Положительных: {positive}");
                        Console.WriteLine($"Отрицательных: {negative}");
                        Console.WriteLine($"Нулей: {n * m - positive - negative}");
                        break;

                    case 3:

                        for (int i = 0; i < matr.GetLength(0); i++)
                        {
                            if (i % 2 == 0)
                            {
                                for (int j = 0; j < matr.GetLength(0); j++)
                                {
                                    if (matr[i, j] % 2 == 0)
                                    {
                                        Console.Write(matr[i, j] + " ");
                                    }
                                }
                            }
                            else
                            {
                                for (int j = 0; j < matr.GetLength(0); j++)
                                {
                                    if (matr[i, j] % 2 != 0)
                                    {
                                        Console.Write(matr[i, j] + " ");
                                    }
                                }
                            }


                            if (matr.Length == 0)
                            {
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 4:
                        Dictionary<int, int> count = new Dictionary<int, int>();

                        for (int i = 0; i < matr.GetLength(0); i++)
                        {
                            for (int j = 0; j < matr.GetLength(1); j++)
                            {
                                int number = matr[i, j];

                                if (count.ContainsKey(number))
                                {
                                    count[number]++;
                                }
                                else
                                {
                                    count.Add(number, 1);
                                }
                            }
                        }

                        foreach (var pair in count)
                        {
                            Console.WriteLine($"{pair.Key}: {pair.Value}");
                        }

                        break;

                    case 5:

                        Console.WriteLine("Выход.");

                        break;

                    default:
                        Console.WriteLine("Неверный пункт");

                        break;





























                }
            }
        }
    }       
                
            
}

            

