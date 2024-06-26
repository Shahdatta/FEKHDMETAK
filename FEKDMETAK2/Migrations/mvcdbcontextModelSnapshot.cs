﻿// <auto-generated />
using System;
using FEKDMETAK.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FEKDMETAK2.Migrations
{
    [DbContext(typeof(mvcdbcontext))]
    partial class mvcdbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FEKDMETAK.Models.Notification", b =>
                {
                    b.Property<int>("NOId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NOId"), 1L, 1);

                    b.Property<int>("AmPm")
                        .HasColumnType("int");

                    b.Property<int>("Clock")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRejected")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecieverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<int?>("UserUid")
                        .HasColumnType("int");

                    b.HasKey("NOId");

                    b.HasIndex("RecieverId");

                    b.HasIndex("SenderId");

                    b.HasIndex("UserUid");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("FEKDMETAK.Models.Review", b =>
                {
                    b.Property<int>("RId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RId"), 1L, 1);

                    b.Property<bool>("Complaint")
                        .HasColumnType("bit");

                    b.Property<decimal>("RateofUser")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ReviewedUserId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalRate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RId");

                    b.HasIndex("ReviewedUserId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("FEKDMETAK.Models.Specialization", b =>
                {
                    b.Property<int>("Sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sid"), 1L, 1);

                    b.Property<string>("SName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserUid")
                        .HasColumnType("int");

                    b.HasKey("Sid");

                    b.HasIndex("UserUid");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("FEKDMETAK.Models.User", b =>
                {
                    b.Property<int>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Uid"), 1L, 1);

                    b.Property<string>("Adderess")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("specializationId")
                        .HasColumnType("int");

                    b.HasKey("Uid");

                    b.HasIndex("TownId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FEKDMETAK2.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("FEKDMETAK2.Models.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("FEKDMETAK.Models.Notification", b =>
                {
                    b.HasOne("FEKDMETAK.Models.User", "Reciever")
                        .WithMany("recievedNotifiaction")
                        .HasForeignKey("RecieverId")
                        .IsRequired();

                    b.HasOne("FEKDMETAK.Models.User", "Sender")
                        .WithMany("sentNotifications")
                        .HasForeignKey("SenderId")
                        .IsRequired();

                    b.HasOne("FEKDMETAK.Models.User", null)
                        .WithMany("Notifications")
                        .HasForeignKey("UserUid");

                    b.Navigation("Reciever");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("FEKDMETAK.Models.Review", b =>
                {
                    b.HasOne("FEKDMETAK.Models.User", "ReviewedUser")
                        .WithMany("RecievedReview")
                        .HasForeignKey("ReviewedUserId")
                        .IsRequired();

                    b.HasOne("FEKDMETAK.Models.User", "Reviewer")
                        .WithMany("GivenReview")
                        .HasForeignKey("ReviewerId")
                        .IsRequired();

                    b.Navigation("ReviewedUser");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("FEKDMETAK.Models.Specialization", b =>
                {
                    b.HasOne("FEKDMETAK.Models.User", null)
                        .WithMany("UserSpecliaztion")
                        .HasForeignKey("UserUid");
                });

            modelBuilder.Entity("FEKDMETAK.Models.User", b =>
                {
                    b.HasOne("FEKDMETAK2.Models.Town", "Town")
                        .WithMany()
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Town");
                });

            modelBuilder.Entity("FEKDMETAK2.Models.Town", b =>
                {
                    b.HasOne("FEKDMETAK2.Models.City", "City")
                        .WithMany("Towns")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("FEKDMETAK.Models.User", b =>
                {
                    b.Navigation("GivenReview");

                    b.Navigation("Notifications");

                    b.Navigation("RecievedReview");

                    b.Navigation("UserSpecliaztion");

                    b.Navigation("recievedNotifiaction");

                    b.Navigation("sentNotifications");
                });

            modelBuilder.Entity("FEKDMETAK2.Models.City", b =>
                {
                    b.Navigation("Towns");
                });
#pragma warning restore 612, 618
        }
    }
}
