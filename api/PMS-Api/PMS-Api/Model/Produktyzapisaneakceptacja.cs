using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Produktyzapisaneakceptacja
{
    public string? DataProsbyOAkceptacje { get; set; }

    public string? DataWaznosci { get; set; }

    public string? EmailProsbyOAkceptacje { get; set; }

    public string? TytulEmaila { get; set; }

    public string? UidProsby { get; set; }

    public string? DataOdpowiedzi { get; set; }

    public int? Status { get; set; }

    public string? TrescProsby { get; set; }

    public string? TrescOdpowiedzi { get; set; }

    public int ProduktyzapisaneId { get; set; }

    public int Id { get; set; }

    public virtual Produktyzapisane Produktyzapisane { get; set; } = null!;
}
