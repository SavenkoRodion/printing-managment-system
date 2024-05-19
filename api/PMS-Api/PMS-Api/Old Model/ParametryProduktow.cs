using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class ParametryProduktow
{
    public int Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Typ { get; set; } = null!;

    public sbyte? Pokaz { get; set; }

    public virtual ICollection<WartosciParametrow> WartosciParametrows { get; set; } = new List<WartosciParametrow>();
}
