﻿// <auto-generated />
using BAYSOFT.Core.Infrastructures.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BAYSOFT.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    [Migration("20200725024717_InitialDefaultDbMigration")]
    partial class InitialDefaultDbMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BAYSOFT.Core.Domain.Entities.Default.Sample", b =>
                {
                    b.Property<int>("SampleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SampleID");

                    b.ToTable("Samples");
                });
#pragma warning restore 612, 618
        }
    }
}
