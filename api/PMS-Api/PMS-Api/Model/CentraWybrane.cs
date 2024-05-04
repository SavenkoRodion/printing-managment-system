using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class CentraWybrane
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public int IdCentrak { get; set; }

    public int IdCentran { get; set; }

    public sbyte CzyDomyslne { get; set; }

    public virtual CentraKosztowe IdCentrakNavigation { get; set; } = null!;

    public virtual CentraNazwy IdCentranNavigation { get; set; } = null!;

    public virtual Uzytkownicy IdUserNavigation { get; set; } = null!;
}
