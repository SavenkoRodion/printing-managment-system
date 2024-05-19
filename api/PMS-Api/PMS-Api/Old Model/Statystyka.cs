using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Statystyka
{
    public int Id { get; set; }

    public string? Uid { get; set; }

    public string? Pagename { get; set; }

    public string? Shortpagename { get; set; }

    public string? NextPagename { get; set; }

    public string? NextShortpagename { get; set; }

    public string? Timestamp { get; set; }

    public string? Howlong { get; set; }

    public string? Requesttype { get; set; }

    public sbyte? Lastpage { get; set; }
}
