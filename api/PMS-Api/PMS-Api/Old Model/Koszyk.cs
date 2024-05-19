using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Koszyk
{
    public int Id { get; set; }

    public string? DataOstatniejAktywnosci { get; set; }

    public string? Uid { get; set; }

    public int UuidPrzestrzeni { get; set; }

    public int? Status { get; set; }

    public string? DataStatusu { get; set; }

    public int? UzytkownicyId { get; set; }
}
