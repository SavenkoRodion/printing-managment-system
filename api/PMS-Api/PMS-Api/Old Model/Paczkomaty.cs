using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Paczkomaty
{
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public string? Ulica { get; set; }

    public string? Miejscowosc { get; set; }

    public string? NumerBudynku { get; set; }

    public string? KodPocztowy { get; set; }

    public sbyte Status { get; set; }
}
