using Microsoft.EntityFrameworkCore;

namespace PMS_Api.Model.DbModel;

public class PmsContext : DbContext
{
    public PmsContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        var adminAId = new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b");
        var adminBId = new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e");
        var clientAId = new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f");
        var clientBId = new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d");

        builder.Entity<Admin>().HasData(new { Uuid = adminAId, Email = "testemail@test.com", Name = "Admin", Password = "1234", CreatedAt = new DateOnly(2024, 11, 04) });
        builder.Entity<Admin>().HasData(new { Uuid = adminBId, Email = "admin@test.com", Name = "Administrator", Password = "1234", CreatedAt = new DateOnly(2024, 07, 04) });



        builder.Entity<Client>().HasData(
            new Client { Uuid = clientAId, Name = "Client A", Email = "client1@test.pl", Address = "Address A", DateOfCreation = DateTime.Now },
            new Client { Uuid = clientBId, Name = "Client B", Email = "client2@test.com", Address = "Address B", DateOfCreation = DateTime.Now }

        );

        builder.Entity<ProjectType>().HasData(
            new ProjectType { Id = 1, Name = "ProjectType 1", DateOfCreation = DateTime.Now },
            new ProjectType { Id = 2, Name = "ProjectType 2", DateOfCreation = DateTime.Now },
            new ProjectType { Id = 3, Name = "ProjectType 3", DateOfCreation = DateTime.Now }
        );



        builder.Entity<Project>().HasData(
            new Project
            {
                Id = 1,
                Name = "Project 1",
                ClientId = clientAId,
                ProjectTypeId = 1,
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
                ProjectTypeId = 2,
                Format = "A3",
                LiczbaStron = 200,
                DateModified = DateTime.Now,
                AdminId = adminBId
            },
            new Project
            {
                Id = 3,
                Name = "Project 3",
                ClientId = clientAId,
                ProjectTypeId = 3,
                Format = "A5",
                LiczbaStron = 300,
                DateModified = DateTime.Now,
                AdminId = adminAId
            },
            new Project
            {
                Id = 4,
                Name = "Project 4",
                ClientId = clientAId,
                ProjectTypeId = 1,
                Format = "A6",
                LiczbaStron = 400,
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
                ProjectTypeId = 1,
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
                ProjectTypeId = 2,
                Format = "A3",
                LiczbaStron = 200,
                DateModified = DateTime.Now,
                AdminId = adminBId
            },
            new Template
            {
                Id = 3,
                Name = "Template 3",
                ClientId = clientBId,
                ProjectTypeId = 3,
                Format = "A5",
                LiczbaStron = 300,
                DateModified = DateTime.Now,
                AdminId = adminAId
            }
        );
    }

    public virtual DbSet<Admin> Admins { get; set; }
    public virtual DbSet<ProjectType> ProjectTypes { get; set; }
    public virtual DbSet<Project> Projects { get; set; }
    public virtual DbSet<Template> Templates { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Parameter> Parameters { get; set; }

}
