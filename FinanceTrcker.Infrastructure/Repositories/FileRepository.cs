using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using FinanceTracker.Domain.Entities;
using FinanceTracker.Domain.Enums;

namespace FinanceTracker.Infrastructure.Repositories
{
    public  class FileRepository
    {
        public void Add(Transaction transaction)
        {
            Console.WriteLine("моя логинка");
        }

        public List<Transaction> GetAll()
        {
            return [
                new Transaction
                {
                    Amount = 4000
                    Type = TransactionType.Income,
                    Category = "Зарплата",
                    Description = "Аванс"
                },
                new Transaction
                {
                    Amount = 200,
                    Type = TransactionType.Expense,
                    Category = "Еда",
                    Description = "Продукты"
                }


                ];
        }
        
    }
    
    
}
