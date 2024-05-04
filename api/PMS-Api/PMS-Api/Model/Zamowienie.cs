using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Zamowienie
{
    public int Id { get; set; }

    public string? NumerReferencyjny { get; set; }

    public string? Data { get; set; }

    public string? DataPlatnosci { get; set; }

    public string? DataWystawienia { get; set; }

    public string? DataTerminZaplaty { get; set; }

    public string DataTerminZaplatyDni { get; set; } = null!;

    public string DataOstatniegoPrzypomnienia { get; set; } = null!;

    public int FormaPlatnosci { get; set; }

    public string? FormaPlatnosciOpis { get; set; }

    public string? KwotaBrutto { get; set; }

    public string? PrzesylkaKwotaBrutto { get; set; }

    public sbyte OsobaPrywatna { get; set; }

    public sbyte WystawEFakture { get; set; }

    public string? ZImieNazwisko { get; set; }

    public string? ZTelefon { get; set; }

    public string? ZEmail { get; set; }

    public string? WNazwaFirmy { get; set; }

    public string? WImieNazwisko { get; set; }

    public string? WAdres { get; set; }

    public string? WKodPocztowy { get; set; }

    public string? WMiejscowosc { get; set; }

    public string? WTelefon { get; set; }

    public string? WEmail { get; set; }

    public string WKraj { get; set; } = null!;

    public string? FNazwaFirmyLubOsoby { get; set; }

    public string? FAdres { get; set; }

    public string? FKodPocztowy { get; set; }

    public string? FMiejscowosc { get; set; }

    public string? FNip { get; set; }

    public string? Status { get; set; }

    public string? Uid { get; set; }

    public int UuidPrzestrzeni { get; set; }

    public string? Payback { get; set; }

    public int SposobDostawy { get; set; }

    public string? IdPaczkomatu { get; set; }

    public string? Uwagi { get; set; }

    public string? UwagiKlienta { get; set; }

    public int? UzytkownicyId { get; set; }

    public string? PpName { get; set; }

    public string? PpUserId { get; set; }

    public int? KuponyrabatoweId { get; set; }

    public sbyte ZamowienieZewnetrzne { get; set; }

    public sbyte DoWyjasnienia { get; set; }

    public sbyte Zafakturowac { get; set; }

    public sbyte? WystawionoProwizjePp { get; set; }

    public sbyte? ZgodaRegulamin { get; set; }

    public sbyte? ZgodaPrzetwarzaniedanych { get; set; }

    public string? NumerRachunkuBankowego { get; set; }

    public int? FakturaId { get; set; }

    public sbyte CzyKoszty { get; set; }

    public int CzasRealizacjiStart { get; set; }

    public int CzasRealizacjiKoniec { get; set; }

    public int CzasRealizacji { get; set; }

    public int CzasZrealizowano { get; set; }

    public string Waluta { get; set; } = null!;

    public int SprzedawcaId { get; set; }

    public virtual ICollection<Produktyzamowienie> Produktyzamowienies { get; set; } = new List<Produktyzamowienie>();
}
