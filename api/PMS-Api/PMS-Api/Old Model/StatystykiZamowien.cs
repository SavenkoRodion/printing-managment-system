using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class StatystykiZamowien
{
    public int Id { get; set; }

    public string? KwotaZamowieniaZlozone { get; set; }

    public string? KwotaZamowieniaOplacone { get; set; }

    public string? KwotaZamowieniaStrukturaZlozone { get; set; }

    public string? KwotaZamowieniaStrukturaOplacone { get; set; }

    public string? KwotaPrzesylkaZlozone { get; set; }

    public string? KwotaPrzesylkaOplacone { get; set; }

    public string? KwotaPrzesylkaStrukturaZlozone { get; set; }

    public string? KwotaPrzesylkaStrukturaOplacone { get; set; }

    public string? DataStatystyki { get; set; }

    public string? StrukturaProwizja { get; set; }

    public int UserId { get; set; }
}
