using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Cenniki
{
    public int Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public string? Konfiguracja { get; set; }

    public string? Konfiguracja2 { get; set; }

    public string? Konfiguracja3 { get; set; }

    public string Przesylki { get; set; } = null!;

    public string Grupy { get; set; } = null!;

    public string? Grupowanie { get; set; }

    public string? Grupowanie2 { get; set; }

    public string? Grupowanie3 { get; set; }

    public string? GrupyUzytkownikow { get; set; }

    public string NazwaPrzestrzeni { get; set; } = null!;

    public string NazwaPrzestrzeni2 { get; set; } = null!;

    public string NazwaPrzestrzeni3 { get; set; } = null!;

    public int UuidPrzestrzeni { get; set; }

    public int UuidPrzestrzeni2 { get; set; }

    public int UuidPrzestrzeni3 { get; set; }

    public sbyte? AktywnaPrzestrzen { get; set; }

    public sbyte? AktywnaPrzestrzen2 { get; set; }

    public sbyte? AktywnaPrzestrzen3 { get; set; }
}
