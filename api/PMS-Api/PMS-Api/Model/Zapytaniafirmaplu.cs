using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Zapytaniafirmaplu
{
    public string? ImieNazwisko { get; set; }

    public string? NazwaFirmy { get; set; }

    public string? Email { get; set; }

    public string? Telefon { get; set; }

    public string? LiczbaPracownikow { get; set; }

    public string? LiczbaPakietow { get; set; }

    public string? Temat { get; set; }

    public string? Tresc { get; set; }

    public int Id { get; set; }
}
