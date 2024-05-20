using Microsoft.EntityFrameworkCore;
using PMS_Api;
using PMS_Api.Helpers;
using PMS_Api.Interfaces;
using PMS_Api.Model;
using PMS_Api.Repository;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(name: "devStageOrigins",
                          builder =>
                          {
                              builder.WithOrigins("http://localhost:5173");
                          });
    });


    builder.Services.AddControllers();

    builder.Services.Configure<Secret>(builder.Configuration.GetSection("Authentication"));

    {
        builder.Services.AddScoped<IUserRepository<PMS_Api.Interfaces.User>, UserRepository>();
    }

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddDbContext<VeraprintContext>(
                    options => options.UseSqlServer("connectionString"));

    builder.Services.AddDbContext<PmsContext>(
                    options => options.UseSqlServer());
}

var app = builder.Build();

{
    app.UseHttpsRedirection();

    app.UseCors("devStageOrigins");

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseMiddleware<JwtMiddleware>();

    app.MapControllers();
}


app.Run();