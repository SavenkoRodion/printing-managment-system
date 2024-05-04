using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Tempimagegroup
{
    public int Id { get; set; }

    public string? PlikGrupy { get; set; }

    public string? Salt { get; set; }

    public DateTime Datautworzenia { get; set; }
}
