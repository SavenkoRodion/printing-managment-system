using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Produkty7dniowe
{
    public int Id { get; set; }

    public string? Konfiguracja { get; set; }

    public string? Salt { get; set; }

    public string? Email { get; set; }

    public string? Tytul { get; set; }

    public string? Opis { get; set; }

    public sbyte? DostepnaMiniatura { get; set; }

    public string? DataWaznosci { get; set; }

    public string? DataZapis { get; set; }
}
