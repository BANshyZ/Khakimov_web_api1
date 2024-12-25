﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SHURALE.Models;

#nullable disable

namespace SHURALE.Migrations
{
    [DbContext(typeof(CompHelperContext))]
    partial class CompHelperContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CaseToMotherboardCompat", b =>
                {
                    b.Property<int>("CaseId")
                        .HasColumnType("int")
                        .HasColumnName("CaseID");

                    b.Property<int>("MotherboardId")
                        .HasColumnType("int")
                        .HasColumnName("MotherboardID");

                    b.HasKey("CaseId", "MotherboardId")
                        .HasName("PK__CaseToMo__1C21B0424FA7FE62");

                    b.HasIndex("MotherboardId");

                    b.ToTable("CaseToMotherboardCompat", (string)null);
                });

            modelBuilder.Entity("CoolerMotherboardCompat", b =>
                {
                    b.Property<int>("CoolerId")
                        .HasColumnType("int")
                        .HasColumnName("CoolerID");

                    b.Property<int>("MotherboardId")
                        .HasColumnType("int")
                        .HasColumnName("MotherboardID");

                    b.HasKey("CoolerId", "MotherboardId")
                        .HasName("PK__CoolerMo__9548F946ABFBA31E");

                    b.HasIndex("MotherboardId");

                    b.ToTable("CoolerMotherboardCompat", (string)null);
                });

            modelBuilder.Entity("CputoMotherboardCompat", b =>
                {
                    b.Property<int>("Cpuid")
                        .HasColumnType("int")
                        .HasColumnName("CPUID");

                    b.Property<int>("MotherboardId")
                        .HasColumnType("int")
                        .HasColumnName("MotherboardID");

                    b.HasKey("Cpuid", "MotherboardId")
                        .HasName("PK__CPUToMot__0D14855CA4C12689");

                    b.HasIndex("MotherboardId");

                    b.ToTable("CPUToMotherboardCompat", (string)null);
                });

            modelBuilder.Entity("GputoMotherboardCompat", b =>
                {
                    b.Property<int>("Gpuid")
                        .HasColumnType("int")
                        .HasColumnName("GPUID");

                    b.Property<int>("MotherboardId")
                        .HasColumnType("int")
                        .HasColumnName("MotherboardID");

                    b.HasKey("Gpuid", "MotherboardId")
                        .HasName("PK__GPUToMot__FACE4B2785D4F973");

                    b.HasIndex("MotherboardId");

                    b.ToTable("GPUToMotherboardCompat", (string)null);
                });

            modelBuilder.Entity("MotherboardRamcompat", b =>
                {
                    b.Property<int>("MotherboardId")
                        .HasColumnType("int")
                        .HasColumnName("MotherboardID");

                    b.Property<int>("Ramid")
                        .HasColumnType("int")
                        .HasColumnName("RAMID");

                    b.HasKey("MotherboardId", "Ramid")
                        .HasName("PK__Motherbo__283502B4E493F204");

                    b.HasIndex("Ramid");

                    b.ToTable("MotherboardRAMCompat", (string)null);
                });

            modelBuilder.Entity("PowerSupplyCaseCompat", b =>
                {
                    b.Property<int>("PowerSupplyId")
                        .HasColumnType("int")
                        .HasColumnName("PowerSupplyID");

                    b.Property<int>("CaseId")
                        .HasColumnType("int")
                        .HasColumnName("CaseID");

                    b.HasKey("PowerSupplyId", "CaseId")
                        .HasName("PK__PowerSup__D849AB4E255FDE62");

                    b.HasIndex("CaseId");

                    b.ToTable("PowerSupplyCaseCompat", (string)null);
                });

            modelBuilder.Entity("SHURALE.Models.Case", b =>
                {
                    b.Property<int>("CaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CaseID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaseId"));

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MotherBoardFormFactor")
                        .HasMaxLength(86)
                        .HasColumnType("nvarchar(86)");

                    b.Property<string>("PowerSupplyFormFactor")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.HasKey("CaseId")
                        .HasName("PK__Cases__6CAE526CF988E6CD");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("SHURALE.Models.Cooler", b =>
                {
                    b.Property<int>("CoolerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CoolerID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoolerId"));

                    b.Property<string>("ConstructionType")
                        .HasMaxLength(33)
                        .HasColumnType("nvarchar(33)");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SocketSupport")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("CoolerId")
                        .HasName("PK__Coolers__E5C71B68AD626730");

                    b.ToTable("Coolers");
                });

            modelBuilder.Entity("SHURALE.Models.Cpu", b =>
                {
                    b.Property<int>("Cpuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CPUID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cpuid"));

                    b.Property<int?>("Cores")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Socket")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Threads")
                        .HasColumnType("int");

                    b.HasKey("Cpuid")
                        .HasName("PK__CPUs__7D9B6772B23C65AB");

                    b.ToTable("CPUs", (string)null);
                });

            modelBuilder.Entity("SHURALE.Models.Gpu", b =>
                {
                    b.Property<int>("Gpuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GPUID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Gpuid"));

                    b.Property<string>("ConnectionInterface")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("VideoMemoryCapacity")
                        .HasColumnType("int");

                    b.Property<string>("VideoMemoryType")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Gpuid")
                        .HasName("PK__GPUs__8A41A909D70BE25B");

                    b.ToTable("GPUs", (string)null);
                });

            modelBuilder.Entity("SHURALE.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Guest__3213E83F9AA856FD");

                    b.ToTable("Guest", (string)null);
                });

            modelBuilder.Entity("SHURALE.Models.Motherboard", b =>
                {
                    b.Property<int>("MotherboardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MotherboardID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MotherboardId"));

                    b.Property<string>("ConnectionInterface")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("MemoryInterface")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MotherboardFornFactor")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Ramtype")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)")
                        .HasColumnName("RAMType");

                    b.Property<string>("Socket")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MotherboardId")
                        .HasName("PK__Motherbo__08FE22E6F55DC9F6");

                    b.ToTable("Motherboards");
                });

            modelBuilder.Entity("SHURALE.Models.PowerSupply", b =>
                {
                    b.Property<int>("PowerSupplyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PowerSupplyID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PowerSupplyId"));

                    b.Property<string>("FormFactor")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PowerRating")
                        .HasColumnType("int");

                    b.HasKey("PowerSupplyId")
                        .HasName("PK__PowerSup__0E834E68148F63CB");

                    b.ToTable("PowerSupply", (string)null);
                });

            modelBuilder.Entity("SHURALE.Models.Ram", b =>
                {
                    b.Property<int>("Ramid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RAMID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ramid"));

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("MemoryType")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Ramid")
                        .HasName("PK__RAMs__0CB205236B2D4B17");

                    b.ToTable("RAMs", (string)null);
                });

            modelBuilder.Entity("SHURALE.Models.Storage", b =>
                {
                    b.Property<int>("StorageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StorageID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StorageId"));

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("MemoryInterface")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("MemoryType")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StorageId")
                        .HasName("PK__Storage__8A247E3739B85EB5");

                    b.ToTable("Storage", (string)null);
                });

            modelBuilder.Entity("StorageToMotherboardCompat", b =>
                {
                    b.Property<int>("MotherboardId")
                        .HasColumnType("int")
                        .HasColumnName("MotherboardID");

                    b.Property<int>("StorageId")
                        .HasColumnType("int")
                        .HasColumnName("StorageID");

                    b.HasKey("MotherboardId", "StorageId");

                    b.HasIndex("StorageId");

                    b.ToTable("StorageToMotherboardCompat", (string)null);
                });

            modelBuilder.Entity("CaseToMotherboardCompat", b =>
                {
                    b.HasOne("SHURALE.Models.Case", null)
                        .WithMany()
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__CaseToMot__CaseI__5535A963");

                    b.HasOne("SHURALE.Models.Motherboard", null)
                        .WithMany()
                        .HasForeignKey("MotherboardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__CaseToMot__Mothe__5629CD9C");
                });

            modelBuilder.Entity("CoolerMotherboardCompat", b =>
                {
                    b.HasOne("SHURALE.Models.Cooler", null)
                        .WithMany()
                        .HasForeignKey("CoolerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__CoolerMot__Coole__5165187F");

                    b.HasOne("SHURALE.Models.Motherboard", null)
                        .WithMany()
                        .HasForeignKey("MotherboardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__CoolerMot__Mothe__52593CB8");
                });

            modelBuilder.Entity("CputoMotherboardCompat", b =>
                {
                    b.HasOne("SHURALE.Models.Cpu", null)
                        .WithMany()
                        .HasForeignKey("Cpuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__CPUToMoth__CPUID__5CD6CB2B");

                    b.HasOne("SHURALE.Models.Motherboard", null)
                        .WithMany()
                        .HasForeignKey("MotherboardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__CPUToMoth__Mothe__5DCAEF64");
                });

            modelBuilder.Entity("GputoMotherboardCompat", b =>
                {
                    b.HasOne("SHURALE.Models.Gpu", null)
                        .WithMany()
                        .HasForeignKey("Gpuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__GPUToMoth__GPUID__60A75C0F");

                    b.HasOne("SHURALE.Models.Motherboard", null)
                        .WithMany()
                        .HasForeignKey("MotherboardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__GPUToMoth__Mothe__619B8048");
                });

            modelBuilder.Entity("MotherboardRamcompat", b =>
                {
                    b.HasOne("SHURALE.Models.Motherboard", null)
                        .WithMany()
                        .HasForeignKey("MotherboardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MotherboardRAMCompat_Motherboards");

                    b.HasOne("SHURALE.Models.Ram", null)
                        .WithMany()
                        .HasForeignKey("Ramid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Motherboa__RAMID__59FA5E80");
                });

            modelBuilder.Entity("PowerSupplyCaseCompat", b =>
                {
                    b.HasOne("SHURALE.Models.Case", null)
                        .WithMany()
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__PowerSupp__CaseI__656C112C");

                    b.HasOne("SHURALE.Models.PowerSupply", null)
                        .WithMany()
                        .HasForeignKey("PowerSupplyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__PowerSupp__Power__6477ECF3");
                });

            modelBuilder.Entity("StorageToMotherboardCompat", b =>
                {
                    b.HasOne("SHURALE.Models.Motherboard", null)
                        .WithMany()
                        .HasForeignKey("MotherboardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_StorageToMotherboardCompat_Motherboards");

                    b.HasOne("SHURALE.Models.Storage", null)
                        .WithMany()
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_StorageToMotherboardCompat_Storage");
                });
#pragma warning restore 612, 618
        }
    }
}
