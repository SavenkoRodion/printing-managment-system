using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Cennik
{
    public int Id { get; set; }

    public string? Uid { get; set; }

    public string? Konfiguracja { get; set; }

    public string? Nazwa { get; set; }

    public int? KategorieId { get; set; }

    public int? FormatyId { get; set; }

    public int Domyslny { get; set; }
}
