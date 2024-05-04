using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class AdresyDostaw
{
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public string? NazwaFirmy { get; set; }

    public string? ImieNazwisko { get; set; }

    public string? KodPocztowy { get; set; }

    public string? Miejscowosc { get; set; }

    public string? Adres { get; set; }

    public string? Ulica { get; set; }

    public string? NrDomu { get; set; }

    public string? NrMieszkania { get; set; }

    public string? Telefon { get; set; }

    public string Kraj { get; set; } = null!;

    public sbyte? DomyslnyAdres { get; set; }

    public int UserId { get; set; }
}
