using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Przesylkizamowienium
{
    public int Id { get; set; }

    public int? PrzesylkiId { get; set; }

    public int? ZamowienieId { get; set; }
}
