using HuaMoney.Dto.Bank;
using HuaMoney.Dto.Transaction;
using HuaMoney.ViewModel.Transaction;

namespace HuaMoney.ViewModel
{
    public class ViewModelMappingProfile : AutoMapper.Profile
    {
        public ViewModelMappingProfile()
        {
            CreateMap<TransactionCreateViewModel, TransactionDto>().ReverseMap();
        }
    }
}
