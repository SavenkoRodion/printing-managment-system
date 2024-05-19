using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Konkursy
{
    public int Id { get; set; }

    public string? NazwaKonkursu { get; set; }

    public string? DataOd { get; set; }

    public string? DataDo { get; set; }

    public sbyte? Aktywny { get; set; }
}
