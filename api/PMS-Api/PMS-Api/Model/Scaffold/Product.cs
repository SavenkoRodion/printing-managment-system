using System;
using System.Collections.Generic;

namespace PMS_Api.Model.Scaffold;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime DateOfCreation { get; set; }
}
