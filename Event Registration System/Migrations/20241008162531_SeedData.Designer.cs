﻿// <auto-generated />
using System;
using Event_Registration_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Event_Registration_System.Migrations
{
    [DbContext(typeof(EventContext))]
    [Migration("20241008162531_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Event_Registration_System.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EventId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = 34,
                            Capacity = 500,
                            Date = new DateTime(2024, 6, 15, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Join us for a day of tech talks and networking.",
                            Title = "Tech Conference 2024"
                        },
                        new
                        {
                            EventId = 613,
                            Capacity = 200,
                            Date = new DateTime(2024, 7, 20, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Explore the latest art from local artists.",
                            Title = "Art Exhibition"
                        },
                        new
                        {
                            EventId = 337,
                            Capacity = 50,
                            Date = new DateTime(2024, 8, 5, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Learn to cook delicious meals with our expert chefs.",
                            Title = "Cooking Workshop"
                        },
                        new
                        {
                            EventId = 484,
                            Capacity = 150,
                            Date = new DateTime(2024, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A seminar for small business owners to learn strategies for growth.",
                            Title = "Business Seminar"
                        },
                        new
                        {
                            EventId = 534,
                            Capacity = 1000,
                            Date = new DateTime(2024, 10, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Enjoy a weekend of live music and entertainment.",
                            Title = "Music Festival"
                        },
                        new
                        {
                            EventId = 176,
                            Capacity = 75,
                            Date = new DateTime(2024, 11, 3, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A relaxing weekend retreat focusing on mindfulness and yoga.",
                            Title = "Yoga Retreat"
                        },
                        new
                        {
                            EventId = 267,
                            Capacity = 100,
                            Date = new DateTime(2024, 12, 1, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A 3-day immersive coding bootcamp for beginners.",
                            Title = "Coding Bootcamp"
                        },
                        new
                        {
                            EventId = 166,
                            Capacity = 40,
                            Date = new DateTime(2024, 10, 25, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A hands-on workshop for amateur photographers to learn new skills.",
                            Title = "Photography Workshop"
                        },
                        new
                        {
                            EventId = 460,
                            Capacity = 300,
                            Date = new DateTime(2024, 12, 20, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A formal evening event to raise funds for local charities.",
                            Title = "Charity Gala"
                        },
                        new
                        {
                            EventId = 29,
                            Capacity = 200,
                            Date = new DateTime(2024, 11, 15, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A fair featuring local authors and book signings.",
                            Title = "Book Fair"
                        });
                });

            modelBuilder.Entity("Event_Registration_System.Models.Registration", b =>
                {
                    b.Property<int>("RegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegistrationId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("ParticipantName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RegistrationId");

                    b.HasIndex("EventId");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("Event_Registration_System.Models.Registration", b =>
                {
                    b.HasOne("Event_Registration_System.Models.Event", "Event")
                        .WithMany("Registrations")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Event_Registration_System.Models.Event", b =>
                {
                    b.Navigation("Registrations");
                });
#pragma warning restore 612, 618
        }
    }
}
