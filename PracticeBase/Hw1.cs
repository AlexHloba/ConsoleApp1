namespace PracticeBase
{
    public class Hw1
    {
        public static void Print ()
        {
            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 0; i--)
            { 
                Console.WriteLine (i);
            }
        }

    }
}
