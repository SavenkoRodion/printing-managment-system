using Microsoft.EntityFrameworkCore;

namespace PMS_Api.Model.DbModel;

public class PmsContext : DbContext
{
    public PmsContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Admin>().HasData(new { Uuid = new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"), Email = "testemail@test.com", Name = "Admin", Password = "1234", CreatedAt = new DateOnly(2024, 11, 04) });
        builder.Entity<Admin>().HasData(new { Uuid = new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"), Email = "admin@test.com", Name = "Administrator", Password = "1234", CreatedAt = new DateOnly(2024, 07, 04) });
    }

    public virtual DbSet<Admin> Admins { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Project> Projects { get; set; }
    public virtual DbSet<Template> Templates { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Parameter> Parameters { get; set; }

}
