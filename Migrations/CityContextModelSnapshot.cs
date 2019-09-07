﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZipIt.Models;

namespace ZipIt.Migrations
{
    [DbContext(typeof(CityContext))]
    partial class CityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ZipIt.Models.City", b =>
                {
                    b.Property<string>("Zip")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityName");

                    b.Property<string>("CityZip");

                    b.Property<float>("Lat");

                    b.Property<float>("Lng");

                    b.Property<string>("StateId");

                    b.Property<string>("StateName");

                    b.Property<string>("TimeZone");

                    b.HasKey("Zip");

                    b.HasIndex("CityZip");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("ZipIt.Models.City", b =>
                {
                    b.HasOne("ZipIt.Models.City")
                        .WithMany("Cities")
                        .HasForeignKey("CityZip");
                });
#pragma warning restore 612, 618
        }
    }
}