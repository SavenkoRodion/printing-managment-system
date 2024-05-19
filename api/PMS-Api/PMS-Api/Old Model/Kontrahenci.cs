using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Kontrahenci
{
    public int Id { get; set; }

    public int RootUserId { get; set; }

    public string? Nazwa { get; set; }

    public string? NazwaKontrahenta { get; set; }

    public string? Adres { get; set; }

    public string? KodPocztowy { get; set; }

    public string? Miejscowosc { get; set; }

    public string? Nip { get; set; }

    public sbyte Domyslny { get; set; }

    public virtual ICollection<KontrahenciWybrani> KontrahenciWybranis { get; set; } = new List<KontrahenciWybrani>();
}
