using HuaMoney.Dto.Bank;

namespace HuaMoney.ViewModel.Bank;

public class BankIndexViewModel
{
    public BankIndexViewModel(List<BankDto> bankList)
    {
        bankList = bankList;
    }
    
    public List<BankDto> bankList = new List<BankDto>();
}