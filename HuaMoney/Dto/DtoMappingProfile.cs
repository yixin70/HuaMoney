using HuaMoney.Dto.Account;
using HuaMoney.Dto.Bank;
using HuaMoney.Dto.Currency;
using HuaMoney.Dto.Transaction;

namespace HuaMoney.Dto
{
    public class DtoMappingProfile : AutoMapper.Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<Models.Bank, BankDto>().ReverseMap();
            CreateMap<Models.Transaction, TransactionDto>().ReverseMap();
            CreateMap<Models.Account, AccountDto>().ReverseMap();
            CreateMap<Models.Currency, CurrencyDto>().ReverseMap();
        }

    }
}