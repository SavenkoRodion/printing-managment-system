using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Produktyfirmowe
{
    public int Id { get; set; }

    public string? Konfiguracja { get; set; }

    public string? Salt { get; set; }

    public int? UzytkownicyId { get; set; }
}
