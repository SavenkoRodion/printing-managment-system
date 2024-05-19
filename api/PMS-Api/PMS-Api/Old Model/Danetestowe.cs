using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Danetestowe
{
    public int Id { get; set; }

    public string? Etykieta { get; set; }

    public string? Text { get; set; }

    public int? Typ { get; set; }

    public int? SzablonyproduktowId { get; set; }
}
