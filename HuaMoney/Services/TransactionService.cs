using AutoMapper;
using AutoMapper.QueryableExtensions;
using HuaMoney.Dto.Transaction;
using HuaMoney.Interfaces;
using HuaMoney.Models;
using Microsoft.EntityFrameworkCore;

namespace HuaMoney.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly HuaMoneyContext _context;
        private readonly IMapper _mapper;

        public TransactionService(HuaMoneyContext huaMoneyContext, IMapper mapper)
        {
            _context = huaMoneyContext;
            _mapper = mapper;
        }

        public async Task<List<TransactionDto>> Find()
        {
            return await _context.Transactions.AsNoTracking()
                                        .ProjectTo<TransactionDto>(_mapper.ConfigurationProvider)
                                        .ToListAsync();
        }
        
        public async Task<TransactionDto> Add(TransactionDto transactionDto)
        {
            var transaction = _mapper.Map<Transaction>(transactionDto);
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
            return _mapper.Map<TransactionDto>(transaction);
        }
    }
}