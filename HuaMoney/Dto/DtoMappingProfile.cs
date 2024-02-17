using HuaMoney.Dto.Bank;
using HuaMoney.Dto.Transaction;

namespace HuaMoney.Dto
{
    public class DtoMappingProfile : AutoMapper.Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<Models.Bank, BankDto>().ReverseMap();
            CreateMap<Models.Transaction, TransactionDto>().ReverseMap();
        }

    }
}