using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class KampaniaMailingowa
{
    public int Id { get; set; }

    public string? Uid { get; set; }

    public sbyte? DomyslnyLayout { get; set; }

    public string? NazwaKampanii { get; set; }

    public string? DataUtworzenia { get; set; }

    public string? DataUruchomienia { get; set; }

    public string? DataZakonczenia { get; set; }

    public sbyte? Status { get; set; }

    public string? LandingpageCss { get; set; }

    public string? LandingpageHtml { get; set; }

    public int? CennikId { get; set; }
}
