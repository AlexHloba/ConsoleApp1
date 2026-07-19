using FinanceTracker.Application.Services;

namespace FinanceTracker.CLI;

internal class Programm
{
    static void Main(string[] args)
    {
        FinanceServise servise = new FinanceServise();
        Console.WriteLine("Мой финансовый трекер");
        decimal balance = servise.GetTotalIncome() - servise.GetTotalExpense();
        Console.WriteLine("Мой баланс " + balance);
    }
}
