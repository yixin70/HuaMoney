using HuaMoney.Dto.Transaction;
using Microsoft.EntityFrameworkCore;

namespace HuaMoney.Interfaces;

public interface ITransactionService
{
    Task<List<TransactionDto>> Find();
    Task<TransactionDto> Add(TransactionDto transactionDto);
}