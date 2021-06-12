﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoliklinikaApp.Data;

namespace PoliklinikaApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PoliklinikaApp.Models.Doktor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("kodZaRecepte")
                        .HasColumnType("int");

                    b.Property<string>("odjel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("sifra")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Doktor");
                });

            modelBuilder.Entity("PoliklinikaApp.Models.MedicinskiKarton", b =>
                {
                    b.Property<int>("brMedKartona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("anamneza")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("datum")
                        .HasColumnType("datetime");

                    b.Property<string>("dijagnoza")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("medUsluga")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("redniBrojPregleda")
                        .HasColumnType("int");

                    b.HasKey("brMedKartona");

                    b.ToTable("MedicinskiKarton");
                });

            modelBuilder.Entity("PoliklinikaApp.Models.Nalaz", b =>
                {
                    b.Property<int>("id_nalaza")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("kartonbrMedKartona")
                        .HasColumnType("int");

                    b.Property<string>("misljenje")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("statusPacijenta")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_nalaza");

                    b.HasIndex("kartonbrMedKartona");

                    b.ToTable("Nalaz");
                });

            modelBuilder.Entity("PoliklinikaApp.Models.Pacijent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ime")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("jmbg")
                        .HasColumnType("int");

                    b.Property<int>("kartonbrMedKartona")
                        .HasColumnType("int");

                    b.Property<string>("prezime")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("sifra")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("kartonbrMedKartona");

                    b.ToTable("Pacijent");
                });

            modelBuilder.Entity("PoliklinikaApp.Models.Pregled", b =>
                {
                    b.Property<int>("id_pregleda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("datum")
                        .HasColumnType("datetime");

                    b.Property<int>("doktorID")
                        .HasColumnType("int");

                    b.Property<int>("pacijentID")
                        .HasColumnType("int");

                    b.HasKey("id_pregleda");

                    b.HasIndex("doktorID");

                    b.HasIndex("pacijentID");

                    b.ToTable("Pregled");
                });

            modelBuilder.Entity("PoliklinikaApp.Models.RasporedPregleda", b =>
                {
                    b.Property<DateTime>("vrijeme")
                        .HasColumnType("datetime");

                    b.ToTable("RasporedPregleda");
                });

            modelBuilder.Entity("PoliklinikaApp.Models.RasporedZaZakazivanje", b =>
                {
                    b.Property<DateTime>("vrijeme")
                        .HasColumnType("datetime");

                    b.ToTable("RasporedZaZakazivanje");
                });

            modelBuilder.Entity("PoliklinikaApp.Models.Recept", b =>
                {
                    b.Property<int>("kodZaRecept")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("farmaceut")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("medUstanova")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("recept")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("sifraLijeka")
                        .HasColumnType("int");

                    b.HasKey("kodZaRecept");

                    b.ToTable("Recept");
                });

            modelBuilder.Entity("PoliklinikaApp.Models.Nalaz", b =>
                {
                    b.HasOne("PoliklinikaApp.Models.MedicinskiKarton", "karton")
                        .WithMany()
                        .HasForeignKey("kartonbrMedKartona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PoliklinikaApp.Models.Pacijent", b =>
                {
                    b.HasOne("PoliklinikaApp.Models.MedicinskiKarton", "karton")
                        .WithMany()
                        .HasForeignKey("kartonbrMedKartona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PoliklinikaApp.Models.Pregled", b =>
                {
                    b.HasOne("PoliklinikaApp.Models.Doktor", "doktor")
                        .WithMany()
                        .HasForeignKey("doktorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PoliklinikaApp.Models.Pacijent", "pacijent")
                        .WithMany()
                        .HasForeignKey("pacijentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
