using WebApp1.Middleware;
using WebApp1.Repository;
using WebApp1.Repository.Interfaces;
using WebApp1.Services;
using WebApp1.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddSingleton<IProductServices, ProductService>();
builder.Services.AddSingleton<IProductRepo, ProductRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseMiddleware<GlobalException>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
