﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLiteEF_LowPower.Data;

#nullable disable

namespace SQLiteEF_LowPower.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240723193745_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("SQLiteEF_LowPower.Models.ChooseComponentsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommunicationModules")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PowerManagementComponents")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sensors")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Stm32Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ChooseComponent");
                });
#pragma warning restore 612, 618
        }
    }
}
