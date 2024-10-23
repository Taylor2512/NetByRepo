﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetByForms.Infrastructure.DataAcces;

#nullable disable

namespace NetByForms.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NetByForms.Domain.Entities.Form", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Forms", (string)null);
                });

            modelBuilder.Entity("NetByForms.Domain.Entities.FormInput", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FormId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InputType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.ToTable("FormInputs", (string)null);
                });

            modelBuilder.Entity("NetByForms.Domain.Entities.FormInputOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayText")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("FormInputId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OptionValue")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("FormInputId");

                    b.ToTable("FormInputOptions", (string)null);
                });

            modelBuilder.Entity("NetByForms.Domain.Entities.FormInput", b =>
                {
                    b.HasOne("NetByForms.Domain.Entities.Form", "Form")
                        .WithMany("Inputs")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");
                });

            modelBuilder.Entity("NetByForms.Domain.Entities.FormInputOption", b =>
                {
                    b.HasOne("NetByForms.Domain.Entities.FormInput", "FormInput")
                        .WithMany("Options")
                        .HasForeignKey("FormInputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormInput");
                });

            modelBuilder.Entity("NetByForms.Domain.Entities.Form", b =>
                {
                    b.Navigation("Inputs");
                });

            modelBuilder.Entity("NetByForms.Domain.Entities.FormInput", b =>
                {
                    b.Navigation("Options");
                });
#pragma warning restore 612, 618
        }
    }
}
