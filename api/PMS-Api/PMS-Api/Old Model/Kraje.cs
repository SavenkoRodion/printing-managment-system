using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Kraje
{
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public string? NazwaEn { get; set; }

    public string? NazwaDe { get; set; }

    public string? Kod { get; set; }

    public int Kolejnosc { get; set; }
}
