using AutoMapper;
using AutoMapper.QueryableExtensions;
using HuaMoney.Dto.Account;
using HuaMoney.Dto.Bank;
using HuaMoney.Interfaces;
using HuaMoney.Models;
using Microsoft.EntityFrameworkCore;

namespace HuaMoney.Services;

public class AccountService: IAccountService
{
    private readonly HuaMoneyContext _context;
    private readonly IMapper _mapper;
        
    public async Task<List<AccountDto>> Find()
    {
        return await _context.Accounts.AsNoTracking()
                                    .ProjectTo<AccountDto>(_mapper.ConfigurationProvider)
                                    .ToListAsync();
    }
}