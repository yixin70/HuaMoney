using System;
using System.Collections.Generic;

namespace HuaMoney.Models;

public partial class Transaction
{
    public long Id { get; set; }

    public decimal AccountAmountAfter { get; set; }

    public long AccountId { get; set; }

    public decimal Amount { get; set; }

    public string Concept { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Recipient { get; set; } = null!;

    public virtual Account Account { get; set; } = null!;
}
