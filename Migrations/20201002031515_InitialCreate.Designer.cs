﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea4.Data;

namespace Tarea4.Migrations
{
    [DbContext(typeof(PersonContext))]
    [Migration("20201002031515_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Tarea4.Data.Accidents", b =>
                {
                    b.Property<int>("AccidentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("BLOB");

                    b.Property<string>("Place")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.Property<string>("latitude")
                        .HasColumnType("TEXT");

                    b.Property<string>("longitud")
                        .HasColumnType("TEXT");

                    b.HasKey("AccidentsId");

                    b.ToTable("Accidents");
                });

            modelBuilder.Entity("Tarea4.Data.Persons", b =>
                {
                    b.Property<int>("PersonsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccidentsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonsId");

                    b.HasIndex("AccidentsId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Tarea4.Data.Persons", b =>
                {
                    b.HasOne("Tarea4.Data.Accidents", "Accidents")
                        .WithMany("Person")
                        .HasForeignKey("AccidentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
