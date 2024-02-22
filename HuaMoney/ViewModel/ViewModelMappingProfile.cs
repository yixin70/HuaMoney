using HuaMoney.Dto.Account;
using HuaMoney.Dto.Bank;
using HuaMoney.Dto.Transaction;
using HuaMoney.ViewModel.Account;
using HuaMoney.ViewModel.Transaction;

namespace HuaMoney.ViewModel
{
    public class ViewModelMappingProfile : AutoMapper.Profile
    {
        public ViewModelMappingProfile()
        {
            CreateMap<TransactionCreateViewModel, TransactionDto>().ReverseMap();
            CreateMap<TransactionFilterViewModel, TransactionFilterDto>().ReverseMap();
            
            CreateMap<AccountCreateViewModel, AccountDto>().ReverseMap();
        }
    }
}
