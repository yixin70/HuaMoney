using HuaMoney.Dto.Bank;

namespace HuaMoney.Interfaces
{
    public interface IBankService
    {
        Task<List<BankDto>> Find();
    }
}
