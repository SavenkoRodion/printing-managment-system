using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Uzytkownicy
{
    public int Id { get; set; }

    public int ParentUserId { get; set; }

    public int? RootUserId { get; set; }

    public string? DomyslnaFormaPlatnosci { get; set; }

    public string? Login { get; set; }

    public string? Haslo { get; set; }

    public string? Sumakontrolna { get; set; }

    public sbyte? Active { get; set; }

    public sbyte? Activeeditor { get; set; }

    public string? ImieNazwisko { get; set; }

    public string? Telefon2 { get; set; }

    public sbyte? Email2AktywnaPrzestrzen { get; set; }

    public sbyte? Email2AktywnaPrzestrzen2 { get; set; }

    public sbyte? Email2AktywnaPrzestrzen3 { get; set; }

    public string? Haslo3 { get; set; }

    public string? Email3 { get; set; }

    public string? ImieNazwisko3 { get; set; }

    public string? Telefon3 { get; set; }

    public sbyte? Email3AktywnaPrzestrzen { get; set; }

    public sbyte? Email3AktywnaPrzestrzen2 { get; set; }

    public sbyte? Email3AktywnaPrzestrzen3 { get; set; }

    public string? Haslo4 { get; set; }

    public string? Email4 { get; set; }

    public string? ImieNazwisko4 { get; set; }

    public string? Telefon4 { get; set; }

    public sbyte? Email4AktywnaPrzestrzen { get; set; }

    public sbyte? Email4AktywnaPrzestrzen2 { get; set; }

    public sbyte? Email4AktywnaPrzestrzen3 { get; set; }

    public string? Haslo5 { get; set; }

    public string? Email5 { get; set; }

    public string? ImieNazwisko5 { get; set; }

    public string? Telefon5 { get; set; }

    public sbyte? Email5AktywnaPrzestrzen { get; set; }

    public sbyte? Email5AktywnaPrzestrzen2 { get; set; }

    public sbyte? Email5AktywnaPrzestrzen3 { get; set; }

    public string? Haslo6 { get; set; }

    public string? Email6 { get; set; }

    public string? ImieNazwisko6 { get; set; }

    public string? Telefon6 { get; set; }

    public sbyte? Email6AktywnaPrzestrzen { get; set; }

    public sbyte? Email6AktywnaPrzestrzen2 { get; set; }

    public sbyte? Email6AktywnaPrzestrzen3 { get; set; }

    public string? Haslo7 { get; set; }

    public string? Email7 { get; set; }

    public string? ImieNazwisko7 { get; set; }

    public string? Telefon7 { get; set; }

    public sbyte? Email7AktywnaPrzestrzen { get; set; }

    public sbyte? Email7AktywnaPrzestrzen2 { get; set; }

    public sbyte? Email7AktywnaPrzestrzen3 { get; set; }

    public string? Haslo8 { get; set; }

    public string? Email8 { get; set; }

    public string? ImieNazwisko8 { get; set; }

    public string? Telefon8 { get; set; }

    public sbyte? Email8AktywnaPrzestrzen { get; set; }

    public sbyte? Email8AktywnaPrzestrzen2 { get; set; }

    public sbyte? Email8AktywnaPrzestrzen3 { get; set; }

    public string? Haslo9 { get; set; }

    public string? Email10 { get; set; }

    public string? ImieNazwisko10 { get; set; }

    public string? Telefon10 { get; set; }

    public sbyte? Email10AktywnaPrzestrzen { get; set; }

    public sbyte? Email10AktywnaPrzestrzen2 { get; set; }

    public sbyte? Email10AktywnaPrzestrzen3 { get; set; }

    public string? Email9 { get; set; }

    public string? ImieNazwisko9 { get; set; }

    public string? Telefon9 { get; set; }

    public sbyte? Email9AktywnaPrzestrzen { get; set; }

    public sbyte? Email9AktywnaPrzestrzen2 { get; set; }

    public sbyte? Email9AktywnaPrzestrzen3 { get; set; }

    public string? Haslo10 { get; set; }

    public string? NazwaFirmy { get; set; }

    public string? KodPocztowy { get; set; }

    public string? Miejscowosc { get; set; }

    public string? Adres { get; set; }

    public string? Telefon { get; set; }

    public sbyte? EmailAktywnaPrzestrzen { get; set; }

    public sbyte? EmailAktywnaPrzestrzen2 { get; set; }

    public sbyte? EmailAktywnaPrzestrzen3 { get; set; }

    public string? Haslo2 { get; set; }

    public string? Email2 { get; set; }

    public string? ImieNazwisko2 { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Nip { get; set; }

    public string? WKodPocztowy { get; set; }

    public string? WMiejscowosc { get; set; }

    public string? WAdres { get; set; }

    public string? EmailDoFaktury { get; set; }

    public string? EmailDoFaktury2 { get; set; }

    public sbyte? CzyWysylacFaktureEmail2 { get; set; }

    public string? NazwaKsiegowosci { get; set; }

    public string? TelefonKsiegowosci { get; set; }

    public sbyte? CzyAkceptujaFaktureElektroniczna { get; set; }

    public string? NotatkaOPlatnosciach { get; set; }

    public sbyte? CzyGenerowacFaktureAutomatycznie { get; set; }

    public sbyte? CzyGenerowacFaktureZbiorczo { get; set; }

    public string TerminPlatnosciFaktury { get; set; } = null!;

    public sbyte? CzestotliwoscWystawianiaFaktury { get; set; }

    public string? TerminWystawianiaFakturyTydzien { get; set; }

    public string? TerminWystawianiaFakturyDzien { get; set; }

    public int? DomyslnyRachunekBankowy { get; set; }

    public string? DataAktywacji { get; set; }

    public string? DataRejestracji { get; set; }

    public sbyte? ProgramPartnerski { get; set; }

    public string? KontaktOpis { get; set; }

    public string? EmailPrefix { get; set; }

    public string? PlacePrefix { get; set; }

    public string Logo { get; set; } = null!;

    public string TypKlienta { get; set; } = null!;

    public string WewnetrznyTyp { get; set; } = null!;

    public string Kod { get; set; } = null!;

    public sbyte CzyKoszty { get; set; }

    public sbyte CzyKontrahenci { get; set; }

    public string Kraj { get; set; } = null!;

    public string Waluta { get; set; } = null!;

    public int Vat { get; set; }

    public string Jezyk { get; set; } = null!;

    public int SprzedawcaId { get; set; }

    public virtual ICollection<CentraKosztowe> CentraKosztowes { get; set; } = new List<CentraKosztowe>();

    public virtual ICollection<CentraWybrane> CentraWybranes { get; set; } = new List<CentraWybrane>();

    public virtual ICollection<ProduktyKlientow> ProduktyKlientows { get; set; } = new List<ProduktyKlientow>();

    public virtual ICollection<Produktyzapisane> Produktyzapisanes { get; set; } = new List<Produktyzapisane>();

    public virtual ICollection<UzytkownikHasloTymczasowe> UzytkownikHasloTymczasowes { get; set; } = new List<UzytkownikHasloTymczasowe>();

    public virtual ICollection<UzytkownikPrawa> UzytkownikPrawas { get; set; } = new List<UzytkownikPrawa>();
}
