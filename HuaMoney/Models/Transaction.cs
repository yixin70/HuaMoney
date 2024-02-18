using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Build.Framework;

namespace HuaMoney.Models;

public partial class Transaction
{
    public long Id { get; set; }

    public decimal AccountAmountAfter { get; set; }

    public long AccountId { get; set; }

    public decimal Amount { get; set; }

    public string Concept { get; set; } = null!;

    // make currency not nullable
    [Required]
    public string CurrencyId { get; set; }

    public DateTime Date { get; set; }

    public string Recipient { get; set; } = null!;

    public virtual Account Account { get; set; } = null!;
    
    public virtual Currency Currency { get; set; }
}
