namespace HuaMoney.Dto.Transaction
{
    public class TransactionFilterDto
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? CategoryId { get; set; }
        public long? AccountId { get; set; }
        public string? Recipient { get; set; }
    }
}
