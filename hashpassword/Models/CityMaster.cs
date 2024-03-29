using System;
using System.Collections.Generic;

namespace hashpassword.Models;

public partial class CityMaster
{
    public int CityId { get; set; }

    public string CityName { get; set; } = null!;

    public int StateId { get; set; }

    public int CountryId { get; set; }

}
