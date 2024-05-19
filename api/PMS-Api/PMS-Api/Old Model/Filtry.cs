using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Filtry
{
    public int Id { get; set; }

    public string Grupa { get; set; } = null!;

    public string Nazwa { get; set; } = null!;

    public string Wartosc { get; set; } = null!;
}
