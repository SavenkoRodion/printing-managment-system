using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class KontaBankoweKonfiguracja
{
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public string? NumerKonta { get; set; }

    public string? SwiftCode { get; set; }

    public sbyte CzyDomyslne { get; set; }

    public sbyte Visible { get; set; }

    public int SprzedawcaId { get; set; }
}
