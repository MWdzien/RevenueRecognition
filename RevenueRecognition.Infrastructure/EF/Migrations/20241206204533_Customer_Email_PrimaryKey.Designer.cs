﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RevenueRecognition.Infrastructure.EF.Contexts;

#nullable disable

namespace RevenueRecognition.Infrastructure.EF.Migrations
{
    [DbContext(typeof(ReadDbContext))]
    [Migration("20241206204533_Customer_Email_PrimaryKey")]
    partial class Customer_Email_PrimaryKey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("default")
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RevenueRecognition.Infrastructure.EF.Models.CustomerReadModel", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Address");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("Email");

                    b.ToTable("Customers", "default");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("RevenueRecognition.Infrastructure.EF.Models.CompanyCustomerReadModel", b =>
                {
                    b.HasBaseType("RevenueRecognition.Infrastructure.EF.Models.CustomerReadModel");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CompanyName");

                    b.Property<string>("Krs")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Krs");

                    b.ToTable("CompanyCustomers", "default");
                });

            modelBuilder.Entity("RevenueRecognition.Infrastructure.EF.Models.IndividualCustomerReadModel", b =>
                {
                    b.HasBaseType("RevenueRecognition.Infrastructure.EF.Models.CustomerReadModel");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("LastName");

                    b.Property<string>("Pesel")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Pesel");

                    b.ToTable("IndividualCustomers", "default");
                });

            modelBuilder.Entity("RevenueRecognition.Infrastructure.EF.Models.CompanyCustomerReadModel", b =>
                {
                    b.HasOne("RevenueRecognition.Infrastructure.EF.Models.CustomerReadModel", null)
                        .WithOne()
                        .HasForeignKey("RevenueRecognition.Infrastructure.EF.Models.CompanyCustomerReadModel", "Email")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RevenueRecognition.Infrastructure.EF.Models.IndividualCustomerReadModel", b =>
                {
                    b.HasOne("RevenueRecognition.Infrastructure.EF.Models.CustomerReadModel", null)
                        .WithOne()
                        .HasForeignKey("RevenueRecognition.Infrastructure.EF.Models.IndividualCustomerReadModel", "Email")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
