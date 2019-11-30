﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkiLand.DAL.DdContext;

namespace SkiLand.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191117164902_modify_hotel_booking")]
    partial class modify_hotel_booking
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SkiLand.Domain.Entities.Equipment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("EquipmentRentalId");

                    b.Property<long?>("EquipmentStateId");

                    b.Property<long?>("EquipmentTypeId");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentRentalId");

                    b.HasIndex("EquipmentStateId");

                    b.HasIndex("EquipmentTypeId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.EquipmentBooking", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<long?>("EquipmentId");

                    b.Property<bool>("IsConfirmed");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.ToTable("EquipmentBookings");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.EquipmentRental", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("EquipmentRentals");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.EquipmentState", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("EquipmentStates");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.EquipmentType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("EquipmentTypes");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.ExcurisionBooking", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<long?>("ExcursionServiceId");

                    b.Property<bool>("IsConfirmed");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ExcursionServiceId");

                    b.ToTable("ExcurisionBookings");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.ExcursionAgency", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactInformation");

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ExcursionAgencies");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.ExcursionAgencyService", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ExcursionAgencyId");

                    b.Property<long?>("ExcursionServiceId");

                    b.HasKey("Id");

                    b.HasIndex("ExcursionAgencyId");

                    b.HasIndex("ExcursionServiceId");

                    b.ToTable("ExcursionAgencyServices");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.ExcursionService", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("ExcursionServices");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.Hotel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<long?>("PhotoId");

                    b.Property<float>("Raiting");

                    b.Property<byte>("Stars");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.HotelBooking", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adults");

                    b.Property<int>("Children");

                    b.Property<DateTime>("EndDate");

                    b.Property<long?>("HotelRoomId");

                    b.Property<bool>("IsConfirmed");

                    b.Property<DateTime>("StartDate");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("HotelRoomId");

                    b.ToTable("HotelBookings");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.HotelBookingPayment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("BookingId");

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("Disscount");

                    b.Property<bool>("IsPercentDisscount");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.ToTable("HotelBookingPayments");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.HotelRoom", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adults");

                    b.Property<int>("Children");

                    b.Property<string>("Description");

                    b.Property<long?>("HotelId");

                    b.Property<long?>("RoomTypeId");

                    b.Property<int>("RoomsCount");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.HotelRoomAmenity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("HotelRoomId");

                    b.Property<long?>("RoomAmenityId");

                    b.HasKey("Id");

                    b.HasIndex("HotelRoomId");

                    b.HasIndex("RoomAmenityId");

                    b.ToTable("HotelRoomAmenities");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.HotelRoomPhoto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("PhotoId");

                    b.Property<long?>("RoomId");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.HasIndex("RoomId");

                    b.ToTable("HotelRoomPhotos");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.Photo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path");

                    b.HasKey("Id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.RelaxComplex", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactInformation");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<float>("Raiting");

                    b.HasKey("Id");

                    b.ToTable("RelaxComplexes");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.RelaxServiceBooking", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAndTime");

                    b.Property<bool>("IsConfirmed");

                    b.Property<long?>("RelaxServiseId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RelaxServiseId");

                    b.ToTable("RelaxServiceBookings");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.RelaxServiceRelaxComplex", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("RelaxComplexId");

                    b.Property<long?>("RelaxServiseId");

                    b.HasKey("Id");

                    b.HasIndex("RelaxComplexId");

                    b.HasIndex("RelaxServiseId");

                    b.ToTable("RelaxServiceRelaxComplexes");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.RelaxServise", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contraindication");

                    b.Property<string>("Description");

                    b.Property<string>("Duration");

                    b.Property<string>("Name");

                    b.Property<string>("NeededEquipment");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("RelaxServises");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.Restaurant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactInformation");

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<long?>("PhotoId");

                    b.Property<float>("Raiting");

                    b.Property<DateTime>("TimeClose");

                    b.Property<DateTime>("TimeOpen");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.RestaurantBooking", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<DateTime>("DateAndTime");

                    b.Property<bool>("IsConfirmed");

                    b.Property<int>("PeopleCount");

                    b.Property<long?>("RestaurantId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("RestaurantBookings");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.RoomAmenity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.RoomType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.SeasonRoomPricing", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<long?>("HotelRoomId");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("HotelRoomId");

                    b.ToTable("SeasonRoomPricings");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.Equipment", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.EquipmentRental", "EquipmentRental")
                        .WithMany()
                        .HasForeignKey("EquipmentRentalId");

                    b.HasOne("SkiLand.Domain.Entities.EquipmentState", "EquipmentState")
                        .WithMany()
                        .HasForeignKey("EquipmentStateId");

                    b.HasOne("SkiLand.Domain.Entities.EquipmentType", "EquipmentType")
                        .WithMany()
                        .HasForeignKey("EquipmentTypeId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.EquipmentBooking", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.ExcurisionBooking", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.ExcursionService", "ExcursionService")
                        .WithMany()
                        .HasForeignKey("ExcursionServiceId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.ExcursionAgencyService", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.ExcursionAgency", "ExcursionAgency")
                        .WithMany()
                        .HasForeignKey("ExcursionAgencyId");

                    b.HasOne("SkiLand.Domain.Entities.ExcursionService", "ExcursionService")
                        .WithMany()
                        .HasForeignKey("ExcursionServiceId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.Hotel", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.HotelBooking", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.HotelRoom", "HotelRoom")
                        .WithMany("Bookings")
                        .HasForeignKey("HotelRoomId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.HotelBookingPayment", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.HotelBooking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.HotelRoom", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId");

                    b.HasOne("SkiLand.Domain.Entities.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.HotelRoomAmenity", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.HotelRoom", "HotelRoom")
                        .WithMany("Amenities")
                        .HasForeignKey("HotelRoomId");

                    b.HasOne("SkiLand.Domain.Entities.RoomAmenity", "RoomAmenity")
                        .WithMany()
                        .HasForeignKey("RoomAmenityId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.HotelRoomPhoto", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");

                    b.HasOne("SkiLand.Domain.Entities.HotelRoom", "Room")
                        .WithMany("Photos")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.RelaxServiceBooking", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.RelaxServise", "RelaxServise")
                        .WithMany()
                        .HasForeignKey("RelaxServiseId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.RelaxServiceRelaxComplex", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.RelaxComplex", "RelaxComplex")
                        .WithMany()
                        .HasForeignKey("RelaxComplexId");

                    b.HasOne("SkiLand.Domain.Entities.RelaxServise", "RelaxServise")
                        .WithMany()
                        .HasForeignKey("RelaxServiseId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.Restaurant", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.RestaurantBooking", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId");
                });

            modelBuilder.Entity("SkiLand.Domain.Entities.SeasonRoomPricing", b =>
                {
                    b.HasOne("SkiLand.Domain.Entities.HotelRoom", "HotelRoom")
                        .WithMany("Pricings")
                        .HasForeignKey("HotelRoomId");
                });
#pragma warning restore 612, 618
        }
    }
}