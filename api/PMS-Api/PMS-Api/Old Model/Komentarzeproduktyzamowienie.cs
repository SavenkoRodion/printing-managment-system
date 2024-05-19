using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Komentarzeproduktyzamowienie
{
    public int Id { get; set; }

    public string? Opis { get; set; }

    public string? Data { get; set; }

    public int? Status { get; set; }

    public int? ProduktyzamowienieId { get; set; }
}
