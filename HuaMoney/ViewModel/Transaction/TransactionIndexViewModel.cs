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

    public TransactionFilterViewModel filter = new TransactionFilterViewModel();

}