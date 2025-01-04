﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransactionRecordApp.Models;

#nullable disable

namespace TransactionRecordApp.Migrations
{
    [DbContext(typeof(TransactionContext))]
    [Migration("20221129161925_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TransactionRecordApp.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("SharePrice")
                        .HasColumnType("float");

                    b.Property<string>("TickerSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionTypeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TransactionId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            TransactionId = 1,
                            CompanyName = "Apple",
                            Quantity = 2,
                            SharePrice = 142.90000000000001,
                            TickerSymbol = "NASDAQ:AAPL",
                            TransactionTypeId = "B"
                        },
                        new
                        {
                            TransactionId = 2,
                            CompanyName = "Ford Motors Company",
                            Quantity = 4,
                            SharePrice = 12.82,
                            TickerSymbol = "NYSE:F",
                            TransactionTypeId = "S"
                        },
                        new
                        {
                            TransactionId = 3,
                            CompanyName = "Alphabet Inc.",
                            Quantity = 100,
                            SharePrice = 2701.7600000000002,
                            TickerSymbol = "NASDAQ:GOOG",
                            TransactionTypeId = "S"
                        },
                        new
                        {
                            TransactionId = 4,
                            CompanyName = "Microsoft Corporation",
                            Quantity = 100,
                            SharePrice = 123.45,
                            TickerSymbol = "NASDAQ:MSFT",
                            TransactionTypeId = "B"
                        });
                });

            modelBuilder.Entity("TransactionRecordApp.Models.TransactionType", b =>
                {
                    b.Property<string>("TransactionTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("CommissionFee")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionTypeId");

                    b.ToTable("TransactionType");

                    b.HasData(
                        new
                        {
                            TransactionTypeId = "S",
                            CommissionFee = 5.9900000000000002,
                            Name = "Sell"
                        },
                        new
                        {
                            TransactionTypeId = "B",
                            CommissionFee = 5.4000000000000004,
                            Name = "Buy"
                        });
                });

            modelBuilder.Entity("TransactionRecordApp.Models.Transaction", b =>
                {
                    b.HasOne("TransactionRecordApp.Models.TransactionType", "TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TransactionType");
                });
#pragma warning restore 612, 618
        }
    }
}
