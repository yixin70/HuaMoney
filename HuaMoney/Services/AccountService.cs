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
        
    public AccountService(HuaMoneyContext context, IMapper mapper)
    {
        _context=context;
        _mapper=mapper;
    }

    public async Task<List<AccountDto>> Find()
    {
        return await _context.Accounts.AsNoTracking()
                                    .ProjectTo<AccountDto>(_mapper.ConfigurationProvider)
                                    .ToListAsync();
    }

    public async Task<AccountDto> FindOne(long id)
    {
        var account = await _context.Accounts.Where(item => item.Id == id)
                                                    .AsNoTracking()
                                                    .ProjectTo<AccountDto>(_mapper.ConfigurationProvider)
                                                    .FirstOrDefaultAsync();
        return account;
    }

    public async Task<int> Delete(long id)
    {
        var account = await _context.Accounts.Where(item => item.Id == id).FirstAsync();
        _context.Remove(account);
        return await _context.SaveChangesAsync();
    }


}