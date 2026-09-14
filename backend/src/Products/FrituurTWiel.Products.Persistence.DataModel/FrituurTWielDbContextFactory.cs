using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FrituurTWiel.Products.Persistence.DataModel;

public class FrituurTWielDbContextFactory : IDesignTimeDbContextFactory<FrituurTWielDbContext>
{
    public FrituurTWielDbContext CreateDbContext(string[] args)
    {
        var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "FrituurTWiel.Products.Api");

        

        var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .AddAzureKeyVault(new Uri("https://frituur-t-wiel-keyvault.vault.azure.net/"), new DefaultAzureCredential())
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        var optionsBuilder = new DbContextOptionsBuilder<FrituurTWielDbContext>();
        optionsBuilder.UseSqlServer(connectionString,
            builder => builder.MigrationsHistoryTable("__EFMigrationsHistory", "dbo"));

        return new FrituurTWielDbContext(optionsBuilder.Options);
    }
}