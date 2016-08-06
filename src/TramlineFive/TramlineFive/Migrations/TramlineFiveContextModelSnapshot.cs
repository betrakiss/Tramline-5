﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TramlineFive.DataAccess;

namespace TramlineFive.Migrations
{
    [DbContext(typeof(TramlineFiveContext))]
    partial class TramlineFiveContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("TramlineFive.DataAccess.Entities.Day", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DirectionID");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.HasIndex("DirectionID");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("TramlineFive.DataAccess.Entities.Direction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LineID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("LineID");

                    b.ToTable("Directions");
                });

            modelBuilder.Entity("TramlineFive.DataAccess.Entities.Favourite", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("Favourites");
                });

            modelBuilder.Entity("TramlineFive.DataAccess.Entities.Line", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Lines");
                });

            modelBuilder.Entity("TramlineFive.DataAccess.Entities.Stop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DayID");

                    b.Property<int?>("FavouriteID");

                    b.Property<string>("Name");

                    b.Property<string>("TimingsAsString");

                    b.HasKey("ID");

                    b.HasIndex("DayID");

                    b.HasIndex("FavouriteID")
                        .IsUnique();

                    b.ToTable("Stops");
                });

            modelBuilder.Entity("TramlineFive.DataAccess.Entities.Day", b =>
                {
                    b.HasOne("TramlineFive.DataAccess.Entities.Direction")
                        .WithMany("Days")
                        .HasForeignKey("DirectionID");
                });

            modelBuilder.Entity("TramlineFive.DataAccess.Entities.Direction", b =>
                {
                    b.HasOne("TramlineFive.DataAccess.Entities.Line")
                        .WithMany("Directions")
                        .HasForeignKey("LineID");
                });

            modelBuilder.Entity("TramlineFive.DataAccess.Entities.Stop", b =>
                {
                    b.HasOne("TramlineFive.DataAccess.Entities.Day")
                        .WithMany("Stops")
                        .HasForeignKey("DayID");

                    b.HasOne("TramlineFive.DataAccess.Entities.Favourite", "Favourite")
                        .WithOne("Stop")
                        .HasForeignKey("TramlineFive.DataAccess.Entities.Stop", "FavouriteID");
                });
        }
    }
}
