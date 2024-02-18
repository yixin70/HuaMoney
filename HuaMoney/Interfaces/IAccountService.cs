using AutoMapper;
using HuaMoney.Dto.Account;
using HuaMoney.Models;

namespace HuaMoney.Interfaces;

public interface IAccountService
{
    Task<List<AccountDto>> Find();

    Task<AccountDto> FindOne(long id);

    Task<int> Delete(long id);
}
