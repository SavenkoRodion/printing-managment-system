using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using PMS_Api;

var MyAllowSpecificOrigins = "devStageOrigins";

var builder = WebApplication.CreateBuilder(args);

var cookiePolicyOptions = new CookiePolicyOptions
{
    MinimumSameSitePolicy = SameSiteMode.None,
};

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Events = new CookieAuthenticationEvents
        {
            OnRedirectToLogin = context =>
            {
                context.HttpContext.Response.StatusCode = 401;
                return Task.CompletedTask;
            }
        };
        options.Cookie.Name = "lol";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        options.SlidingExpiration = true;
        options.AccessDeniedPath = "/Forbidden/";
        options.Cookie.HttpOnly = false;
    });

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("https://localhost:5173");
                          builder.AllowAnyMethod();
                          builder.AllowAnyHeader();
                          builder.AllowCredentials();
                      });
});
IConfigurationRoot config = new ConfigurationBuilder()
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString = config.GetConnectionString("VeraprintContext");

builder.Services.AddDbContext<VeraprintContext>(
    options => options.UseMySQL(connectionString));

builder.Services.AddControllers();

var app = builder.Build();
app.UseCors(MyAllowSpecificOrigins);
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCookiePolicy(cookiePolicyOptions);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication();
app.UseAuthorization();



app.MapRazorPages();
app.MapDefaultControllerRoute();

app.MapControllers();

app.Run();
