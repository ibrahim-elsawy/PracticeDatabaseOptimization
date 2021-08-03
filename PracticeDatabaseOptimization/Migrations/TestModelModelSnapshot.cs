﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PracticeDatabaseOptimization.Models;

namespace PracticeDatabaseOptimization.Migrations
{
    [DbContext(typeof(TestModel))]
    partial class TestModelModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PracticeDatabaseOptimization.Models.DataRow", b =>
                {
                    b.Property<int>("RowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("VarCol1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VarCol2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VarCol3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RowId");

                    b.ToTable("DataRows");

                    b.HasData(
                        new
                        {
                            RowId = 1,
                            DateTime = new DateTime(2021, 8, 3, 2, 52, 39, 656, DateTimeKind.Local).AddTicks(8677),
                            VarCol1 = "Test1",
                            VarCol2 = "Test2",
                            VarCol3 = "Test3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
