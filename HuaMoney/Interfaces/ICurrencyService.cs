using HuaMoney.Dto.Currency;

namespace HuaMoney.Interfaces;

public interface ICurrencyService
{
    Task<List<CurrencyDto>> Find();
}