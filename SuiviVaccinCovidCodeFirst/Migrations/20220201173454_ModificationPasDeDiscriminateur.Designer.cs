﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuiviVaccinCovidCodeFirst.Modeles;

namespace SuiviVaccinCovidCodeFirst.Migrations
{
    [DbContext(typeof(VaccinContext))]
    [Migration("20220201173454_ModificationPasDeDiscriminateur")]
    partial class ModificationPasDeDiscriminateur
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuiviVaccinCovidCodeFirst.Modeles.Immunisation", b =>
                {
                    b.Property<int>("ImmunisationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAMPatient")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImmunisationID");

                    b.ToTable("Immunisations");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Immunisation");
                });

            modelBuilder.Entity("SuiviVaccinCovidCodeFirst.Modeles.TypeVaccin", b =>
                {
                    b.Property<int>("TypeVaccinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeVaccinId");

                    b.ToTable("TypesVaccin");
                });

            modelBuilder.Entity("SuiviVaccinCovidCodeFirst.Modeles.Covid19", b =>
                {
                    b.HasBaseType("SuiviVaccinCovidCodeFirst.Modeles.Immunisation");

                    b.Property<string>("Variant")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Covid19");
                });

            modelBuilder.Entity("SuiviVaccinCovidCodeFirst.Modeles.Vaccin", b =>
                {
                    b.HasBaseType("SuiviVaccinCovidCodeFirst.Modeles.Immunisation");

                    b.Property<int?>("TypeVaccinId")
                        .HasColumnType("int");

                    b.HasIndex("TypeVaccinId");

                    b.HasDiscriminator().HasValue("Vaccin");
                });

            modelBuilder.Entity("SuiviVaccinCovidCodeFirst.Modeles.Vaccin", b =>
                {
                    b.HasOne("SuiviVaccinCovidCodeFirst.Modeles.TypeVaccin", "Type")
                        .WithMany()
                        .HasForeignKey("TypeVaccinId");
                });
#pragma warning restore 612, 618
        }
    }
}
