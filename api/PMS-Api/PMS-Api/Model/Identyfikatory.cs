using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Identyfikatory
{
    public int Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Wartosc { get; set; } = null!;

    public int Typ { get; set; }
}
