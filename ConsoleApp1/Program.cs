
class Program
{
    static void Main()
    {
        Func<int, int, int> operation;

        Console.Write("Введи операцию\n 1:Сложение\n 2:Вычитание\n 3:Умножение\n 4:Деление  ");

        string symbol = Console.ReadLine();

        switch (symbol)
        {
            case "1": operation = (a, b) => a + b; 
                break;
            case "2": operation = (a, b) => a - b; 
                break;
            case "3": operation = (a, b) => a * b; 
                break;
            case "4": operation = (a, b) => b != 0 ? a / b : 0; 
                break;

            default: Console.WriteLine("Неизвестная операция"); 
                return;
        }

        Console.Write("Первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Второе число: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Результат: {operation (a, b)}");
    }
}
