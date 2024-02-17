using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace HuaMoney.ViewModel.Transaction;

public class TransactionCreateViewModel
{
    public DateTime Date { get; set; }
    public string Concept { get; set; }
    public string Recipient { get; set; }
    [Required(ErrorMessage = "Input a valid amount")]
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public long AccountId { get; set; }
    public decimal AccountAmountAfter { get; set; }
}