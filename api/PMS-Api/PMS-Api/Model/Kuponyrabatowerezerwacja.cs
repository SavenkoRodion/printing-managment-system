using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Kuponyrabatowerezerwacja
{
    public int Id { get; set; }

    public string? DataRezerwacji { get; set; }

    public int? KuponyrabatoweId { get; set; }
}
