using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Produktykoszyk
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

    public int? KoszykId { get; set; }

    public string? Koszty { get; set; }

    public string? NazwaKlienta { get; set; }

    public int? CzasRealizacjiStart { get; set; }

    public int? CzasRealizacjiKoniec { get; set; }

    public int? CzasRealizacji { get; set; }

    public int? CzasZrealizowano { get; set; }

    public string? Jednostka { get; set; }

    public int? LiczBrutto { get; set; }

    public string? Uid { get; set; }

    public int? Kolejnosc { get; set; }

    public int? UzytkownicyId { get; set; }
}
