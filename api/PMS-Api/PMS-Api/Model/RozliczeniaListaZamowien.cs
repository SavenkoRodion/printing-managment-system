using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class RozliczeniaListaZamowien
{
    public int Id { get; set; }

    public int? ZamowienieId { get; set; }

    public int RozliczeniaId { get; set; }
}
