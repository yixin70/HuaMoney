using AutoMapper;
using AutoMapper.QueryableExtensions;
using HuaMoney.Dto.Bank;
using HuaMoney.Interfaces;
using HuaMoney.Models;
using Microsoft.EntityFrameworkCore;

namespace HuaMoney.Services
{
    public class BankService : IBankService
    {
        private readonly HuaMoneyContext _context;
        private readonly IMapper _mapper;

        public BankService(HuaMoneyContext huaMoneyContext, IMapper mapper)
        {
            _context = huaMoneyContext;
            _mapper = mapper;
        }

        public async Task<List<BankDto>> Find()
        {
            return await _context.Banks.AsNoTracking()
                                        .ProjectTo<BankDto>(_mapper.ConfigurationProvider)
                                        .ToListAsync();
        }

    }
}
