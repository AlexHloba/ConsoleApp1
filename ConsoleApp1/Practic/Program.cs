namespace ConsoleApp1.Practic
{
    class Program
    {
        static void Main()
        {
            Car myCar = new SportsCar(0, 01);
            Console.WriteLine("Введите количество бензина для заправки");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int amount))
            {
                bool succes = myCar.Refuel(amount);
                if (succes)
                {
                    Console.WriteLine($"Заправка выполнена на {amount} литров ");
                }
                else
                {
                    Console.WriteLine("Заправка не выполнена");
                }
            }

            myCar.Drive(10);
        }
        
    }

    
}
