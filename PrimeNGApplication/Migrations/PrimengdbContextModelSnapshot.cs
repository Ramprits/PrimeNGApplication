using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PrimeNGApplication.Entity;

namespace PrimeNGApplication.Migrations
{
    [DbContext(typeof(PrimengdbContext))]
    partial class PrimengdbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PrimeNGApplication.Entity.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("DepartmentId");

                    b.ToTable("Department","mst");
                });

            modelBuilder.Entity("PrimeNGApplication.Entity.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee","mst");
                });

            modelBuilder.Entity("PrimeNGApplication.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("MyProperty");

                    b.Property<int>("Price");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTime?>("ReleaseDate");

                    b.Property<int>("StarRating");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("PrimeNGApplication.Entity.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductId");

                    b.Property<string>("TagName");

                    b.HasKey("TagId");

                    b.HasIndex("ProductId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("PrimeNGApplication.Entity.Tag", b =>
                {
                    b.HasOne("PrimeNGApplication.Entity.Product", "Product")
                        .WithMany("Tag")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
