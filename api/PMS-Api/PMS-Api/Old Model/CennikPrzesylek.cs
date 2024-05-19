using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class CennikPrzesylek
{
    public int Id { get; set; }

    public int RodzajeDostawyId { get; set; }

    public int KrajeId { get; set; }

    public string? Waluta { get; set; }

    public string? KwotaBrutto { get; set; }

    public sbyte Domyslna { get; set; }

    public int Kolejnosc { get; set; }
}
