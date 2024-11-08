using Microsoft.EntityFrameworkCore;

namespace PMS_Api.Model.DbModel;

public class PmsContext : DbContext
{
    public PmsContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        var adminAId= new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b");
        var adminBId = new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e");
        var clientAId = new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f");
        var clientBId = new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d");

        builder.Entity<Admin>().HasData(new { Uuid = adminAId, Email = "testemail@test.com", Name = "Admin", Password = "1234", CreatedAt = new DateOnly(2024, 11, 04) });
        builder.Entity<Admin>().HasData(new { Uuid = adminBId, Email = "admin@test.com", Name = "Administrator", Password = "1234", CreatedAt = new DateOnly(2024, 07, 04) });

        

        builder.Entity<Client>().HasData(
            new Client { Uuid = clientAId,  Name = "Client A" },
            new Client { Uuid = clientBId, Name = "Client B" }
        );

        builder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Product 1", DateOfCreation = DateTime.Now },
            new Product { Id = 2, Name = "Product 2", DateOfCreation = DateTime.Now }
        );



        builder.Entity<Project>().HasData(
            new Project
            {
                Id = 1,
                Name = "Project 1",
                ClientId = clientAId,
                ProductId = 1,
                Format = "A4",
                LiczbaStron = 100,
                DateModified = DateTime.Now,
                AdminId = adminAId
            },
            new Project
            {
                Id = 2,
                Name = "Project 2",
                ClientId = clientBId,
                ProductId = 2,
                Format = "A3",
                LiczbaStron = 200,
                DateModified = DateTime.Now,
                AdminId = adminBId
            }
        );
        builder.Entity<Template>().HasData(
            new Template
            {
                Id = 1,
                Name = "Template 1",
                ClientId = clientAId,
                ProductId = 1,
                Format = "A4",
                LiczbaStron = 100,
                DateModified = DateTime.Now,
                AdminId = adminAId
            },
            new Template
            {
                Id = 2,
                Name = "Template 2",
                ClientId = clientBId,
                ProductId = 2,
                Format = "A3",
                LiczbaStron = 200,
                DateModified = DateTime.Now,
                AdminId = adminBId
            }
        ); 
    }

    public virtual DbSet<Admin> Admins { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Project> Projects { get; set; }
    public virtual DbSet<Template> Templates { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Parameter> Parameters { get; set; }

}
