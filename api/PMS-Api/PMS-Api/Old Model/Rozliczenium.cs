using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Rozliczenium
{
    public int Id { get; set; }

    public string? NumerRozliczenia { get; set; }

    public string? DataOd { get; set; }

    public string? DataDo { get; set; }

    public string? DataRozliczenia { get; set; }

    public string? Opis { get; set; }

    public string? NazwaPlikuKlienta { get; set; }

    public string? NazwaPliku { get; set; }

    public string? KwotaBruttoZamowien { get; set; }

    public string? KwotaBruttoPrzesylki { get; set; }

    public string? PodstawaProwizji { get; set; }

    public string? KwotaRozliczenia { get; set; }

    public string? Tresc { get; set; }

    public string? OdbiorcaRozliczenia { get; set; }

    public string? WystawcaRozliczenia { get; set; }

    public sbyte? Rozliczone { get; set; }

    public int UserId { get; set; }
}
