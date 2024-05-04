using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Faktura
{
    public int Id { get; set; }

    public string? NumerFaktury { get; set; }

    public string? NumerReferencyjny { get; set; }

    public string? DataUtworzenia { get; set; }

    public string? KtoUtworzyl { get; set; }

    public string? DataWysylki { get; set; }

    public string? KtoWyslal { get; set; }

    public string? DataOstatniejWysylki { get; set; }

    public string? KtoOstatnioWyslal { get; set; }

    public sbyte? ZatwierdzPlatnosc { get; set; }

    public string? DataZatwierdzeniaPlatnosci { get; set; }

    public sbyte? CzyZaplacono { get; set; }

    public string? Opis { get; set; }

    public string? RodzajOpis { get; set; }

    public string? DataWystawienia { get; set; }

    public string? DataSprzedazy { get; set; }

    public string? DataZaplaty { get; set; }

    public string? FormaPlatnosci { get; set; }

    public string? KwotaBrutto { get; set; }

    public string? DoZaplaty { get; set; }

    public string? Zaplacono { get; set; }

    public string? KwotaBruttoSlownie { get; set; }

    public string? KwotaNetto { get; set; }

    public string? KwotaVat { get; set; }

    public string? Vat { get; set; }

    public string? PrzesylkaKwotaBrutto { get; set; }

    public string? NumerRachunkuBankowego { get; set; }

    public string? SwiftCode { get; set; }

    public string? SImieNazwisko { get; set; }

    public string? PrzesylkaKwotaNetto { get; set; }

    public string? SNazwaFirmy { get; set; }

    public string? SKodPocztowy { get; set; }

    public string? SMiejscowosc { get; set; }

    public string? SAdres { get; set; }

    public string? SNip { get; set; }

    public string? NNazwaFirmyLubOsoby { get; set; }

    public string? NKodPocztowy { get; set; }

    public string? NMiejscowosc { get; set; }

    public string? NAdres { get; set; }

    public string? NNip { get; set; }

    public string? Uwagi { get; set; }

    public string? Uid { get; set; }

    public sbyte CzyKoszty { get; set; }

    public string Waluta { get; set; } = null!;

    public int SprzedawcaId { get; set; }

    public virtual ICollection<FakturaZalacznik> FakturaZalaczniks { get; set; } = new List<FakturaZalacznik>();

    public virtual ICollection<Produktyfaktura> Produktyfakturas { get; set; } = new List<Produktyfaktura>();
}
