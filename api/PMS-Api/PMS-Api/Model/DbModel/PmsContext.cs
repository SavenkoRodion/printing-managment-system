using Microsoft.EntityFrameworkCore;

namespace PMS_Api.Model.DbModel;

public class PmsContext : DbContext
{
    public PmsContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Admin>().HasData(new { Uuid = new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"), Name = "Admin", Email = "testemail@test.com", Password = "1234" });
    }

    public virtual DbSet<Admin> Admins { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Parameter> Parameters { get; set; }

}
