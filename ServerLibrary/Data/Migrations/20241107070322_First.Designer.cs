﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerLibrary.Data;

#nullable disable

namespace ServerLibrary.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241107070322_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BaseLibrary.Entities.AccountingApproval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountingCompleteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateReceived")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FirstPayment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("FourthPayment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceivedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("SecondPayment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal?>("ThirdPayment")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AccountingCompleteId")
                        .IsUnique();

                    b.ToTable("AccountingApprovals");
                });

            modelBuilder.Entity("BaseLibrary.Entities.AccountingComplete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Cancelled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Penalty")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("AccountingComplete");
                });

            modelBuilder.Entity("BaseLibrary.Entities.Coa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("InspectionReceivedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InspectionRequest")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderCopy")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReceivedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coa");
                });

            modelBuilder.Entity("BaseLibrary.Entities.Inspection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcceptedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAccepted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateInspected")
                        .HasColumnType("datetime2");

                    b.Property<string>("Inspector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("BaseLibrary.Entities.OrderDelivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Conforme")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderReceivedId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderReceivedId")
                        .IsUnique();

                    b.ToTable("OrderDeliveries");
                });

            modelBuilder.Entity("BaseLibrary.Entities.OrderReceived", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateReceived")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ExtensionLetter")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderReceived");
                });

            modelBuilder.Entity("BaseLibrary.Entities.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountingApprovalId")
                        .HasColumnType("int");

                    b.Property<int>("CoaId")
                        .HasColumnType("int");

                    b.Property<string>("Division")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InspectionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderDeliveryId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountingApprovalId")
                        .IsUnique();

                    b.HasIndex("CoaId")
                        .IsUnique();

                    b.HasIndex("InspectionId")
                        .IsUnique();

                    b.HasIndex("OrderDeliveryId")
                        .IsUnique();

                    b.HasIndex("RequestId")
                        .IsUnique();

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("BaseLibrary.Entities.RefreshTokenInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RefreshTokenInfos");
                });

            modelBuilder.Entity("BaseLibrary.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateReceived")
                        .HasColumnType("datetime2");

                    b.Property<string>("Division")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FundSource")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<string>("Particulars")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecordNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequestNumber")
                        .HasColumnType("int");

                    b.Property<string>("Requestor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("BaseLibrary.Entities.SystemRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemRoles");
                });

            modelBuilder.Entity("BaseLibrary.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Division")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BaseLibrary.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("BaseLibrary.Entities.AccountingApproval", b =>
                {
                    b.HasOne("BaseLibrary.Entities.AccountingComplete", "AccountingComplete")
                        .WithOne("AccountingApproval")
                        .HasForeignKey("BaseLibrary.Entities.AccountingApproval", "AccountingCompleteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountingComplete");
                });

            modelBuilder.Entity("BaseLibrary.Entities.OrderDelivery", b =>
                {
                    b.HasOne("BaseLibrary.Entities.OrderReceived", "OrderReceived")
                        .WithOne("OrderDelivery")
                        .HasForeignKey("BaseLibrary.Entities.OrderDelivery", "OrderReceivedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderReceived");
                });

            modelBuilder.Entity("BaseLibrary.Entities.PurchaseOrder", b =>
                {
                    b.HasOne("BaseLibrary.Entities.AccountingApproval", "AccountingApproval")
                        .WithOne("PurchaseOrder")
                        .HasForeignKey("BaseLibrary.Entities.PurchaseOrder", "AccountingApprovalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaseLibrary.Entities.Coa", "Coa")
                        .WithOne("PurchaseOrder")
                        .HasForeignKey("BaseLibrary.Entities.PurchaseOrder", "CoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaseLibrary.Entities.Inspection", "Inspection")
                        .WithOne("PurchaseOrder")
                        .HasForeignKey("BaseLibrary.Entities.PurchaseOrder", "InspectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaseLibrary.Entities.OrderDelivery", "OrderDelivery")
                        .WithOne("PurchaseOrder")
                        .HasForeignKey("BaseLibrary.Entities.PurchaseOrder", "OrderDeliveryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaseLibrary.Entities.Request", "Request")
                        .WithOne("PurchaseOrder")
                        .HasForeignKey("BaseLibrary.Entities.PurchaseOrder", "RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountingApproval");

                    b.Navigation("Coa");

                    b.Navigation("Inspection");

                    b.Navigation("OrderDelivery");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("BaseLibrary.Entities.AccountingApproval", b =>
                {
                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("BaseLibrary.Entities.AccountingComplete", b =>
                {
                    b.Navigation("AccountingApproval");
                });

            modelBuilder.Entity("BaseLibrary.Entities.Coa", b =>
                {
                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("BaseLibrary.Entities.Inspection", b =>
                {
                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("BaseLibrary.Entities.OrderDelivery", b =>
                {
                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("BaseLibrary.Entities.OrderReceived", b =>
                {
                    b.Navigation("OrderDelivery");
                });

            modelBuilder.Entity("BaseLibrary.Entities.Request", b =>
                {
                    b.Navigation("PurchaseOrder");
                });
#pragma warning restore 612, 618
        }
    }
}
