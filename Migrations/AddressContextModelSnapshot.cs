// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechnicalTestSocialBrothers.Properties.Models;

#nullable disable

namespace TechnicalTestSocialBrothers.Migrations
{
    [DbContext(typeof(AddressContext))]
    partial class AddressContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("TechnicalTestSocialBrothers.Properties.Models.AddressInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ZipCode")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Adresses");
                });
#pragma warning restore 612, 618
        }
    }
}
