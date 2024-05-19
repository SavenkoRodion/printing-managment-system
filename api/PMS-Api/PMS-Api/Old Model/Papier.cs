using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Papier
{
    public int Id { get; set; }

    public string? Opis { get; set; }

    public string? RozszerzonyOpis { get; set; }

    public string? CzasRealizacji { get; set; }

    public string? IkonaPath { get; set; }

    public string? BigIkonaPath { get; set; }

    public int? Numer { get; set; }

    public string? Nazwa { get; set; }

    public string? Liczbastron { get; set; }
}
