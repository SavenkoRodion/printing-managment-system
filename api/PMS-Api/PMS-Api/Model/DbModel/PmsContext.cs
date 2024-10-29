﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace PMS_Api.Model.DbModel;

public class PmsContext : DbContext
{
    public PmsContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Admin>().HasData(new { Uuid = Guid.NewGuid(), Name="Admin", Email="testemail@test.com", Password="1234" });
    }

    public virtual DbSet<Admin> Admins { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Parameter> Parameters { get; set; }

}