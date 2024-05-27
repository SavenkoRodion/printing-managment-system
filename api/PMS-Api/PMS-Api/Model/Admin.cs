using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Admin
{
    public string Uuid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
