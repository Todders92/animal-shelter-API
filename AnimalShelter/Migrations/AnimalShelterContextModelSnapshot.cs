﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 8,
                            Gender = "Male",
                            Name = "Stitch",
                            Species = "Black Lab"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 2,
                            Gender = "Male",
                            Name = "Morgan",
                            Species = "Gray Tuxedo"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Gender = "Female",
                            Name = "Mindy",
                            Species = "Gray Tabby"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 3,
                            Gender = "Male",
                            Name = "Magic Mike",
                            Species = "Lab/Pitbull mix"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 9,
                            Gender = "Male",
                            Name = "Tigger",
                            Species = "Gray Tabby"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
