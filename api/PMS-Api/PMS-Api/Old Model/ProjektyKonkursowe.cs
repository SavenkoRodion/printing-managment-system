using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class ProjektyKonkursowe
{
    public int Id { get; set; }

    public int? FacebookLike { get; set; }

    public int? FacebookShare { get; set; }

    public int? FacebookComments { get; set; }

    public int? GooglePlus { get; set; }

    public int? GooglePlusShare { get; set; }

    public int? TwitterShare { get; set; }

    public int? Total { get; set; }

    public string? Email { get; set; }

    public int? IdKonkursu { get; set; }

    public string? DataUtworzenia { get; set; }

    public string DataAktualizacji { get; set; } = null!;

    public string? SaltProjektuTymczasowego { get; set; }

    public int? IdProjektuTymczasowego { get; set; }
}
