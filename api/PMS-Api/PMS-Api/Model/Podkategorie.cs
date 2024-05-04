using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Podkategorie
{
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public string? Opis { get; set; }

    public sbyte Visible { get; set; }

    public int? KategorieId { get; set; }

    public int? FormatyId { get; set; }

    public int? PodkategoriaGlownaId { get; set; }
}
