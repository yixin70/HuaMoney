namespace HuaMoney.Dto.Account
{
    public class AccountDto
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public string AccountNumber { get; set; }

        public decimal Amount { get; set; }

        public long BankId { get; set; }

        public string CurrencyId { get; set; }

        public string Name { get; set; }
    }
}