

using FinanceTracker.Domain.Entities;
using FinanceTracker.Domain.Enums;

namespace FinanceTracker.Infrastructure.Repositories
{
    public class InMemoryTransactionRepository
    {
        private readonly List<Transaction> _transactions = new()
        {
            new Transaction
            {
                Amount = 4000,
                Type = TransactionType.Income,
                Category = "Зарплата",
                Description = "Аванс",
            },

            new Transaction
            {
                Amount = 200,
                Type = TransactionType.Expense,
                Category = "Еда",
                Description = "Продукты"
            },

            new Transaction
            {
                Amount = 150,
                Type = TransactionType.Expense,
                Category = "Расходы",
                Description = "Коммунальные платежи"
            }

        };
        public void Add(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        public List<Transaction> GetAll()
        {
            return _transactions;
        }



    }
    
    
}
