﻿// <auto-generated />
using GraphQLStrawberryShakeSubs.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphQLStrawberryShakeSubs.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240428100251_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("GraphQLStrawberryShakeSubs.Server.Data.ShippingContainer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ShippingContainers");
                });

            modelBuilder.Entity("GraphQLStrawberryShakeSubs.Server.Data.ShippingContainer", b =>
                {
                    b.OwnsOne("GraphQLStrawberryShakeSubs.Server.Data.ShippingContainer+AvailableSpace", "Space", b1 =>
                        {
                            b1.Property<string>("ShippingContainerId")
                                .HasColumnType("TEXT");

                            b1.Property<double>("Height")
                                .HasColumnType("REAL");

                            b1.Property<double>("Length")
                                .HasColumnType("REAL");

                            b1.Property<double>("Width")
                                .HasColumnType("REAL");

                            b1.HasKey("ShippingContainerId");

                            b1.ToTable("ShippingContainers");

                            b1.WithOwner()
                                .HasForeignKey("ShippingContainerId");
                        });

                    b.Navigation("Space");
                });
#pragma warning restore 612, 618
        }
    }
}
