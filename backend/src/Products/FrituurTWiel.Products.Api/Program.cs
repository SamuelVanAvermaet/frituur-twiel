using System.Text.Json.Serialization;
using Azure.Identity;
using FrituurTwiel.Products.Domain.Services;
using FrituurTWiel.Products.Persistence;
using FrituurTWiel.Products.Domain.Services;
using FrituurTWiel.Products.Domain.Services.Interfaces;
using FrituurTWiel.Products.Persistence.DataModel;
using FrituurTWiel.Products.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.Converters.Add(
        new JsonStringEnumConverter());
});


builder.Services.AddDbContext<FrituurTWielDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        builder => builder.MigrationsHistoryTable("__EFMigrationsHistory", "dbo")));

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();



var app = builder.Build();

app.MapControllers();

if (app.Environment.IsDevelopment())
    app.UseExceptionHandler("/error-development");
else
    app.UseExceptionHandler("/error");

app.Run();