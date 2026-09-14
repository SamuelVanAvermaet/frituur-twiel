using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FrituurTWiel.Products.Persistence.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Products",
                columns: new[] { "Id", "Available", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, true, "SAUS", "", "Mayonaise", 1.1m },
                    { 2, true, "SAUS", "", "Ketchup", 1.1m },
                    { 3, true, "SAUS", "", "Curry", 1.1m },
                    { 4, true, "SAUS", "", "Samurai", 1.1m },
                    { 5, true, "SAUS", "", "Andalouse", 1.1m },
                    { 6, true, "SAUS", "", "Special saus", 2.5m },
                    { 7, true, "FRIETJE", "", "Mini friet", 2.6m },
                    { 8, true, "FRIETJE", "", "Klein friet", 3.0m },
                    { 9, true, "FRIETJE", "", "Middel friet", 3.5m },
                    { 10, true, "FRIETJE", "", "Groot friet", 4.0m },
                    { 11, true, "FRIETJE", "", "Familiepak", 8.5m },
                    { 12, true, "FRIETJE", "", "Romboutje", 8.5m },
                    { 13, true, "FRIETJE", "", "Julienneke", 8.5m },
                    { 14, true, "FRIETJE", "", "Frietje 't Wiel", 8.5m },
                    { 15, true, "FRIETJE", "", "Kinderbox", 8.5m },
                    { 16, true, "BICKY_BURGER", "", "Bicky Burger", 4.2m },
                    { 17, true, "BICKY_BURGER", "", "Bicky Cheese", 4.5m },
                    { 18, true, "BICKY_BURGER", "", "Bicky Chicken", 4.5m },
                    { 19, true, "BICKY_BURGER", "", "Bicky Veggie", 4.5m },
                    { 20, true, "HAMBURGER", "", "Hamburger", 4.0m },
                    { 21, true, "HAMBURGER", "", "Cheeseburger", 4.5m },
                    { 22, true, "HAMBURGER", "", "Chickenburger", 4.5m },
                    { 23, true, "HAMBURGER", "", "Classic (ketchup)", 7.0m },
                    { 24, true, "HAMBURGER", "", "Cheeseburger (kaas & ketchup)", 7.0m },
                    { 25, true, "HAMBURGER", "", "Black Pepper burger", 7.0m },
                    { 26, true, "HAMBURGER", "", "Tok Tok Kedei", 8.0m },
                    { 27, true, "HAMBURGER", "", "Oh My God burger", 8.0m },
                    { 28, true, "HAMBURGER", "", "Burger 'T Wiel", 8.0m },
                    { 29, true, "PASTA", "", "Spaghetti", 9.0m },
                    { 30, true, "PASTA", "", "Macaroni", 9.0m },
                    { 31, true, "DRANK", "", "Cola", 2.5m },
                    { 32, true, "DRANK", "", "Cola Zero", 2.5m },
                    { 33, true, "DRANK", "", "Jupiler", 2.5m },
                    { 34, true, "DRANK", "", "Fanta Lemon", 2.5m },
                    { 35, true, "DRANK", "", "RedBull", 2.5m },
                    { 36, true, "DRANK", "", "Sprite", 2.5m },
                    { 37, true, "DRANK", "", "Ice Tea", 2.5m },
                    { 38, true, "DRANK", "", "Water", 2.5m },
                    { 39, true, "WARME_SAUS", "", "Stoofvleessaus", 2.2m },
                    { 40, true, "WARME_SAUS", "", "Tomatensaus", 2.2m },
                    { 41, true, "WARME_SAUS", "", "Spaghettisaus", 3.0m },
                    { 42, true, "VERSE_BEREIDING", "", "Stoofvlees", 8.0m },
                    { 43, true, "VERSE_BEREIDING", "", "Balletjes in tomatensaus", 8.0m },
                    { 44, true, "VERSE_BEREIDING", "", "Vol-au-vent", 8.0m },
                    { 45, true, "BELEGD_BROODJE", "", "Kaas broodje", 4.5m },
                    { 46, true, "BELEGD_BROODJE", "", "Hesp broodje", 4.5m },
                    { 47, true, "BELEGD_BROODJE", "", "Kaas en hesp", 4.8m },
                    { 48, true, "WARM_BROODJE", "", "Boulet broodje", 7.0m },
                    { 49, true, "WARM_BROODJE", "", "Mexicano broodje", 7.0m },
                    { 50, true, "WARM_BROODJE", "", "Hamburger broodje", 8.0m },
                    { 51, true, "WARM_BROODJE", "", "Stoofvleesschotel", 16.5m },
                    { 52, true, "SCHOTEL", "", "Balletjesschotel", 16.5m },
                    { 53, true, "SCHOTEL", "", "Vol-au-vent schotel", 16.5m },
                    { 54, true, "SCHOTEL", "", "Frikandellenschotel (2)", 16.5m },
                    { 55, true, "SCHOTEL", "", "Bouletten schotel (2)", 16.5m },
                    { 56, true, "SCHOTEL", "", "Kip Korma Curry (rijst)", 16.5m },
                    { 57, true, "SCHOTEL", "", "Scampi Diabolique", 18.5m },
                    { 58, true, "SCHOTEL", "", "Paardenworstenschotel", 18.5m },
                    { 59, true, "SCHOTEL", "", "Saté schotel (2)", 18.5m },
                    { 60, true, "SNACK", "", "Frikandel", 2.2m },
                    { 61, true, "SNACK", "", "Bitterballen", 3.2m },
                    { 62, true, "SNACK", "", "Mexicano", 3.5m },
                    { 63, true, "SNACK", "", "Kaaskroket", 2.6m },
                    { 64, true, "SNACK", "", "Vleeskroket", 2.6m },
                    { 65, true, "SNACK", "", "Chicken nuggets", 4.2m },
                    { 66, true, "SNACK", "", "Frikandel special", 3.0m },
                    { 67, true, "SNACK", "", "Boulet", 2.2m },
                    { 68, true, "SNACK", "", "Boulet special", 3.0m },
                    { 69, true, "SNACK", "", "Cervela", 3.0m },
                    { 70, true, "SNACK", "", "Cervela special", 3.8m },
                    { 71, true, "SNACK", "", "Frikandel XXL", 4.0m },
                    { 72, true, "SNACK", "", "Viandel", 3.2m },
                    { 73, true, "SNACK", "", "Spicy viandel", 3.2m },
                    { 74, true, "SNACK", "", "Zigeunerstick", 3.8m },
                    { 75, true, "SNACK", "", "Grizzly pikant", 4.0m },
                    { 76, true, "SNACK", "", "Kipcorn", 3.2m },
                    { 77, true, "SNACK", "", "Kaas soufflé", 2.6m },
                    { 78, true, "SNACK", "", "chixfingers", 4.2m },
                    { 79, true, "SNACK", "", "Kippets", 4.2m },
                    { 80, true, "SNACK", "", "Loempia met kip", 4.5m },
                    { 81, true, "SNACK", "", "Kippenboutjes", 4.5m },
                    { 82, true, "SNACK", "", "Mozzarellafingers", 4.0m },
                    { 83, true, "SNACK", "", "Bamischijf", 3.5m },
                    { 84, true, "SNACK", "", "Megamix", 5.0m },
                    { 85, true, "SNACK", "", "Kaas kroket", 3.2m },
                    { 86, true, "SNACK", "", "Vlees kroket", 3.2m },
                    { 87, true, "SNACK", "", "Goulashkroket", 3.2m },
                    { 88, true, "SNACK", "", "Garnaalkroket", 4.5m },
                    { 89, true, "SNACK", "", "Taco", 3.5m },
                    { 90, true, "SNACK", "", "Vuurvreter", 3.5m },
                    { 91, true, "SNACK", "", "Kaasballetjes", 3.0m },
                    { 92, true, "SNACK", "", "Ribster", 3.5m },
                    { 93, true, "SNACK", "", "Nacho cheese bites", 4.5m },
                    { 94, true, "SNACK", "", "Viandel speciaal", 4.0m },
                    { 95, true, "SNACK", "", "Gakki", 3.5m },
                    { 96, true, "SNACK", "", "Ragouzi", 3.5m },
                    { 97, true, "SNACK", "", "Lucifer", 3.5m },
                    { 98, true, "SNACK", "", "Pikanto", 3.0m },
                    { 99, true, "SNACK", "", "Piknikker", 4.0m },
                    { 100, true, "SNACK", "", "Saté", 4.6m },
                    { 101, true, "SNACK", "", "Sito", 4.0m },
                    { 102, true, "SNACK", "", "Mammoet (+saus)", 3.5m },
                    { 103, true, "SNACK", "", "Mosseltjes in azijn", 4.0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "dbo");
        }
    }
}
