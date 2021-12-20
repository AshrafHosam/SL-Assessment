﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SL_Assessment.Data;

namespace SL_Assessment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SL_Assessment.Models.VideoBrief", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoBriefs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                            ImageUrl = "~/images/0001.png",
                            Title = "How to control your facial expressions",
                            VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                        },
                        new
                        {
                            Id = 2,
                            Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                            ImageUrl = "~/images/0008.png",
                            Title = "How to control your facial expressions",
                            VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                        },
                        new
                        {
                            Id = 3,
                            Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                            ImageUrl = "~/images/0002.png",
                            Title = "How to control your facial expressions",
                            VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                        },
                        new
                        {
                            Id = 4,
                            Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                            ImageUrl = "~/images/0007.png",
                            Title = "How to control your facial expressions",
                            VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                            ImageUrl = "~/images/0008.png",
                            Title = "How to control your facial expressions",
                            VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                        },
                        new
                        {
                            Id = 6,
                            Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                            ImageUrl = "~/images/0001.png",
                            Title = "How to control your facial expressions",
                            VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                        },
                        new
                        {
                            Id = 7,
                            Description = "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.",
                            ImageUrl = "~/images/0002.png",
                            Title = "How to control your facial expressions",
                            VideoUrl = "~/videos/SampleVideo_360x240_1mb.mp4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}