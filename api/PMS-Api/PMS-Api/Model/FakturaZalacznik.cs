using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class FakturaZalacznik
{
    public int Id { get; set; }

    public int? FakturaId { get; set; }

    public string? NumerFaktury { get; set; }

    public string? Opis { get; set; }

    public string? RodzajOpis { get; set; }

    public string? DataWystawienia { get; set; }

    public string? NNazwaFirmyLubOsoby { get; set; }

    public string? NKodPocztowy { get; set; }

    public string? NMiejscowosc { get; set; }

    public string? NAdres { get; set; }

    public string? NNip { get; set; }

    public string? Uwagi { get; set; }

    public string? Uid { get; set; }

    public virtual Faktura? Faktura { get; set; }
}
