using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class ProduktyKlientow
{
    public int Id { get; set; }

    public int KlientId { get; set; }

    public string Nazwa { get; set; } = null!;

    public int RodzajProduktu { get; set; }

    public string? KonfiguracjaSvg { get; set; }

    public int? Wysokosc { get; set; }

    public int? Szerokosc { get; set; }

    public string? Wysokosc2 { get; set; }

    public string? Szerokosc2 { get; set; }

    public string? Tlo { get; set; }

    public sbyte? CzyPubliczny { get; set; }

    public sbyte? AktywujWgrywaniePlikow { get; set; }

    public sbyte? AktywujPobieraniePlikow { get; set; }

    public string? PlikPobieraniePath { get; set; }

    public sbyte? AktywujDodanieDoKoszyka { get; set; }

    public int IdWartosc { get; set; }

    public string? DataUtworzenia { get; set; }

    public string? DataAktualizacji { get; set; }

    public string? KtoUtworzyl { get; set; }

    public string? KtoAktualizowal { get; set; }

    public virtual Uzytkownicy Klient { get; set; } = null!;

    public virtual Produkty RodzajProduktuNavigation { get; set; } = null!;
}
