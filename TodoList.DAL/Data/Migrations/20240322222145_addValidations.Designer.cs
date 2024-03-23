﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoList.DAL.Data.Context;

#nullable disable

namespace TodoList.DAL.Migrations
{
    [DbContext(typeof(TodosContext))]
    [Migration("20240322222145_addValidations")]
    partial class addValidations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("DATEADD(hour, 2, GETDATE())");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeadLine = new DateTime(2024, 3, 24, 0, 21, 44, 447, DateTimeKind.Local).AddTicks(7634),
                            Description = "Models for Every Entity",
                            Name = "Models"
                        },
                        new
                        {
                            Id = 2,
                            DeadLine = new DateTime(2024, 3, 25, 0, 21, 44, 447, DateTimeKind.Local).AddTicks(7702),
                            Description = "Views for Every Controller",
                            Name = "Views"
                        },
                        new
                        {
                            Id = 3,
                            DeadLine = new DateTime(2024, 3, 26, 0, 21, 44, 447, DateTimeKind.Local).AddTicks(7706),
                            Description = "Validate User input",
                            Name = "Validations"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
