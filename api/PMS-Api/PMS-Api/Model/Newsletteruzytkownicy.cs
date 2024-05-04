using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Newsletteruzytkownicy
{
    public int Id { get; set; }

    public string? Sumakontrolna { get; set; }

    public sbyte? Active { get; set; }

    public string? Email { get; set; }

    public string? DataAktywacji { get; set; }

    public string? DataRejestracji { get; set; }
}
