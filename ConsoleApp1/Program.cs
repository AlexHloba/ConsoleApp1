/*Console.WriteLine("****Карточка****");
Console.WriteLine("Введите Ваше Имя: ");
string name = Console.ReadLine();
Console.WriteLine("Введите ваш возраст: ");
string age = Console.ReadLine();
Console.WriteLine("Введите ваш рост: ");
string height = Console.ReadLine();
Console.WriteLine($"Ваше имя {name} \nВаш возраст {age}\nВаш рост {height} ");


Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"До обмена значений А равно {a}, В равно {b}");

int temp = a;
a = b; b = temp;

Console.WriteLine($"После обменя значений А равно {a}, В равно {b}");


Console.WriteLine("Площадь прямоугольника ");

Console.WriteLine("Введите ширину: ");
string wid = Console.ReadLine();
double width = Double.Parse(wid);

Console.WriteLine("Введите длину:");
string len = Console.ReadLine();
double length = Double.Parse(len);

double area = width * length;
double perimetr = 2 * (width + length);

Console.WriteLine($"Площадь прямоугольника равна {area} \nПериметр прямоугольника равен {perimetr}");

*/










    class Calcilator
{
    static void Main(string[] args)
    {


        bool continueCalculating = true;
        while (continueCalculating)
        {
            Console.Clear();
            Console.WriteLine("=== АРИФМЕТИЧЕСКИЙ КАЛЬКУЛЯТОР ===");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Вычитание (-)");
            Console.WriteLine("3. Умножение (*)");
            Console.WriteLine("4. Деление (/)");
            Console.WriteLine("5. Процент от числа (%)");
            Console.WriteLine("6. Квадратный корень (√)");
            Console.Write("Выберите действие (1-6): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformBinaryOperation("Сложение", (a, b) => a + b);
                    break;
                case "2":
                    PerformBinaryOperation("Вычитание", (a, b) => a - b);
                    break;
                case "3":
                    PerformBinaryOperation("Умножение", (a, b) => a * b);
                    break;
                case "4":
                    PerformDivision();
                    break;
                case "5":
                    PerformPercentage();
                    break;
                case "6":
                    PerformSquareRoot();
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    WaitForKey();
                    continue;
            }


            Console.Write("\nХотите выполнить ещё одно вычисление? (y/n): ");
            string answer = Console.ReadLine()?.Trim().ToLower();
            if (answer != "y" && answer != "yes" && answer != "да")
            {
                continueCalculating = false;
                Console.WriteLine("Работа завершена. До свидания!");
            }
        }
    }


    static void PerformBinaryOperation(string operationName, Func<double, double, double> operation)
    {
        Console.Clear();
        Console.WriteLine($"--- {operationName} ---");
        double a = ReadDouble("Введите первое число: ");
        double b = ReadDouble("Введите второе число: ");
        double result = operation(a, b);
        Console.WriteLine($"Результат: {a} {GetOperationSymbol(operationName)} {b} = {result}");
        WaitForKey();
    }


    static void PerformDivision()
    {
        Console.Clear();
        Console.WriteLine("--- Деление ---");
        double a = ReadDouble("Введите делимое: ");
        double b;
        while (true)
        {
            b = ReadDouble("Введите делитель: ");
            if (b != 0) break;
            Console.WriteLine("Ошибка: деление на ноль невозможно. Введите другое число.");
        }
        double result = a / b;
        Console.WriteLine($"Результат: {a} / {b} = {result}");
        WaitForKey();
    }


    static void PerformPercentage()
    {
        Console.Clear();
        Console.WriteLine("--- Процент от числа ---");
        double number = ReadDouble("Введите число: ");
        double percent = ReadDouble("Введите процент: ");
        double result = (percent * number) / 100.0;
        Console.WriteLine($"{percent}% от {number} = {result}");
        WaitForKey();
    }


    static void PerformSquareRoot()
    {
        Console.Clear();
        Console.WriteLine("--- Квадратный корень ---");
        double number;
        while (true)
        {
            number = ReadDouble("Введите неотрицательное число: ");
            if (number >= 0) break;
            Console.WriteLine("Ошибка: нельзя извлечь квадратный корень из отрицательного числа.");
        }
        double result = Math.Sqrt(number);
        Console.WriteLine($"√{number} = {result}");
        WaitForKey();
    }


    static double ReadDouble(string check)
    {
        double value;
        while (true)
        {
            Console.Write(check);
            string input = Console.ReadLine();
            if (double.TryParse(input, out value))
            {
                return value;
            }
            Console.WriteLine("Ошибка: введите корректное число.");
        }
    }


    static void WaitForKey()
    {
        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }


    static string GetOperationSymbol(string operationName)
    {
        return operationName switch
        {
            "Сложение" => "+",
            "Вычитание" => "-",
            "Умножение" => "*",
            _ => "?"
        };
    }
}

