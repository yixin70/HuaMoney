namespace HuaMoney.ViewModel.Transaction
{
    public class TransactionFilterViewModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? CategoryId { get; set; }
        public long? AccountId { get; set; }
        public string? Recipient { get; set; }

    }
}
