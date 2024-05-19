using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Klientcennik
{
    public int Id { get; set; }

    public int? UzytkownicyId { get; set; }

    public int? CennikId { get; set; }
}
