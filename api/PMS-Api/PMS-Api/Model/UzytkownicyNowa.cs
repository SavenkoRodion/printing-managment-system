using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class UzytkownicyNowa
{
    public int Id { get; set; }

    public string? Uid { get; set; }

    public required string Imie { get; set; }

    public string? DataUtworzenia { get; set; }

    public required string Haslo { get; set; }
}
