using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Kuponyrabatowe
{
    public int Id { get; set; }

    public string? Kodkuponu { get; set; }

    public string Krotnoscuzycia { get; set; } = null!;

    public string Krotnoscwykorzystania { get; set; } = null!;

    public string? DataUtworzenia { get; set; }

    public string? DataWaznosci { get; set; }

    public int? Typkuponu { get; set; }

    public string? Wartosc1 { get; set; }

    public string? Wartosc2 { get; set; }

    public string? Kwota { get; set; }

    public int? Typ { get; set; }

    public int? Status { get; set; }

    public int? UzytkownicyId { get; set; }
}
