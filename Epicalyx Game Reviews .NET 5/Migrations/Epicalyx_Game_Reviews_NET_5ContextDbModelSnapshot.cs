﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Epicalyx_Game_Reviews_.NET_5.Migrations
{
    [DbContext(typeof(Epicalyx_Game_Reviews_NET_5ContextDb))]
    partial class Epicalyx_Game_Reviews_NET_5ContextDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Epicalyx_Game_Reviews_.NET_5.Models.AspectReview", b =>
                {
                    b.Property<int>("AspectReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameID")
                        .HasColumnType("int");

                    b.Property<int>("GameplayRating")
                        .HasColumnType("int");

                    b.Property<int>("GraphicsRating")
                        .HasColumnType("int");

                    b.Property<int?>("MultiplayerRating")
                        .HasColumnType("int");

                    b.Property<int>("SoundtrackRating")
                        .HasColumnType("int");

                    b.Property<decimal?>("StoryCompletion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StoryRating")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalCompletion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("AspectReviewID");

                    b.HasIndex("GameID");

                    b.HasIndex("UserID");

                    b.ToTable("AspectReview");
                });

            modelBuilder.Entity("Epicalyx_Game_Reviews_.NET_5.Models.FinalReview", b =>
                {
                    b.Property<int>("FinalReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FinalRating")
                        .HasColumnType("int");

                    b.Property<int>("GameID")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("FinalReviewID");

                    b.HasIndex("GameID");

                    b.HasIndex("UserID");

                    b.ToTable("FinalReview");
                });

            modelBuilder.Entity("Epicalyx_Game_Reviews_.NET_5.Models.Game", b =>
                {
                    b.Property<int>("GameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgeRating")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.HasKey("GameID");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("Epicalyx_Game_Reviews_.NET_5.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfilePic")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Epicalyx_Game_Reviews_.NET_5.Models.AspectReview", b =>
                {
                    b.HasOne("Epicalyx_Game_Reviews_.NET_5.Models.Game", "Game")
                        .WithMany("AspectReview")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Epicalyx_Game_Reviews_.NET_5.Models.User", "User")
                        .WithMany("AspectReview")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Epicalyx_Game_Reviews_.NET_5.Models.FinalReview", b =>
                {
                    b.HasOne("Epicalyx_Game_Reviews_.NET_5.Models.Game", "Game")
                        .WithMany("FinalReview")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Epicalyx_Game_Reviews_.NET_5.Models.User", "User")
                        .WithMany("FinalReview")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Epicalyx_Game_Reviews_.NET_5.Models.Game", b =>
                {
                    b.Navigation("AspectReview");

                    b.Navigation("FinalReview");
                });

            modelBuilder.Entity("Epicalyx_Game_Reviews_.NET_5.Models.User", b =>
                {
                    b.Navigation("AspectReview");

                    b.Navigation("FinalReview");
                });
#pragma warning restore 612, 618
        }
    }
}
