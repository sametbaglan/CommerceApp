﻿// <auto-generated />
using System;
using CommerceApp.DbConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommerceApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220629070323_dbmigrations")]
    partial class dbmigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.Attribute", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("attirbuteid")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("attributes");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.AttributeValues", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Attributeid")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("categoryAttirbuteid")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Attributeid");

                    b.HasIndex("categoryAttirbuteid");

                    b.ToTable("attributeValues");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("parentId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<string>("modelcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("reducedprice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.ProductAttributeValue", b =>
                {
                    b.Property<int>("productid")
                        .HasColumnType("int");

                    b.Property<int>("attributevalueid")
                        .HasColumnType("int");

                    b.Property<int?>("AttributeValuesid")
                        .HasColumnType("int");

                    b.HasKey("productid", "attributevalueid");

                    b.HasIndex("AttributeValuesid");

                    b.ToTable("productAttributeValues");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.SubCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Categoryid")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SubCategoryid")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("parentId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Categoryid");

                    b.HasIndex("SubCategoryid");

                    b.ToTable("subCategories");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("roleidid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("roleidid");

                    b.ToTable("users");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.categoryAttirbute", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("allowCustom")
                        .HasColumnType("bit");

                    b.Property<int?>("attributeid")
                        .HasColumnType("int");

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("required")
                        .HasColumnType("bit");

                    b.Property<bool>("slicer")
                        .HasColumnType("bit");

                    b.Property<bool>("varianter")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("attributeid");

                    b.ToTable("categoryAttirbutes");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.userRole", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("userRoles");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.AttributeValues", b =>
                {
                    b.HasOne("CommerceApp.Models.Entity.Concrete.Attribute", null)
                        .WithMany("attributeValues")
                        .HasForeignKey("Attributeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommerceApp.Models.Entity.Concrete.categoryAttirbute", null)
                        .WithMany("attributeValues")
                        .HasForeignKey("categoryAttirbuteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.ProductAttributeValue", b =>
                {
                    b.HasOne("CommerceApp.Models.Entity.Concrete.AttributeValues", "AttributeValues")
                        .WithMany("productAttributeValues")
                        .HasForeignKey("AttributeValuesid");

                    b.HasOne("CommerceApp.Models.Entity.Concrete.Product", "product")
                        .WithMany("productAttributeValues")
                        .HasForeignKey("productid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AttributeValues");

                    b.Navigation("product");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.SubCategory", b =>
                {
                    b.HasOne("CommerceApp.Models.Entity.Concrete.Category", null)
                        .WithMany("subCategories")
                        .HasForeignKey("Categoryid");

                    b.HasOne("CommerceApp.Models.Entity.Concrete.SubCategory", null)
                        .WithMany("subCategories")
                        .HasForeignKey("SubCategoryid");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.User", b =>
                {
                    b.HasOne("CommerceApp.Models.Entity.Concrete.userRole", "roleid")
                        .WithMany("Users")
                        .HasForeignKey("roleidid");

                    b.Navigation("roleid");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.categoryAttirbute", b =>
                {
                    b.HasOne("CommerceApp.Models.Entity.Concrete.Attribute", "attribute")
                        .WithMany()
                        .HasForeignKey("attributeid");

                    b.Navigation("attribute");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.Attribute", b =>
                {
                    b.Navigation("attributeValues");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.AttributeValues", b =>
                {
                    b.Navigation("productAttributeValues");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.Category", b =>
                {
                    b.Navigation("subCategories");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.Product", b =>
                {
                    b.Navigation("productAttributeValues");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.SubCategory", b =>
                {
                    b.Navigation("subCategories");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.categoryAttirbute", b =>
                {
                    b.Navigation("attributeValues");
                });

            modelBuilder.Entity("CommerceApp.Models.Entity.Concrete.userRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
