using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class KontrahenciWybrani
{
    public int Id { get; set; }

    public int KontrahentId { get; set; }

    public int UserId { get; set; }

    public sbyte Domyslny { get; set; }

    public virtual Kontrahenci Kontrahent { get; set; } = null!;
}
