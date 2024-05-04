using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Etykietyproduktyzapisane
{
    public int Id { get; set; }

    public int KlientId { get; set; }

    public string Nazwa { get; set; } = null!;
}
