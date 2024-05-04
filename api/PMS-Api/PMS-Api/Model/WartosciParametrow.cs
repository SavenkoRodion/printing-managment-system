using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class WartosciParametrow
{
    public int Id { get; set; }

    public int IdParametr { get; set; }

    public string Wartosc { get; set; } = null!;

    public string Wartosc2 { get; set; } = null!;

    public string Wartosc3 { get; set; } = null!;

    public virtual ParametryProduktow IdParametrNavigation { get; set; } = null!;
}
