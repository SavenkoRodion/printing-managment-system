using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class PaczkomatyKonfiguracja
{
    public int Id { get; set; }

    public string? Konfiguracja { get; set; }

    public string? KonfiguracjaTymczasowa { get; set; }

    public string? DataUtworzenia { get; set; }

    public string? DataAktualizacji { get; set; }
}
