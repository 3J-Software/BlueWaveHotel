﻿// <auto-generated />
using System;
using BlueWaveHotel.Entities.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlueWaveHotel.Entities.Migrations
{
    [DbContext(typeof(mySqlContext))]
    partial class mySqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("BedTypeRoom", b =>
                {
                    b.Property<string>("bedTypesId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("roomsId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("bedTypesId", "roomsId");

                    b.HasIndex("roomsId");

                    b.ToTable("BedTypeRoom");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.BedType", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BedName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("bedTypes");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Customers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Id_Number")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Number")
                        .IsUnique();

                    b.HasIndex("Mail")
                        .IsUnique();

                    b.HasIndex("NickName")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.ToTable("customers");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Extra", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("customerIdId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("fee")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("customerIdId");

                    b.ToTable("extras");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Floor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FloorNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("floors");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Package", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.Property<decimal>("fee")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("packageName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.HasKey("Id");

                    b.HasIndex("packageName")
                        .IsUnique();

                    b.ToTable("packages");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Personel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ID_number")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("professionId")
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("salary")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("salaryTypeIdId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ID_number")
                        .IsUnique();

                    b.HasIndex("NickName")
                        .IsUnique();

                    b.HasIndex("password")
                        .IsUnique();

                    b.HasIndex("professionId");

                    b.HasIndex("salaryTypeIdId");

                    b.ToTable("personels");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ProductCategoriesId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoriesId");

                    b.HasIndex("ProductName")
                        .IsUnique();

                    b.ToTable("products");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.ProductCategory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryName")
                        .IsUnique();

                    b.ToTable("productCategories");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Profession", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("professions");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Reservation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("BookingEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("BookingStart")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("CheckIn")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("CheckOut")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Purchase")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("customersId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("packageId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("customersId");

                    b.HasIndex("packageId");

                    b.ToTable("reservations");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Room", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ReservationId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("floorId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.HasIndex("floorId");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.SalaryType", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("salaryTypes");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Shift", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Finish")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Start")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("shifts");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.TimeTracking", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("Finish")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("timeTrackings");
                });

            modelBuilder.Entity("ExtraProduct", b =>
                {
                    b.Property<string>("extrasId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("productId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("extrasId", "productId");

                    b.HasIndex("productId");

                    b.ToTable("ExtraProduct");
                });

            modelBuilder.Entity("PersonelShift", b =>
                {
                    b.Property<string>("PersonelsId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("shiftsId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("PersonelsId", "shiftsId");

                    b.HasIndex("shiftsId");

                    b.ToTable("PersonelShift");
                });

            modelBuilder.Entity("PersonelTimeTracking", b =>
                {
                    b.Property<string>("MyPropertyId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("personelsId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("MyPropertyId", "personelsId");

                    b.HasIndex("personelsId");

                    b.ToTable("PersonelTimeTracking");
                });

            modelBuilder.Entity("ProfessionShift", b =>
                {
                    b.Property<string>("ShiftId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("professionsId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("ShiftId", "professionsId");

                    b.HasIndex("professionsId");

                    b.ToTable("ProfessionShift");
                });

            modelBuilder.Entity("BedTypeRoom", b =>
                {
                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.BedType", null)
                        .WithMany()
                        .HasForeignKey("bedTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Room", null)
                        .WithMany()
                        .HasForeignKey("roomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Extra", b =>
                {
                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Customers", "customerId")
                        .WithMany()
                        .HasForeignKey("customerIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customerId");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Personel", b =>
                {
                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Profession", "profession")
                        .WithMany("personels")
                        .HasForeignKey("professionId");

                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.SalaryType", "salaryTypeId")
                        .WithMany("Personels")
                        .HasForeignKey("salaryTypeIdId");

                    b.Navigation("profession");

                    b.Navigation("salaryTypeId");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Product", b =>
                {
                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.ProductCategory", "ProductCategories")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Reservation", b =>
                {
                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Customers", "customers")
                        .WithMany()
                        .HasForeignKey("customersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Package", "package")
                        .WithMany("reservations")
                        .HasForeignKey("packageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customers");

                    b.Navigation("package");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Room", b =>
                {
                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Reservation", "Reservation")
                        .WithMany("roomsId")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Floor", "floor")
                        .WithMany("rooms")
                        .HasForeignKey("floorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("floor");
                });

            modelBuilder.Entity("ExtraProduct", b =>
                {
                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Extra", null)
                        .WithMany()
                        .HasForeignKey("extrasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Product", null)
                        .WithMany()
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonelShift", b =>
                {
                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Personel", null)
                        .WithMany()
                        .HasForeignKey("PersonelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Shift", null)
                        .WithMany()
                        .HasForeignKey("shiftsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonelTimeTracking", b =>
                {
                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.TimeTracking", null)
                        .WithMany()
                        .HasForeignKey("MyPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Personel", null)
                        .WithMany()
                        .HasForeignKey("personelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProfessionShift", b =>
                {
                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Shift", null)
                        .WithMany()
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlueWaveHotel.Entities.Model.Concrete.Profession", null)
                        .WithMany()
                        .HasForeignKey("professionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Floor", b =>
                {
                    b.Navigation("rooms");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Package", b =>
                {
                    b.Navigation("reservations");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Profession", b =>
                {
                    b.Navigation("personels");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.Reservation", b =>
                {
                    b.Navigation("roomsId");
                });

            modelBuilder.Entity("BlueWaveHotel.Entities.Model.Concrete.SalaryType", b =>
                {
                    b.Navigation("Personels");
                });
#pragma warning restore 612, 618
        }
    }
}
