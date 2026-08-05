

using FinanceTracker.Domain.Entities;
using FinanceTracker.Domain.Enums;
using FinanceTracker.Infrastructure.Repositories;

namespace FinanceTracker.Aplication.Services
{
    public class FinanceService
    {


      private readonly InMemoryTransactionRepository _repository;
    
     public FinanceService()
        {
            _repository = new InMemoryTransactionRepository();
        }

        public void AddTransaction(decimal amount, TransactionType type, string category, string desc)
        {
            var transactiion = new Transaction
            {
                Amount = amount,
                Type = type,
                Category = category,
                Description = desc
            };

            _repository.Add(transactiion);
        }
        public decimal GetTotalExpense()
        {
            var transaction = _repository.GetAll();
            return transaction
                .Where(t => t.Type == TransactionType.Expense)
                .Sum(t => t.Amount);

        }

        public decimal GetTotalIncome()
        {
            var transaction = _repository.GetAll();
            return transaction
                .Where(t => t.Type == TransactionType.Income)
                .Sum(t => t.Amount);
        }

}    }










