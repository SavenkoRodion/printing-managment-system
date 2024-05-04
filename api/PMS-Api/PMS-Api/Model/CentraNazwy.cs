using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class CentraNazwy
{
    public int Id { get; set; }

    public int IdCentra { get; set; }

    public string Nazwa { get; set; } = null!;

    public virtual ICollection<CentraWybrane> CentraWybranes { get; set; } = new List<CentraWybrane>();

    public virtual CentraKosztowe IdCentraNavigation { get; set; } = null!;
}
