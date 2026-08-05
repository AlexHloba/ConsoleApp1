using FinanceTracker.Domain.Enums;

namespace FinanceTracker.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public decimal Amount {  get; set; }
        public TransactionType Type { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
    }

}
    