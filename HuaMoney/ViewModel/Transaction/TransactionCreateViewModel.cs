using HuaMoney.Dto.Account;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace HuaMoney.ViewModel.Transaction;

public class TransactionCreateViewModel
{
    public DateTime Date { get; set; } = DateTime.Now;
    public string Concept { get; set; }
    public string Recipient { get; set; }
    [Required(ErrorMessage = "Input a valid amount")]
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public long AccountId { get; set; }
    public decimal AccountAmountAfter { get; set; }

    public List<AccountDto> Accounts { get; set; } = new List<AccountDto>();

}