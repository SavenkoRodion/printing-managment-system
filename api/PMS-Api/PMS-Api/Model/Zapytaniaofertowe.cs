using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Zapytaniaofertowe
{
    public string? Imie { get; set; }

    public string? Nazwisko { get; set; }

    public string? NazwaFirmy { get; set; }

    public string? Nip { get; set; }

    public string? Email { get; set; }

    public string? Telefon { get; set; }

    public string? Telefon2 { get; set; }

    public string? Fax { get; set; }

    public string? Kolorystyka { get; set; }

    public string? Stanowisko { get; set; }

    public string? Przyklady { get; set; }

    public string? Uwagi { get; set; }

    public int? Status { get; set; }

    public int Id { get; set; }
}
