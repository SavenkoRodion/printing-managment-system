using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class CentraKosztowe
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public string Nazwa { get; set; } = null!;

    public virtual ICollection<CentraNazwy> CentraNazwies { get; set; } = new List<CentraNazwy>();

    public virtual ICollection<CentraWybrane> CentraWybranes { get; set; } = new List<CentraWybrane>();

    public virtual Uzytkownicy IdUserNavigation { get; set; } = null!;
}
