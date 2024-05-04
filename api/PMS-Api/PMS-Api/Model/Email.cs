using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Email
{
    public int Id { get; set; }

    public string? Email1 { get; set; }

    public int? Typ { get; set; }

    public int? RodzajemailiId { get; set; }
}
