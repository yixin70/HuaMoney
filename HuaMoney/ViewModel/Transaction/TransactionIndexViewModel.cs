using System.ComponentModel.DataAnnotations;
using HuaMoney.Dto.Bank;
using HuaMoney.Dto.Transaction;

namespace HuaMoney.ViewModel.Transaction;

public class TransactionIndexViewModel
{
    public TransactionIndexViewModel(List<TransactionDto> transactionDto)
    {
        this.transactionList = transactionDto;
    }

    public List<TransactionDto> transactionList = new List<TransactionDto>();

    // public long? Id { get; set; }
    //
    // public DateTime Date { get; set; }
    //
    // [Required(ErrorMessage = "Input a valid amount")]
    // public decimal Amount { get; set; }
    //
    // public decimal AccountAmountAfter { get; set; }
    //
    // public string Currency { get; set; } = null!;
    //
    // public string Concept { get; set; } = null!;
    //
    // public string Recipient { get; set; } = null!;
    //
    // public long AccountId { get; set; }
}