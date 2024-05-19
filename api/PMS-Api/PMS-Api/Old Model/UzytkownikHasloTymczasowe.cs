using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class UzytkownikHasloTymczasowe
{
    public int? UzytkownicyId { get; set; }

    public string? Data { get; set; }

    public int? IndexProfilu { get; set; }

    public string? Checksum { get; set; }

    public int Id { get; set; }

    public virtual Uzytkownicy? Uzytkownicy { get; set; }
}
