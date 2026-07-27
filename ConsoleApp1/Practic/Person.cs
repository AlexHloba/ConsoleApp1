public class StudentProfessorTest
{
    public static void Run(string[] args)
    {

        Person person = new Person();
        person.Greet();
        Student student = new Student();
        student.SetAge(20);
        student.Greet();
        student.ShowAge();

        Teacher teacher = new Teacher();
        teacher.SetAge(50);
        teacher.Greet();
        teacher.Explain();
    }
}

public class Person
{
    protected int age;

    public void Greet()
    {
        Console.WriteLine("Здравствуйте");
    }

    public void SetAge(int age)
    {
        this.age = age;
    }
}

public class Student : Person
{
    public void Study()
    {
        Console.WriteLine("Я ученица");
    }

    public void ShowAge()
    {
        Console.WriteLine($"Мне {age} лет");
    }
}

public class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("Я объясню");
    }
}

