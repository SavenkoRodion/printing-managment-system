using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Formaty
{
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public int? WymiarmmX { get; set; }

    public int? WymiarmmY { get; set; }

    public int? WymiarpxX { get; set; }

    public int? WymiarpxY { get; set; }

    public int? WymiarminiaturyX { get; set; }

    public int? WymiarminiaturyY { get; set; }
}
