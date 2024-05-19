using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Produktyzapisane
{
    public int Id { get; set; }

    public int UuidPrzestrzeni { get; set; }

    public int KlientId { get; set; }

    public string Nazwa { get; set; } = null!;

    public int RodzajProduktu { get; set; }

    public string? KonfiguracjaSvg { get; set; }

    public int? Wysokosc { get; set; }

    public int? Szerokosc { get; set; }

    public string? Wysokosc2 { get; set; }

    public string? Szerokosc2 { get; set; }

    public string? Etykiety { get; set; }

    public int? Status { get; set; }

    public sbyte? AktywujWgrywaniePlikow { get; set; }

    public sbyte? AktywujDodanieDoKoszyka { get; set; }

    public string? DataUtworzenia { get; set; }

    public string? KtoUtworzyl { get; set; }

    public string? DataOstatniejModyfikacji { get; set; }

    public string? KtoOstatnioModyfikowal { get; set; }

    public string? DataAkceptacji { get; set; }

    public string? EmailAkceptacji { get; set; }

    public string? Tlo { get; set; }

    public int IdWartosc { get; set; }

    public virtual Uzytkownicy Klient { get; set; } = null!;

    public virtual ICollection<Produktyzapisaneakceptacja> Produktyzapisaneakceptacjas { get; set; } = new List<Produktyzapisaneakceptacja>();

    public virtual Produkty RodzajProduktuNavigation { get; set; } = null!;
}
