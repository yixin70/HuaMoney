using HuaMoney.Dto.Account;
using HuaMoney.Dto.Bank;
using HuaMoney.Dto.Currency;
using HuaMoney.Models;
using System.ComponentModel.DataAnnotations;

namespace HuaMoney.ViewModel.Account;

public class AccountCreateViewModel
{
    [Required(ErrorMessage = "Input a valid amount")]
    public string Name { get; set; } = null!;
    [Required(ErrorMessage = "Input a valid amount")]
    public string AccountNumber { get; set; } = null!;
    [Required(ErrorMessage = "Input a valid amount")]
    public decimal Amount { get; set; }
    [Required(ErrorMessage = "Input a valid amount")]
    public long UserId { get; set; }
    [Required(ErrorMessage = "Input a valid amount")]
    public long BankId { get; set; }
    [Required(ErrorMessage = "Input a valid amount")]
    public string CurrencyId { get; set; }

    //Mostrar

    public List<BankDto> Banks { get; set; } = new List<BankDto>();
    public List<CurrencyDto> Currencies { get; set; } = new List<CurrencyDto>();
    
}

