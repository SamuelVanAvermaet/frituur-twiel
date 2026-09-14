using System;
using FrituurTWiel.Products.Persistence.DataModel.Entities;
using static FrituurTWiel.Shared.Contracts.Enums.Category;

namespace FrituurTWiel.Products.Persistence.DataModel.Seed;

public static class ProductSeedData
{
    public static ProductEntity[] GetProducts()
    {
        return new ProductEntity[]
        {new ProductEntity {Id = 1, Name = "Mayonaise", Category = SAUS, Price = 1.1m, Description = "", Available = true },
        new ProductEntity {Id = 2, Name = "Ketchup", Category = SAUS, Price = 1.1m, Description = "", Available = true },
        new ProductEntity {Id = 3, Name = "Curry", Category = SAUS, Price = 1.1m, Description = "", Available = true },
        new ProductEntity {Id = 4, Name = "Samurai", Category = SAUS, Price = 1.1m, Description = "", Available = true },
        new ProductEntity {Id = 5, Name = "Andalouse", Category = SAUS, Price = 1.1m, Description = "", Available = true },
        new ProductEntity {Id = 6, Name = "Special saus", Category = SAUS, Price = 2.5m, Description = "", Available = true },

        // === FRIETJE ===
        new ProductEntity {Id = 7, Name = "Mini friet", Category = FRIETJE, Price = 2.6m, Description = "", Available = true },
        new ProductEntity {Id = 8, Name = "Klein friet", Category = FRIETJE, Price = 3.0m, Description = "", Available = true },
        new ProductEntity {Id = 9, Name = "Middel friet", Category = FRIETJE, Price = 3.5m, Description = "", Available = true },
        new ProductEntity {Id = 10, Name = "Groot friet", Category = FRIETJE, Price = 4.0m, Description = "", Available = true },
        new ProductEntity {Id = 11, Name = "Familiepak", Category = FRIETJE, Price = 8.5m, Description = "", Available = true },
        new ProductEntity {Id = 12, Name = "Romboutje", Category = FRIETJE, Price = 8.5m, Description = "", Available = true },
        new ProductEntity {Id = 13, Name = "Julienneke", Category = FRIETJE, Price = 8.5m, Description = "", Available = true },
        new ProductEntity {Id = 14, Name = "Frietje 't Wiel", Category = FRIETJE, Price = 8.5m, Description = "", Available = true },
        new ProductEntity {Id = 15, Name = "Kinderbox", Category = FRIETJE, Price = 8.5m, Description = "", Available = true },

        // === BICKY BURGERS ===
        new ProductEntity {Id = 16, Name = "Bicky Burger", Category = BICKY_BURGER, Price = 4.2m, Description = "", Available = true },
        new ProductEntity {Id = 17, Name = "Bicky Cheese", Category = BICKY_BURGER, Price = 4.5m, Description = "", Available = true },
        new ProductEntity {Id = 18, Name = "Bicky Chicken", Category = BICKY_BURGER, Price = 4.5m, Description = "", Available = true },
        new ProductEntity {Id = 19, Name = "Bicky Veggie", Category = BICKY_BURGER, Price = 4.5m, Description = "", Available = true },

        // === HAMBURGERS ===
        new ProductEntity {Id = 20, Name = "Hamburger", Category = HAMBURGER, Price = 4.0m, Description = "", Available = true },
        new ProductEntity {Id = 21, Name = "Cheeseburger", Category = HAMBURGER, Price = 4.5m, Description = "", Available = true },
        new ProductEntity {Id = 22, Name = "Chickenburger", Category = HAMBURGER, Price = 4.5m, Description = "", Available = true },
        new ProductEntity {Id = 23, Name = "Classic (ketchup)", Category = HAMBURGER, Price = 7.0m, Description = "", Available = true },
        new ProductEntity {Id = 24, Name = "Cheeseburger (kaas & ketchup)", Category = HAMBURGER, Price = 7.0m, Description = "", Available = true },
        new ProductEntity {Id = 25, Name = "Black Pepper burger", Category = HAMBURGER, Price = 7.0m, Description = "", Available = true },
        new ProductEntity {Id = 26, Name = "Tok Tok Kedei", Category = HAMBURGER, Price = 8.0m, Description = "", Available = true },
        new ProductEntity {Id = 27, Name = "Oh My God burger", Category = HAMBURGER, Price = 8.0m, Description = "", Available = true },
        new ProductEntity {Id = 28, Name = "Burger 'T Wiel", Category = HAMBURGER, Price = 8.0m, Description = "", Available = true },

        // === PASTA ===
        new ProductEntity {Id = 29, Name = "Spaghetti", Category = PASTA, Price = 9.0m, Description = "", Available = true },
        new ProductEntity {Id = 30, Name = "Macaroni", Category = PASTA, Price = 9.0m, Description = "", Available = true },

        // === DRANK ===
        new ProductEntity {Id = 31, Name = "Cola", Category = DRANK, Price = 2.5m, Description = "", Available = true },
        new ProductEntity {Id = 32, Name = "Cola Zero", Category = DRANK, Price = 2.5m, Description = "", Available = true },
        new ProductEntity {Id = 33, Name = "Jupiler", Category = DRANK, Price = 2.5m, Description = "", Available = true },
        new ProductEntity {Id = 34, Name = "Fanta Lemon", Category = DRANK, Price = 2.5m, Description = "", Available = true },
        new ProductEntity {Id = 35, Name = "RedBull", Category = DRANK, Price = 2.5m, Description = "", Available = true },
        new ProductEntity {Id = 36, Name = "Sprite", Category = DRANK, Price = 2.5m, Description = "", Available = true },
        new ProductEntity {Id = 37, Name = "Ice Tea", Category = DRANK, Price = 2.5m, Description = "", Available = true },
        new ProductEntity {Id = 38, Name = "Water", Category = DRANK, Price = 2.5m, Description = "", Available = true },

        // === WARME SAUS ===
        new ProductEntity {Id = 39, Name = "Stoofvleessaus", Category = WARME_SAUS, Price = 2.2m, Description = "", Available = true },
        new ProductEntity {Id = 40, Name = "Tomatensaus", Category = WARME_SAUS, Price = 2.2m, Description = "", Available = true },
        new ProductEntity {Id = 41, Name = "Spaghettisaus", Category = WARME_SAUS, Price =3.0m, Description ="", Available = true },

        // === VERSE BEREIDINGEN ===
        new ProductEntity {Id = 42, Name = "Stoofvlees", Category = VERSE_BEREIDING, Price = 8.0m, Description = "", Available = true },
        new ProductEntity {Id = 43, Name = "Balletjes in tomatensaus", Category = VERSE_BEREIDING, Price = 8.0m, Description = "", Available = true },
        new ProductEntity {Id = 44, Name = "Vol-au-vent", Category = VERSE_BEREIDING, Price = 8.0m, Description = "", Available = true },

        // === BELEGD BROODJE ===
        new ProductEntity {Id = 45, Name = "Kaas broodje", Category = BELEGD_BROODJE, Price = 4.5m, Description = "", Available = true },
        new ProductEntity {Id = 46, Name = "Hesp broodje", Category = BELEGD_BROODJE, Price = 4.5m, Description = "", Available = true },
        new ProductEntity {Id = 47, Name = "Kaas en hesp", Category = BELEGD_BROODJE, Price = 4.8m, Description = "", Available = true },

        // === WARM BROODJE ===
        new ProductEntity {Id = 48, Name = "Boulet broodje", Category = WARM_BROODJE, Price = 7.0m, Description = "", Available = true },
        new ProductEntity {Id = 49, Name = "Mexicano broodje", Category = WARM_BROODJE, Price = 7.0m, Description = "", Available = true },
        new ProductEntity {Id = 50, Name = "Hamburger broodje", Category = WARM_BROODJE, Price = 8.0m, Description = "", Available = true },

        // === SCHOTELS ===
        new ProductEntity {Id = 51, Name = "Stoofvleesschotel", Category = WARM_BROODJE, Price = 16.5m, Description = "", Available = true },
        new ProductEntity {Id = 52, Name = "Balletjesschotel", Category = SCHOTEL, Price = 16.5m, Description = "", Available = true },
        new ProductEntity {Id = 53, Name = "Vol-au-vent schotel", Category = SCHOTEL, Price = 16.5m, Description = "", Available = true },
        new ProductEntity {Id = 54, Name = "Frikandellenschotel (2)", Category = SCHOTEL, Price = 16.5m, Description = "", Available = true },
        new ProductEntity {Id = 55, Name = "Bouletten schotel (2)", Category = SCHOTEL, Price = 16.5m, Description = "", Available = true },
        new ProductEntity {Id = 56, Name = "Kip Korma Curry (rijst)", Category = SCHOTEL, Price = 16.5m, Description = "", Available = true },
        new ProductEntity {Id = 57, Name = "Scampi Diabolique", Category = SCHOTEL, Price = 18.5m, Description = "", Available = true },
        new ProductEntity {Id = 58, Name = "Paardenworstenschotel", Category = SCHOTEL, Price = 18.5m, Description = "", Available = true },
        new ProductEntity {Id = 59, Name = "Saté schotel (2)", Category = SCHOTEL, Price = 18.5m, Description = "", Available = true },

        // === SNACKS ===
        new ProductEntity { Id = 60, Name = "Frikandel", Category = SNACK, Price = 2.2m, Description = "", Available = true },
        new ProductEntity { Id = 61, Name = "Bitterballen", Category = SNACK, Price = 3.2m, Description = "", Available = true },
        new ProductEntity { Id = 62, Name = "Mexicano", Category = SNACK, Price = 3.5m, Description = "", Available = true },
        new ProductEntity { Id = 63, Name = "Kaaskroket", Category = SNACK, Price = 2.6m, Description = "", Available = true },
        new ProductEntity { Id = 64, Name = "Vleeskroket", Category = SNACK, Price = 2.6m, Description = "", Available = true },
        new ProductEntity { Id = 65, Name = "Chicken nuggets", Category = SNACK, Price = 4.2m, Description = "", Available = true },
        new ProductEntity { Id = 66, Name = "Frikandel special", Category = SNACK, Price = 3.0m, Description = "", Available = true },
        new ProductEntity { Id = 67, Name = "Boulet", Category = SNACK, Price = 2.2m, Description = "", Available = true },
        new ProductEntity { Id = 68, Name = "Boulet special", Category = SNACK, Price = 3.0m, Description = "", Available = true },
        new ProductEntity { Id = 69, Name = "Cervela", Category = SNACK, Price = 3.0m, Description = "", Available = true },
        new ProductEntity { Id = 70, Name = "Cervela special", Category = SNACK, Price = 3.8m, Description = "", Available = true },
        new ProductEntity { Id = 71, Name = "Frikandel XXL", Category = SNACK, Price = 4.0m, Description = "", Available = true },
        new ProductEntity { Id = 72, Name = "Viandel", Category = SNACK, Price = 3.2m, Description = "", Available = true },
        new ProductEntity { Id = 73, Name = "Spicy viandel", Category = SNACK, Price = 3.2m, Description = "", Available = true },
        new ProductEntity { Id = 74, Name = "Zigeunerstick", Category = SNACK, Price = 3.8m, Description = "", Available = true },
        new ProductEntity { Id = 75, Name = "Grizzly pikant", Category = SNACK, Price = 4.0m, Description = "", Available = true },
        new ProductEntity { Id = 76, Name = "Kipcorn", Category = SNACK, Price = 3.2m, Description = "", Available = true },
        new ProductEntity { Id = 77, Name = "Kaas soufflé", Category = SNACK, Price = 2.6m, Description = "", Available = true },
        new ProductEntity { Id = 78, Name = "chixfingers", Category = SNACK, Price = 4.2m, Description = "", Available = true },
        new ProductEntity { Id = 79, Name = "Kippets", Category = SNACK, Price = 4.2m, Description = "", Available = true },
        new ProductEntity { Id = 80, Name = "Loempia met kip", Category = SNACK, Price = 4.5m, Description = "", Available = true },
        new ProductEntity { Id = 81, Name = "Kippenboutjes", Category = SNACK, Price = 4.5m, Description = "", Available = true },
        new ProductEntity { Id = 82, Name = "Mozzarellafingers", Category = SNACK, Price = 4.0m, Description = "", Available = true },
        new ProductEntity { Id = 83, Name = "Bamischijf", Category = SNACK, Price = 3.5m, Description = "", Available = true },
        new ProductEntity { Id = 84, Name = "Megamix", Category = SNACK, Price = 5.0m, Description = "", Available = true },
        new ProductEntity { Id = 85, Name = "Kaas kroket", Category = SNACK, Price = 3.2m, Description = "", Available = true },
        new ProductEntity { Id = 86, Name = "Vlees kroket", Category = SNACK, Price = 3.2m, Description = "", Available = true },
        new ProductEntity { Id = 87, Name = "Goulashkroket", Category = SNACK, Price = 3.2m, Description = "", Available = true },
        new ProductEntity { Id = 88, Name = "Garnaalkroket", Category = SNACK, Price = 4.5m, Description = "", Available = true },
        new ProductEntity { Id = 89, Name = "Taco", Category = SNACK, Price = 3.5m, Description = "", Available = true },
        new ProductEntity { Id = 90, Name = "Vuurvreter", Category = SNACK, Price = 3.5m, Description = "", Available = true },
        new ProductEntity { Id = 91, Name = "Kaasballetjes", Category = SNACK, Price = 3.0m, Description = "", Available =true },
        new ProductEntity { Id = 92, Name ="Ribster", Category = SNACK, Price = 3.5m, Description = "", Available = true },
        new ProductEntity { Id = 93, Name = "Nacho cheese bites", Category = SNACK, Price = 4.5m, Description = "", Available = true },
        new ProductEntity { Id = 94, Name = "Viandel speciaal", Category = SNACK, Price = 4.0m, Description = "", Available = true },
        new ProductEntity { Id = 95, Name = "Gakki", Category = SNACK, Price = 3.5m, Description = "", Available = true },
        new ProductEntity { Id = 96, Name = "Ragouzi", Category = SNACK, Price = 3.5m, Description = "", Available = true },
        new ProductEntity { Id = 97, Name = "Lucifer", Category = SNACK, Price = 3.5m, Description = "", Available = true },
        new ProductEntity { Id = 98, Name = "Pikanto", Category = SNACK, Price = 3.0m, Description = "", Available = true },
        new ProductEntity { Id = 99, Name = "Piknikker", Category = SNACK, Price = 4.0m, Description = "", Available = true },
        new ProductEntity { Id = 100, Name = "Saté", Category = SNACK, Price = 4.6m, Description = "", Available = true },
        new ProductEntity { Id = 101, Name = "Sito", Category = SNACK, Price = 4.0m, Description = "", Available = true },
        new ProductEntity { Id = 102, Name = "Mammoet (+saus)", Category = SNACK, Price = 3.5m, Description = "", Available = true },
        new ProductEntity { Id = 103, Name = "Mosseltjes in azijn", Category = SNACK, Price = 4.0m, Description = "", Available = true }};
    }
}