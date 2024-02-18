using HuaMoney.Dto.Account;

namespace HuaMoney.ViewModel.Account;

public class AccountCreateViewModel
{

    public long UserId { get; set; }

    public string AccountNumber { get; set; }

    public decimal Amount { get; set; }

    public long BankId { get; set; }

    public string Currency { get; set; }

    public string Name { get; set; }

    public List<AccountDto> Accounts { get; set; } = new List<AccountDto>();
}

