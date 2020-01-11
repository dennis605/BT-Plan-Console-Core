﻿// <auto-generated />
using System;
using ConsoleApp_core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BT_Plan_Console_Core.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200111181231_test123")]
    partial class test123
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp_core.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventBeschreibung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventEnd")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventOrt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventVorlauf")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ConsoleApp_core.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nachname")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Rolle")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Vorname")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PersonId");

                    b.HasIndex("Vorname", "Nachname", "Rolle");

                    b.ToTable("Personen");
                });

            modelBuilder.Entity("ConsoleApp_core.PersonenEvent", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.HasKey("PersonId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("PersonenEvent");
                });

            modelBuilder.Entity("ConsoleApp_core.PersonenEvent", b =>
                {
                    b.HasOne("ConsoleApp_core.Event", "Event")
                        .WithMany("PersonenEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp_core.Person", "Person")
                        .WithMany("PersonenEvents")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
