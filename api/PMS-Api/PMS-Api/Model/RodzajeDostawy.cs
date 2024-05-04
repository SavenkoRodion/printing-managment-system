using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class RodzajeDostawy
{
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public string? NazwaEn { get; set; }

    public string? NazwaDe { get; set; }

    public int? Identyfikator { get; set; }

    public int Kolejnosc { get; set; }
}
