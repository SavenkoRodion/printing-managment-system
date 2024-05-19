using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class ZdaniaSynonimy
{
    public int Id { get; set; }

    public string? Tekst { get; set; }

    public int? ZdaniaId { get; set; }
}
