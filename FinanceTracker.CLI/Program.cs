

using FinanceTracker.Aplication.Services;

namespace FinanceTracker.CLI;

internal class Programm
{
    static void Main(string[] args)
    {                             
        FinanceService servise = new FinanceService();
        Console.WriteLine("Мой финансовый трекер");
        decimal balance = servise.GetTotalIncome() - servise.GetTotalExpense();
        Console.WriteLine("Мой баланс " + balance);
    }
}
                               