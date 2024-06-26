﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DesafioApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240523200415_TesteMigracao")]
    partial class TesteMigracao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Users", b =>
                {
                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<int>("ageregistered")
                        .HasColumnType("integer");

                    b.Property<string>("cell")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dateofbirth")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dateregistered")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("latitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("longitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("md5")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nameid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("passwordlogin")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("picturelarge")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("picturemedium")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("postcode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sha1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sha256")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("statelocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("streetname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("streetnumber")
                        .HasColumnType("integer");

                    b.Property<string>("thumbnail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("timezonedescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("timezoneoffset")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("uuidlogin")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("valueid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("email");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
