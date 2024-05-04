using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Zamowieniaobsluga
{
    public int Id { get; set; }

    public int? OsobaId { get; set; }

    public int Status { get; set; }

    public int? ZamowienieId { get; set; }
}
