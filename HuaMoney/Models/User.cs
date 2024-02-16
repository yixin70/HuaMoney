using System;
using System.Collections.Generic;

namespace HuaMoney.Models;

public partial class User
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
