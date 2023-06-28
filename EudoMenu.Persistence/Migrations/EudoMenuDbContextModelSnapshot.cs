﻿// <auto-generated />
using System;
using EudoMenu.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EudoMenu.Persistence.Migrations
{
    [DbContext(typeof(EudoMenuDbContext))]
    partial class EudoMenuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EudoMenu.Domain.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MealId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MealId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0f4933cb-9a38-458d-9110-f003cd539066"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "olive oil",
                            Quantity = "2 tbsp"
                        },
                        new
                        {
                            Id = new Guid("9a6181e0-e5d9-4d6d-be0d-50f63d3d68ae"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "ginger",
                            Quantity = "4cm piece finely chopped"
                        },
                        new
                        {
                            Id = new Guid("d8371e5a-7fc1-42c6-8c77-76f592342190"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "garlic",
                            Quantity = "2 cloves peeled and chopped"
                        },
                        new
                        {
                            Id = new Guid("42435edf-a680-4e47-af9e-323d08677696"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "tomatoes",
                            Quantity = "800g peeled and chopped "
                        },
                        new
                        {
                            Id = new Guid("d625fbb9-4631-49c4-9478-a1c13f6935a4"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "lemon juice",
                            Quantity = "2 tbsp"
                        },
                        new
                        {
                            Id = new Guid("601c2181-1685-4610-8765-de888c64c6bd"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "caster sugar",
                            Quantity = "1 tsp"
                        },
                        new
                        {
                            Id = new Guid("7a1066b1-e7ee-4448-8fae-be50907a4141"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "vine leaves",
                            Quantity = "50"
                        },
                        new
                        {
                            Id = new Guid("d97b84ac-064a-4d38-b750-1d12c481c278"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "fennel bulb",
                            Quantity = "1 large"
                        },
                        new
                        {
                            Id = new Guid("3f5f7eb4-b5af-487d-8a29-d963f991ef22"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "lamb mince",
                            Quantity = "400g"
                        },
                        new
                        {
                            Id = new Guid("b39726cb-442b-4cd9-bdcb-2045d080cb17"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "onion",
                            Quantity = "1 medium"
                        },
                        new
                        {
                            Id = new Guid("256d3798-16fa-4977-8ca6-388ea6a78501"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "potato",
                            Quantity = "1 small peeled and coarsely grated"
                        },
                        new
                        {
                            Id = new Guid("27797d19-4dd3-40de-b879-01561603e5cd"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "basmati rice",
                            Quantity = "2 tbsp"
                        },
                        new
                        {
                            Id = new Guid("77fda041-c491-443c-8b3e-726aafca1236"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "chopped parsley",
                            Quantity = "2 tbsp"
                        },
                        new
                        {
                            Id = new Guid("6bd6cf07-e3a1-454c-a537-931a4714ab3b"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "coriander",
                            Quantity = "2 tbsp chopped"
                        },
                        new
                        {
                            Id = new Guid("cb96b3ce-5e4b-48e1-9222-2d0bb61168f9"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "lemon juice",
                            Quantity = "1 tbsp"
                        },
                        new
                        {
                            Id = new Guid("bc493166-141e-45a9-b364-69f4ce04c626"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "garlic",
                            Quantity = "2 cloves"
                        },
                        new
                        {
                            Id = new Guid("d043b2c9-cdd3-4d97-8bc2-7fb364d2192f"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "clove",
                            Quantity = "½ tsp ground"
                        },
                        new
                        {
                            Id = new Guid("1433fc54-ad78-4ce4-8d06-1ad394b809d0"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "cinnamon",
                            Quantity = "½ tsp ground "
                        },
                        new
                        {
                            Id = new Guid("ddfa0742-6f97-447a-b1ce-7bb0f29f87b4"),
                            MealId = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Name = "tomatoes",
                            Quantity = "2 medium"
                        },
                        new
                        {
                            Id = new Guid("32b3c5f5-69b4-4d23-aade-623205a73441"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Beef",
                            Quantity = "1/2 lb"
                        },
                        new
                        {
                            Id = new Guid("f284e04c-3605-40d9-bd79-e536b25df6a7"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Salt",
                            Quantity = "1/2 tsp"
                        },
                        new
                        {
                            Id = new Guid("15bd0300-35c4-4d14-bcc8-444f9e65b728"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Sesame Seed Oil",
                            Quantity = "1 tsp "
                        },
                        new
                        {
                            Id = new Guid("b2acbcb4-5499-4d42-950a-b2e7ed6afe1d"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Pepper",
                            Quantity = "1 pinch"
                        },
                        new
                        {
                            Id = new Guid("edc9e09e-7b03-4a71-91c9-5d2b3a7a2892"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Egg White",
                            Quantity = "1"
                        },
                        new
                        {
                            Id = new Guid("49c6725e-a332-448d-8091-5bb725ab3a2c"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Starch",
                            Quantity = "3 tbs"
                        },
                        new
                        {
                            Id = new Guid("50237ef8-cae6-4811-a8fd-12d8c6876b46"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Oil",
                            Quantity = "4 tbs"
                        },
                        new
                        {
                            Id = new Guid("db04a594-6f41-4f9b-8bac-6ac56e7d0c2e"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Ginger",
                            Quantity = "1 tsp "
                        },
                        new
                        {
                            Id = new Guid("b915390e-140a-466a-b082-e78b5d3c6ce5"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Garlic",
                            Quantity = "1 tsp "
                        },
                        new
                        {
                            Id = new Guid("26b7c0dd-4886-49e1-9a11-a7a71e042140"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Onion",
                            Quantity = "3/4 cup "
                        },
                        new
                        {
                            Id = new Guid("1b6d14a8-398d-43b3-bcf1-a67176d9fdba"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Carrots",
                            Quantity = "1/2 cup "
                        },
                        new
                        {
                            Id = new Guid("69e8e302-5031-4ce8-a689-bae05bee11b9"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Green Pepper",
                            Quantity = "3/4 cup "
                        },
                        new
                        {
                            Id = new Guid("91db5660-d061-49fa-8a7f-e1e149cbf25d"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Celery",
                            Quantity = "1 cup "
                        },
                        new
                        {
                            Id = new Guid("f8bef1c0-bb4b-4ea0-a8b4-fd95813d9bf8"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Mushrooms",
                            Quantity = "1 cup "
                        },
                        new
                        {
                            Id = new Guid("920f6775-77b4-4258-b573-0a4f33052990"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Cooking wine",
                            Quantity = "1 tbs"
                        },
                        new
                        {
                            Id = new Guid("6890f68e-78b4-4dc6-a3d5-8b4757b3e644"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Water",
                            Quantity = "1 cup "
                        },
                        new
                        {
                            Id = new Guid("dedc8c85-b918-4049-b3e3-492983889a75"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Oyster Sauce",
                            Quantity = "1 tbs"
                        },
                        new
                        {
                            Id = new Guid("668cf1b5-49e7-4b90-b629-1a298307ab08"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Hotsauce",
                            Quantity = "1/2 tsp"
                        },
                        new
                        {
                            Id = new Guid("b18b1bce-e813-477b-a3eb-000d267e3364"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Sugar",
                            Quantity = "1 tsp "
                        },
                        new
                        {
                            Id = new Guid("0481fc0a-1a0d-4db1-b315-d940a94501dd"),
                            MealId = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Name = "Soy Sauce",
                            Quantity = "1 tbs"
                        });
                });

            modelBuilder.Entity("EudoMenu.Domain.Meal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrinkAlternate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Youtube")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("575dc7ad-d105-4e84-af0f-d54dafdcf1d7"),
                            Area = "Moroccan",
                            Category = "Lamb",
                            Instructions = "Use pickled vine leaves here, preserved in brine. Small delicate leaves are better than the large bristly ones but, if only large leaves are to hand, then trim them to roughly 12 by 12 cms so that you don't get too many layers of leaves around the filling. And remove any stalks. Drain the preserved leaves, immerse them in boiling water for 10 minutes and then leave to dry on a tea towel before use. \r\nBasmati rice with butter and pine nuts is an ideal accompaniment. Couscous is great, too. Serves four.\r\nFirst make the filling. Put all the ingredients, apart from the tomatoes, in a bowl. Cut the tomatoes in half, coarsely grate into the bowl and discard the skins. Add half a teaspoon of salt and some black pepper, and stir. Leave on the side, or in the fridge, for up to a day. Before using, gently squeeze with your hands and drain away any juices that come out.\r\nTo make the sauce, heat the oil in a medium pan. Add the ginger and garlic, cook for a minute or two, taking care not to burn them, then add the tomato, lemon juice and sugar. Season, and simmer for 20 minutes.\r\nWhile the sauce is bubbling away, prepare the vine leaves. Use any torn or broken leaves to line the base of a wide, heavy saucepan. Trim any leaves from the fennel, cut it vertically into 0.5cm-thick slices and spread over the base of the pan to cover completely.\r\nLay a prepared vine leaf (see intro) on a work surface, veiny side up. Put two teaspoons of filling at the base of the leaf in a 2cm-long by 1cm-wide strip. Fold the sides of the leaf over the filling, then roll it tightly from bottom to top, in a cigar shape. Place in the pan, seam down, and repeat with the remaining leaves, placing them tightly next to each other in lines or circles (in two layers if necessary).\r\nPour the sauce over the leaves (and, if needed, add water just to cover). Place a plate on top, to weigh the leaves down, then cover with a lid. Bring to a boil, reduce the heat and cook on a bare simmer for 70 minutes. Most of the liquid should evaporate. Remove from the heat, and leave to cool a little - they are best served warm. When serving, bring to the table in the pan - it looks great. Serve a few vine leaves and fennel slices with warm rice. Spoon the braising juices on top and garnish with coriander.",
                            Name = "Lamb tomato and sweet spices",
                            RestaurantId = new Guid("0a99aec6-044a-4a1e-897e-54fb39a84155"),
                            Tags = "",
                            Thumb = "https://www.themealdb.com/images/media/meals/qtwtss1468572261.jpg",
                            Youtube = "https://www.youtube.com/watch?v=vaZb1MnFBgA"
                        },
                        new
                        {
                            Id = new Guid("71e54599-8a61-406b-82f3-d25cc589df92"),
                            Area = "Chinese",
                            Category = "Beef",
                            Instructions = "STEP 1 - MARINATING THE BEEF\r\nIn a bowl, add the beef, salt, sesame seed oil, white pepper, egg white, 2 Tablespoon of corn starch and 1 Tablespoon of oil.\r\nSTEP 2 - STIR FRY\r\nFirst Cook the beef by adding 2 Tablespoon of oil until the beef is golden brown.\r\nSet the beef aside\r\nIn a wok add 1 Tablespoon of oil, minced ginger, minced garlic and stir-fry for few seconds.\r\nNext add all of the vegetables and then add sherry cooking wine and 1 cup of water.\r\nTo make the sauce add oyster sauce, hot pepper sauce, and sugar.\r\nadd the cooked beef and 1 spoon of soy sauce\r\nTo thicken the sauce, whisk together 1 Tablespoon of cornstarch and 2 Tablespoon of water in a bowl and slowly add to your stir-fry until it's the right thickness.",
                            Name = "Szechuan Beef",
                            RestaurantId = new Guid("0a99aec6-044a-4a1e-897e-54fb39a84155"),
                            Thumb = "https://www.themealdb.com/images/media/meals/1529443236.jpg",
                            Youtube = "https://www.youtube.com/watch?v=SQGZqZYz7Ms"
                        });
                });

            modelBuilder.Entity("EudoMenu.Domain.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0a99aec6-044a-4a1e-897e-54fb39a84155"),
                            Adress = "78 Avenue Franklin, Paris",
                            ImageUrl = "https://img.freepik.com/vecteurs-premium/logo-style-vintage-retro-restaurant_642964-120.jpg?w=2000",
                            Name = "Restaurant 1",
                            Phone = "0601 67 57 88 23",
                            Type = "Fast Food"
                        });
                });

            modelBuilder.Entity("EudoMenu.Domain.Ingredient", b =>
                {
                    b.HasOne("EudoMenu.Domain.Meal", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EudoMenu.Domain.Meal", b =>
                {
                    b.HasOne("EudoMenu.Domain.Restaurant", "restaurant")
                        .WithMany("Meals")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("restaurant");
                });

            modelBuilder.Entity("EudoMenu.Domain.Meal", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("EudoMenu.Domain.Restaurant", b =>
                {
                    b.Navigation("Meals");
                });
#pragma warning restore 612, 618
        }
    }
}
