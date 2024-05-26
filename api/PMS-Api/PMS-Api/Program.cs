using Microsoft.AspNetCore.Authentication.Cookies;
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
                              builder.AllowAnyHeader();
                              builder.AllowAnyHeader();
                          });
    });


    builder.Services.AddControllers();

    {
        builder.Services.AddScoped<IUserRepository<Admin>, AdminRepository>();
        builder.Services.AddScoped<ICookieAuthenticationService, CookieAuthenticationService>();
    }

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    /*builder.Services.AddDbContext<VeraprintContext>(
                    options => options.UseSqlServer("connectionString"));
    "VeraprintContext": "Server=localhost;Port=3307;Database=veraprint;uid=root;pwd=root;",
     */

    builder.Services.AddDbContext<PmsContext>();

    builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.Name = "auth";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        options.Cookie.HttpOnly = false;
        options.Cookie.SameSite = SameSiteMode.None;
        //options.Cookie.HttpOnly = true;
        //options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    });


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

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();
}


app.Run();