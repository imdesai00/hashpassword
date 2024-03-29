using System;
using System.Collections.Generic;

namespace hashpassword.Models;

public partial class StateMaster
{
    public int StateId { get; set; }

    public string StateName { get; set; } = null!;

    public int CountryId { get; set; }

    public virtual CountryMaster Country { get; set; } = null!;
}
