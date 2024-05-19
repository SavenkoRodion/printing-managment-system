using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class CennikPrzesylekKlientow
{
    public int Id { get; set; }

    public int RodzajeDostawyId { get; set; }

    public int KrajeId { get; set; }

    public int? UzytkownicyId { get; set; }

    public string? KwotaBrutto { get; set; }

    public sbyte CzyDarmowaDostawa { get; set; }

    public string? KwotaZamowieniaDarmowejDostawy { get; set; }

    public int Kolejnosc { get; set; }

    public sbyte CzyDomyslne { get; set; }
}
