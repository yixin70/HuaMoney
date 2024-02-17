using HuaMoney.Dto.Bank;

namespace HuaMoney.ViewModel.Bank;

public class BankIndexViewModel
{
    public BankIndexViewModel(List<BankDto> bankDto) {
        this.bankList = bankDto;
    }
    
    public List<BankDto> bankList = new List<BankDto>();
}