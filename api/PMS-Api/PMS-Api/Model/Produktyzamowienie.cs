using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Produktyzamowienie
{
    public int Id { get; set; }

    public string? NettoPrzedRabatem { get; set; }

    public string? BruttoPrzedRabatem { get; set; }

    public string? Vat { get; set; }

    public string? Rabat { get; set; }

    public string? NettoPoRabacie { get; set; }

    public string? BruttoPoRabacie { get; set; }

    public int? Ilosc { get; set; }

    public string? Opis { get; set; }

    public string? Konfiguracja { get; set; }

    public int? Status { get; set; }

    public int? Typproduktu { get; set; }

    public int? ZamowienieId { get; set; }

    public string Koszty { get; set; } = null!;

    public string NazwaKlienta { get; set; } = null!;

    public int CzasRealizacjiStart { get; set; }

    public int CzasRealizacjiKoniec { get; set; }

    public int CzasRealizacji { get; set; }

    public int CzasZrealizowano { get; set; }

    public string Jednostka { get; set; } = null!;

    public int LiczBrutto { get; set; }

    public string? Uid { get; set; }

    public virtual Zamowienie? Zamowienie { get; set; }
}
