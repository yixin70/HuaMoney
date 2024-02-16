using HuaMoney.Dto.Bank;

namespace HuaMoney.Dto
{
    public class DtoMappingProfile : AutoMapper.Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<HuaMoney.Models.Bank, BankDto>().ReverseMap();
        }

    }
}