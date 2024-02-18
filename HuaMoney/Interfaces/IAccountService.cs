using HuaMoney.Dto.Account;

namespace HuaMoney.Interfaces;

public interface IAccountService
{
    Task<List<AccountDto>> Find();
}