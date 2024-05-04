using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class PrzesylkiKonfiguracja
{
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public string? KwotaBrutto { get; set; }

    public sbyte CzyDarmowaDostawa { get; set; }

    public sbyte CzyDomyslne { get; set; }

    public string? KwotaZamowieniaDarmowejDostawy { get; set; }

    public sbyte Visible { get; set; }
}
