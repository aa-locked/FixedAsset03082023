﻿// <auto-generated />
using System;
using FixedAsset.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FixedAsset.DataAccess.Migrations
{
    [DbContext(typeof(FixedAssetDBContext))]
    partial class FixedAssetDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FixedAsset.Model.Domain.MaterialGroup.TFAMtrlGrp", b =>
                {
                    b.Property<int>("FAMtrlGrpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FAMtrlGrpId"), 1L, 1);

                    b.Property<bool>("ActStatus")
                        .HasColumnType("bit");

                    b.Property<int>("AddedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("GrpDesc")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("GrpShortDesc")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("FAMtrlGrpId");

                    b.ToTable("tFAMtrlGrp");
                });

            modelBuilder.Entity("FixedAsset.Model.Domain.MaterialGroup.TFAMtrlSubGrp", b =>
                {
                    b.Property<int>("FAMtrlSubGrpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FAMtrlSubGrpId"), 1L, 1);

                    b.Property<bool>("ActStatus")
                        .HasColumnType("bit");

                    b.Property<int>("AddedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("FAMtrlGrpId")
                        .HasColumnType("int");

                    b.Property<string>("SubGrpDesc")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SubGrpShortDesc")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("FAMtrlSubGrpId");

                    b.HasIndex("FAMtrlGrpId");

                    b.ToTable("tFAMtrlSubGrp");
                });

            modelBuilder.Entity("FixedAsset.Model.Domain.MaterialGroup.TFAMtrlSubGrp", b =>
                {
                    b.HasOne("FixedAsset.Model.Domain.MaterialGroup.TFAMtrlGrp", "TFAMtrlGrp")
                        .WithMany()
                        .HasForeignKey("FAMtrlGrpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TFAMtrlGrp");
                });
#pragma warning restore 612, 618
        }
    }
}