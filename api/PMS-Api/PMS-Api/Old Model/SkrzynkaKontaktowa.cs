using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class SkrzynkaKontaktowa
{
    public int Id { get; set; }

    public string ImieINazwisko { get; set; } = null!;

    public string AdresEmail { get; set; } = null!;

    public string Temat { get; set; } = null!;

    public string? Tresc { get; set; }

    public sbyte? CzySprawdzono { get; set; }
}
