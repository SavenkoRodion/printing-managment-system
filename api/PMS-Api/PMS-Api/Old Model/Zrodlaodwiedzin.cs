using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Zrodlaodwiedzin
{
    public int Id { get; set; }

    public string? CampaignSource { get; set; }

    public string? CampaignName { get; set; }

    public string? CampaignMedium { get; set; }

    public string? CampaignContent { get; set; }

    public string? CampaignTerm { get; set; }

    public string? FirstVisit { get; set; }

    public string? PreviousVisit { get; set; }

    public string? CurrentVisitStarted { get; set; }

    public string? TimesVisited { get; set; }

    public string? PagesViewed { get; set; }

    public int? ZamowienieId { get; set; }
}
