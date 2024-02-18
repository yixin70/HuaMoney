using HuaMoney.Dto.Account;

namespace HuaMoney.Interfaces;

public interface IAccountService
{
    Task<List<AccountDto>> Find();
    Task<AccountDto> Add(AccountDto accountDto);
    Task<AccountDto> FindOne(long id);
    Task<int> Delete(long id);
}