using HuaMoney.Dto.Currency;
using HuaMoney.Models;

namespace HuaMoney.ViewModel.Account;

public class AccountIndexViewModel
{
    public long UserId { get; set; }

    public string AccountNumber { get; set; }

    public decimal Amount { get; set; }

    public long BankId { get; set; }

    public string Name { get; set; }
    
    public CurrencyDto Currency { get; set; }
    
    public User User { get; set; }

}