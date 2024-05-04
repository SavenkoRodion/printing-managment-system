using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class KodyProgramPartnerski
{
    public int Id { get; set; }

    public string? Kod { get; set; }

    public string? DataUtworzenia { get; set; }

    public string? DataWykorzystania { get; set; }

    public sbyte? Aktywny { get; set; }

    public int ParentUserId { get; set; }

    public int? UserId { get; set; }
}
