using System.ComponentModel.DataAnnotations;

namespace HuaMoney.Models;

public partial class Account
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string AccountNumber { get; set; } = null!;

    public decimal Amount { get; set; }

    public long BankId { get; set; }

    [Required]
    public string CurrencyId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Bank Bank { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual User User { get; set; } = null!;
    
    public virtual Currency Currency { get; set; }
}
