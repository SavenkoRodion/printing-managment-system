using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class Czcionki
{
    public int Id { get; set; }

    public string? Nazwa { get; set; }

    public string? TtfNormalPath { get; set; }

    public string? TtfBoldPath { get; set; }

    public string? TtfItalicPath { get; set; }

    public string? TtfBoldItalicPath { get; set; }

    public string? OtfNormalPath { get; set; }

    public string? OtfBoldPath { get; set; }

    public string? OtfItalicPath { get; set; }

    public string? OtfBoldItalicPath { get; set; }

    public string? EotNormalPath { get; set; }

    public string? EotBoldPath { get; set; }

    public string? EotItalicPath { get; set; }

    public string? EotBoldItalicPath { get; set; }

    public string? WoffNormalPath { get; set; }

    public string? WoffBoldPath { get; set; }

    public string? WoffItalicPath { get; set; }

    public string? WoffBoldItalicPath { get; set; }

    public sbyte Openfont { get; set; }

    public sbyte Domyslna { get; set; }
}
