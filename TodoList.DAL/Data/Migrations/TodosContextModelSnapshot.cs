﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoList.DAL.Data.Context;

#nullable disable

namespace TodoList.DAL.Migrations
{
    [DbContext(typeof(TodosContext))]
    partial class TodosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TodoList.DAL.Data.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeadLine = new DateTime(2024, 3, 22, 16, 51, 23, 907, DateTimeKind.Local).AddTicks(3924),
                            Name = "Models",
                            description = "Models for Every Entity"
                        },
                        new
                        {
                            Id = 2,
                            DeadLine = new DateTime(2024, 3, 23, 16, 51, 23, 907, DateTimeKind.Local).AddTicks(3976),
                            Name = "Views",
                            description = "Views for Every Controller"
                        },
                        new
                        {
                            Id = 3,
                            DeadLine = new DateTime(2024, 3, 24, 16, 51, 23, 907, DateTimeKind.Local).AddTicks(3980),
                            Name = "Validations",
                            description = "Validate User input"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
