using Asp.Versioning;
using WebApp1.Middleware;
using WebApp1.Repository;
using WebApp1.Repository.Interfaces;
using WebApp1.Services;
using WebApp1.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder
    .Services.AddApiVersioning(options =>
    {
        options.DefaultApiVersion = new ApiVersion(1, 0);
        options.AssumeDefaultVersionWhenUnspecified = true;
        options.ReportApiVersions = true;
    })
    .AddApiExplorer(options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    });

builder.Services.AddSingleton<ITaskService, TaskService>();
builder.Services.AddSingleton<ITaskRepo, TaskRepo>();
builder.Services.AddSingleton<IProductServices, ProductService>();
builder.Services.AddSingleton<IProductRepo, ProductRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseMiddleware<GlobalException>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
