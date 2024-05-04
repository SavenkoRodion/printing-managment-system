using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class KonfiguracjaUzytkownika
{
    public int Id { get; set; }

    public int? UzytkownicyId { get; set; }

    public string? Konfiguracja { get; set; }
}
