using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Opinie
{
    public int Id { get; set; }

    public string? DataUtworzenia { get; set; }

    public string? DataZatwierdzenia { get; set; }

    public string? ImieNazwisko { get; set; }

    public string? Email { get; set; }

    public string? Opinia { get; set; }

    public string? Uwagi { get; set; }

    public string? Pytanie1 { get; set; }

    public string? Pytanie2 { get; set; }

    public string? Pytanie3 { get; set; }

    public string? Login { get; set; }

    public string? FacebookPostId { get; set; }

    public string? FacebookPageId { get; set; }

    public sbyte? AktywnaNaStronie { get; set; }

    public sbyte? AktywnaNaFacebook { get; set; }

    public int? UzytkownicyId { get; set; }
}
