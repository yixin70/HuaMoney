using HuaMoney.Dto.Transaction;
using Microsoft.EntityFrameworkCore;

namespace HuaMoney.Interfaces;

public interface ITransactionService
{
    Task<List<TransactionDto>> Find(TransactionFilterDto? filter = null);
    Task<TransactionDto> Add(TransactionDto transactionDto);
    Task<TransactionDto> FindOne(long id);
    Task<int> Delete(long id);
}