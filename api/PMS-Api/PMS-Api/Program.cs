﻿using Microsoft.AspNetCore.Authentication.Cookies;
using PMS_Api.Interfaces;
using PMS_Api.Repository;
using PMS_Api.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PMS_Api.Model.DbModel;

var MyAllowSpecificOrigins = "devStageOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.SlidingExpiration = false;
        options.Cookie.HttpOnly = true;
    });

{
    builder.Services.AddScoped<IUserRepository<Admin>, AdminRepository>();
    builder.Services.AddScoped<IAuthService, CookieAuthService>();
    builder.Services.AddScoped<IProjectTypeRepository, ProjectTypeRepository>();
    builder.Services.AddScoped<IClientRepository, ClientRepository>();
    builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
    builder.Services.AddScoped<ITemplateRepository, TemplateRepository>();


}


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

builder.Services.AddDbContext<PmsContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("PmsContext")));

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
