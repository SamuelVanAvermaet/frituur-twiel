using System.Text.Json.Serialization;
using Azure.Identity;
using FrituurTwiel.Products.Domain.Services;
using FrituurTWiel.Products.Persistence;
using FrituurTWiel.Products.Domain.Services.Interfaces;
using FrituurTWiel.Products.Persistence.DataModel;
using FrituurTWiel.Products.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Microsoft.OpenApi;
using System.Text.Json.Nodes;

var builder = WebApplication.CreateBuilder(args);
// Nietmeer nodig, omdat we de JsonStringEnumConverter manueel toevoegen in enum file.
// builder.Services.AddControllers().AddJsonOptions(opt =>
// {
//     opt.JsonSerializerOptions.Converters.Add(
//         new JsonStringEnumConverter());
// });

if (!builder.Environment.IsDevelopment())
{
    builder.Configuration.AddAzureKeyVault(
        new Uri("https://frituur-t-wiel-keyvault.vault.azure.net/"),
        new DefaultAzureCredential()
    );
}


builder.Services.AddDbContext<FrituurTWielDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        builder => builder.MigrationsHistoryTable("__EFMigrationsHistory", "dbo")));

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddOpenApi();
var app = builder.Build();

app.MapControllers();


if (app.Environment.IsDevelopment())
{

    app.MapOpenApi();
    app.MapScalarApiReference();
    app.UseExceptionHandler("/error-development");

}
else
{
    app.UseExceptionHandler("/error");
}

app.Run();