using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Produktyfaktura
{
    public int Id { get; set; }

    public string? KwotaNettoPrzedRabatem { get; set; }

    public string? KwotaBruttoPrzedRabatem { get; set; }

    public string? KwotaNettoPoRabacie { get; set; }

    public string? KwotaBruttoPoRabacie { get; set; }

    public string? Vat { get; set; }

    public int? Rabat { get; set; }

    public string? Ilosc { get; set; }

    public string Naklad { get; set; } = null!;

    public string? Opis { get; set; }

    public string? Konfiguracja { get; set; }

    public int? FakturaId { get; set; }

    public string? Koszty { get; set; }

    public string? NazwaKlienta { get; set; }

    public string Jednostka { get; set; } = null!;

    public int LiczBrutto { get; set; }

    public virtual Faktura? Faktura { get; set; }
}
