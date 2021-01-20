﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests;
using Google.Cloud.Spanner.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.MigrationTests.Migrations
{
    [DbContext(typeof(TestMigrationDbContext))]
    partial class TestMigrationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.AllColType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT64");

                    b.Property<bool?>("ColBool")
                        .HasColumnType("BOOL");

                    b.Property<bool[]>("ColBoolArray")
                        .HasColumnType("ARRAY<BOOL>");

                    b.Property<List<bool>>("ColBoolList")
                        .HasColumnType("ARRAY<BOOL>");

                    b.Property<byte[]>("ColBytes")
                        .HasColumnType("BYTES");

                    b.Property<byte[][]>("ColBytesArray")
                        .HasColumnType("ARRAY<BYTES>");

                    b.Property<List<byte[]>>("ColBytesList")
                        .HasColumnType("ARRAY<BYTES>");

                    b.Property<DateTime?>("ColCommitTimestamp")
                        .HasColumnType("TIMESTAMP")
                        .HasAnnotation("UpdateCommitTimestamp", SpannerUpdateCommitTimestamp.OnInsertAndUpdate);

                    b.Property<DateTime?>("ColDate")
                        .HasColumnType("DATE");

                    b.Property<DateTime[]>("ColDateArray")
                        .HasColumnType("ARRAY<DATE>");

                    b.Property<List<DateTime>>("ColDateList")
                        .HasColumnType("ARRAY<DATE>");

                    b.Property<SpannerNumeric?>("ColDecimal")
                        .HasColumnType("NUMERIC");

                    b.Property<SpannerNumeric[]>("ColDecimalArray")
                        .HasColumnType("ARRAY<NUMERIC>");

                    b.Property<List<SpannerNumeric>>("ColDecimalList")
                        .HasColumnType("ARRAY<NUMERIC>");

                    b.Property<double?>("ColDouble")
                        .HasColumnType("FLOAT64");

                    b.Property<double[]>("ColDoubleArray")
                        .HasColumnType("ARRAY<FLOAT64>");

                    b.Property<List<double>>("ColDoubleList")
                        .HasColumnType("ARRAY<FLOAT64>");

                    b.Property<float?>("ColFloat")
                        .HasColumnType("FLOAT64");

                    b.Property<Guid?>("ColGuid")
                        .HasColumnType("STRING");

                    b.Property<int?>("ColInt")
                        .HasColumnType("INT64");

                    b.Property<long?>("ColLong")
                        .HasColumnType("INT64");

                    b.Property<long[]>("ColLongArray")
                        .HasColumnType("ARRAY<INT64>");

                    b.Property<List<long>>("ColLongList")
                        .HasColumnType("ARRAY<INT64>");

                    b.Property<short?>("ColShort")
                        .HasColumnType("INT64");

                    b.Property<string>("ColString")
                        .HasColumnType("STRING");

                    b.Property<string[]>("ColStringArray")
                        .HasColumnType("ARRAY<STRING>");

                    b.Property<List<string>>("ColStringList")
                        .HasColumnType("ARRAY<STRING>");

                    b.Property<DateTime?>("ColTimestamp")
                        .HasColumnType("TIMESTAMP");

                    b.Property<DateTime[]>("ColTimestampArray")
                        .HasColumnType("ARRAY<TIMESTAMP>");

                    b.Property<List<DateTime>>("ColTimestampList")
                        .HasColumnType("ARRAY<TIMESTAMP>");

                    b.Property<uint?>("ColUint")
                        .HasColumnType("INT64");

                    b.HasKey("Id");

                    b.HasIndex("ColDate", "ColCommitTimestamp")
                        .HasAnnotation("Spanner:IsNullFiltered", true);

                    b.ToTable("AllColTypes");
                });

            modelBuilder.Entity("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Article", b =>
                {
                    b.Property<long>("AuthorId")
                        .HasColumnType("INT64");

                    b.Property<long>("ArticleId")
                        .HasColumnType("INT64");

                    b.Property<string>("ArticleContent")
                        .HasColumnType("STRING");

                    b.Property<string>("ArticleTitle")
                        .HasColumnType("STRING");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("TIMESTAMP");

                    b.HasKey("AuthorId", "ArticleId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Author", b =>
                {
                    b.Property<long>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT64");

                    b.Property<string>("FirstName")
                        .HasColumnType("STRING");

                    b.Property<string>("FullName")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("STRING")
                        .HasComputedColumnSql("(ARRAY_TO_STRING([FirstName, LastName], ' ')) STORED");

                    b.Property<string>("LastName")
                        .HasColumnType("STRING");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Category", b =>
                {
                    b.Property<long>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT64");

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("STRING");

                    b.Property<string>("CategoryName")
                        .HasColumnType("STRING");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT64");

                    b.Property<float>("Freight")
                        .HasColumnType("FLOAT64");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("ShipAddress")
                        .HasColumnType("STRING");

                    b.Property<string>("ShipCity")
                        .HasColumnType("STRING");

                    b.Property<string>("ShipCountry")
                        .HasColumnType("STRING");

                    b.Property<string>("ShipName")
                        .HasColumnType("STRING");

                    b.Property<string>("ShipPostalCode")
                        .HasColumnType("STRING");

                    b.Property<string>("ShipRegion")
                        .HasColumnType("STRING");

                    b.Property<string>("ShipVia")
                        .HasColumnType("STRING");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("TIMESTAMP");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.OrderDetail", b =>
                {
                    b.Property<long>("OrderId")
                        .HasColumnType("INT64");

                    b.Property<long>("ProductId")
                        .HasColumnType("INT64");

                    b.Property<float>("Discount")
                        .HasColumnType("FLOAT64");

                    b.Property<int>("Quantity")
                        .HasColumnType("INT64");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("FLOAT64");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT64");

                    b.Property<long>("CategoryId")
                        .HasColumnType("INT64");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("STRING(50)")
                        .HasMaxLength(50);

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Article", b =>
                {
                    b.HasOne("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Author", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.OrderDetail", b =>
                {
                    b.HasOne("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Product", b =>
                {
                    b.HasOne("Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
