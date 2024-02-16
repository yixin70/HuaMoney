using System;
using System.Collections.Generic;

namespace HuaMoney.Models;

public partial class Bank
{
    public long Id { get; set; }

    public string Country { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
