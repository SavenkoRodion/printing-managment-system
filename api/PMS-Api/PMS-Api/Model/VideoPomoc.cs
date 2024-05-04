using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class VideoPomoc
{
    public int Id { get; set; }

    public int RootUserId { get; set; }

    public string? Nazwa { get; set; }

    public string? Opis { get; set; }

    public string? PlikUuid { get; set; }

    public string? NazwaPliku { get; set; }

    public int Kolejnosc { get; set; }
}
