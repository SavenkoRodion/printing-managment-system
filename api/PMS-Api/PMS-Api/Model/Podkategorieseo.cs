using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Podkategorieseo
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Keywords { get; set; }

    public string? Description { get; set; }

    public string? Header { get; set; }

    public string? HeaderDesc { get; set; }

    public int? PodkategorieId { get; set; }
}
