using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Szablonyopisseo
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Link { get; set; }

    public string? Keywords { get; set; }

    public string? Description { get; set; }

    public string? Opis { get; set; }

    public string? Tagi { get; set; }

    public string? Alt { get; set; }

    public string? Naglowek { get; set; }

    public string? NaglowekPrzod { get; set; }

    public string? NaglowekTyl { get; set; }

    public string? Dlakogo { get; set; }

    public int SzablonId { get; set; }
}
