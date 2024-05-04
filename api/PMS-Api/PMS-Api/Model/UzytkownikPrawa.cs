using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class UzytkownikPrawa
{
    public int? UzytkownicyId { get; set; }

    public string? Konfiguracja { get; set; }

    public int Id { get; set; }

    public virtual Uzytkownicy? Uzytkownicy { get; set; }
}
