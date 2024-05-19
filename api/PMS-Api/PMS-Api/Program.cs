using Microsoft.EntityFrameworkCore;
using PMS_Api.Helpers;
using PMS_Api.Model;
using PMS_Api.Services;

var MyAllowSpecificOrigins = "devStageOrigins";

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(name: MyAllowSpecificOrigins,
                          builder =>
                          {
                              builder.WithOrigins("http://localhost:5173");
                          });
    });


    builder.Services.AddControllers();

    builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

    builder.Services.AddScoped<IUserService, UserService>();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();



    builder.Services.AddDbContext<VeraprintContext>(
                    options => options.UseSqlServer("connectionString"));


}

var app = builder.Build();

{
    /*app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseRouting();*/


    /*app.UseHttpsRedirection();
    app.UseAuthentication();
    app.UseAuthorization();*/
    app.UseCors(MyAllowSpecificOrigins);
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseMiddleware<JwtMiddleware>();
    /*app.UseHttpsRedirection();
    app.UseAuthorization();*/


    app.MapControllers();
}


app.Run();