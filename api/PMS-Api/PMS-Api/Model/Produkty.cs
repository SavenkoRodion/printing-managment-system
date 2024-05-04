using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Produkty
{
    public int Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public string IkonaSciezka { get; set; } = null!;

    public string Szablon { get; set; } = null!;

    public string? DataUtworzenia { get; set; }

    public string? DataAktualizacji { get; set; }

    public virtual ICollection<ProduktyKlientow> ProduktyKlientows { get; set; } = new List<ProduktyKlientow>();

    public virtual ICollection<Produktyzapisane> Produktyzapisanes { get; set; } = new List<Produktyzapisane>();
}
