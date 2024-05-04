using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Uzytkownicysystemowi
{
    public int Id { get; set; }

    public string? Uid { get; set; }

    public string? Login { get; set; }

    public string? Imie { get; set; }

    public string? Haslo { get; set; }

    public string? Email { get; set; }

    public string? DataUtworzenia { get; set; }

    public string? DataAktualizacji { get; set; }

    public string? DataOstatniegoLogowania { get; set; }

    public string? DataPoprzedniegoLogowania { get; set; }

    public sbyte? CzyAktywne { get; set; }

    public string? Uprawnienia { get; set; }

    public int? DomyslnyWidokPoZalogowaniu { get; set; }

    public string? Token { get; set; }

    public string? DataWaznosciTokena { get; set; }

    public string? ResetUid { get; set; }
}
