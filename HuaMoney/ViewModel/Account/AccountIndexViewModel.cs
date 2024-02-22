using HuaMoney.Dto.Account;
using HuaMoney.Dto.Currency;
using HuaMoney.Models;

namespace HuaMoney.ViewModel.Account;

public class AccountIndexViewModel
{
    public AccountIndexViewModel(List<AccountDto> accounts) {
        Accounts = accounts;
    }

    public List<AccountDto> Accounts { get; set; } = new List<AccountDto>();
}