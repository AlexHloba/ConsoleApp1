Console.WriteLine("****Карточка****");
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

