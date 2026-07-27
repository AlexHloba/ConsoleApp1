namespace ConsoleApp1.Practic
{
    public class Debt
    {
        public double balance;
        public double interestRate;


        public Debt(double initialbalance, double initialInterestRate)
        {
            balance = initialbalance;
            interestRate = initialInterestRate;
        }

        public void PrintBalance(double balance)
        {
            Console.WriteLine(balance);
        }

        public void WaitOneYear()
        {
            balance *= interestRate;
        }

       /// public static void Main(String[] args)
        //{
        //    Debt mortgage = new Debt(120000.0, 1.01);
        //    mortgage.PrintBalance();        
        //    mortgage.WaitOneYear();
        //    mortgage.PrintBalance();       
                    
        //    int years = 0;
        //    while (years < 20)
        //    {
        //        mortgage.WaitOneYear();
        //        years = years + 1;
        //    }
        //    mortgage.PrintBalance();
        //}

        private void PrintBalance()
        {
            throw new NotImplementedException();
        }
    }
}