using PMS_Api.Helpers;
using PMS_Api.Interfaces;
using PMS_Api.Model.Db.Scaffold;
using PMS_Api.Repository;
using PMS_Api.Services;

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
        builder.Services.AddScoped<IUserRepository<Admin>, AdminRepository>();
        builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
    }

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    /*builder.Services.AddDbContext<VeraprintContext>(
                    options => options.UseSqlServer("connectionString"));
    "VeraprintContext": "Server=localhost;Port=3307;Database=veraprint;uid=root;pwd=root;",
     */

    builder.Services.AddDbContext<PmsContext>();
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