using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Kategorie
{
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public string? Opis { get; set; }

    public string? Grafika { get; set; }

    public int Margines { get; set; }

    public int MarginesWewnetrzny { get; set; }

    public int IloscStron { get; set; }

    public int Typproduktu { get; set; }
}
