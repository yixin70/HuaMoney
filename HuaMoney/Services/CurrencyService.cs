using AutoMapper;
using AutoMapper.QueryableExtensions;
using HuaMoney.Dto.Currency;
using HuaMoney.Interfaces;
using HuaMoney.Models;
using Microsoft.EntityFrameworkCore;

namespace HuaMoney.Services;

public class CurrencyService: ICurrencyService
{
    private readonly HuaMoneyContext _context;
    private readonly IMapper _mapper;
    
    public CurrencyService(HuaMoneyContext huaMoneyContext, IMapper mapper)
    {
        _context = huaMoneyContext;
        _mapper = mapper;
    }
    
    public async Task<List<CurrencyDto>> Find()
    {
        return await _context.Currency.AsNoTracking()
                                        .ProjectTo<CurrencyDto>(_mapper.ConfigurationProvider)
                                        .ToListAsync();
    }
}