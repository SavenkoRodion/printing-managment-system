using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Przesylki
{
    public int Id { get; set; }

    public string? Data { get; set; }

    public string? DoNazwaFirmy { get; set; }

    public string? DoImieNazwisko { get; set; }

    public string? DoAdres { get; set; }

    public string? DoKodPocztowy { get; set; }

    public string? DoMiejscowosc { get; set; }

    public string? DoTelefon { get; set; }

    public string? DoEmail { get; set; }

    public string DoKraj { get; set; } = null!;

    public string? ZNazwaFirmy { get; set; }

    public string? ZImieNazwisko { get; set; }

    public string? ZAdres { get; set; }

    public string? ZKodPocztowy { get; set; }

    public string? ZMiejscowosc { get; set; }

    public string? ZTelefon { get; set; }

    public string? ZEmail { get; set; }

    public string ZKraj { get; set; } = null!;

    public string? Status { get; set; }

    public string? Uid { get; set; }

    public string? Opis { get; set; }

    public string? TypPliku { get; set; }

    public int? TypKuriera { get; set; }

    public int TypPrzesylki { get; set; }

    public string? ZamowienieKwotaBrutto { get; set; }

    public string? NumerListuPrzewozowego { get; set; }

    public string Dodatkowe { get; set; } = null!;
}
