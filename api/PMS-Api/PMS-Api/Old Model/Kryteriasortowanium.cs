using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Kryteriasortowanium
{
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public int? Order { get; set; }

    public int? Type { get; set; }

    public string? Konfiguracja { get; set; }
}
