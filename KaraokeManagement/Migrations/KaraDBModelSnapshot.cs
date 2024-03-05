﻿// <auto-generated />
using System;
using KaraokeManagement.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KaraokeManagement.Migrations
{
    [DbContext(typeof(KaraDB))]
    partial class KaraDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("KaraokeManagement.Model.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("TEXT");

                    b.HasKey("BookingID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("KaraokeManagement.Model.BookingDetail", b =>
                {
                    b.Property<int>("BookingDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookingID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoomID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BookingDetailID");

                    b.HasIndex("BookingID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("RoomID");

                    b.ToTable("BookingDetail");
                });

            modelBuilder.Entity("KaraokeManagement.Model.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("KaraokeManagement.Model.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("KaraokeManagement.Model.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOccupied")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RoomID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("KaraokeManagement.Model.RoomService", b =>
                {
                    b.Property<int>("RoomServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookingDetailID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServiceID")
                        .HasColumnType("INTEGER");

                    b.HasKey("RoomServiceID");

                    b.HasIndex("BookingDetailID");

                    b.HasIndex("ServiceID");

                    b.ToTable("RoomService");
                });

            modelBuilder.Entity("KaraokeManagement.Model.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ServiceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("KaraokeManagement.Model.Booking", b =>
                {
                    b.HasOne("KaraokeManagement.Model.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("KaraokeManagement.Model.BookingDetail", b =>
                {
                    b.HasOne("KaraokeManagement.Model.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KaraokeManagement.Model.Employee", "Employee")
                        .WithMany("BookingDetails")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KaraokeManagement.Model.Room", "Room")
                        .WithMany("BookingDetails")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Employee");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("KaraokeManagement.Model.RoomService", b =>
                {
                    b.HasOne("KaraokeManagement.Model.BookingDetail", "BookingDetail")
                        .WithMany("RoomServices")
                        .HasForeignKey("BookingDetailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KaraokeManagement.Model.Service", "Service")
                        .WithMany("RoomServices")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingDetail");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("KaraokeManagement.Model.BookingDetail", b =>
                {
                    b.Navigation("RoomServices");
                });

            modelBuilder.Entity("KaraokeManagement.Model.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("KaraokeManagement.Model.Employee", b =>
                {
                    b.Navigation("BookingDetails");
                });

            modelBuilder.Entity("KaraokeManagement.Model.Room", b =>
                {
                    b.Navigation("BookingDetails");
                });

            modelBuilder.Entity("KaraokeManagement.Model.Service", b =>
                {
                    b.Navigation("RoomServices");
                });
#pragma warning restore 612, 618
        }
    }
}