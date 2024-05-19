using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Szablonyproduktow
{
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public string? PlikSzablonu { get; set; }

    public string? Konfiguracja { get; set; }

    public int? KategorieId { get; set; }

    public int? FormatyId { get; set; }

    public int? PodkategorieId { get; set; }

    public int Rank { get; set; }

    public sbyte PokazWGalerii { get; set; }

    public sbyte PokazNaStronieGlownejGalerii { get; set; }

    public string? TagName { get; set; }

    public string? DefaultReverseTag { get; set; }

    public string? ReverseTags { get; set; }

    public string? OptionsTags { get; set; }
}
