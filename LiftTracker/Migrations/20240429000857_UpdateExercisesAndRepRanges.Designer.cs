﻿// <auto-generated />
using System;
using LiftTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LiftTracker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240429000857_UpdateExercisesAndRepRanges")]
    partial class UpdateExercisesAndRepRanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LiftTracker.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("LiftTracker.Data.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExerciseType")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompound")
                        .HasColumnType("bit");

                    b.Property<int?>("MuscleGroup")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExerciseType = 0,
                            IsCompound = true,
                            MuscleGroup = 0,
                            Name = "Flat Bench Press"
                        },
                        new
                        {
                            Id = 2,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroup = 0,
                            Name = "Incline DB Bench Press"
                        },
                        new
                        {
                            Id = 3,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroup = 0,
                            Name = "Incline Bench Press"
                        },
                        new
                        {
                            Id = 4,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 0,
                            Name = "Pec Deck"
                        },
                        new
                        {
                            Id = 5,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 0,
                            Name = "Incline Fly"
                        },
                        new
                        {
                            Id = 6,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 1,
                            Name = "Rope Pushdown"
                        },
                        new
                        {
                            Id = 7,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 1,
                            Name = "Overhead Rope Extension"
                        },
                        new
                        {
                            Id = 8,
                            ExerciseType = 0,
                            IsCompound = true,
                            MuscleGroup = 9,
                            Name = "Military Press"
                        },
                        new
                        {
                            Id = 9,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroup = 9,
                            Name = "Seated Military Press"
                        },
                        new
                        {
                            Id = 10,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroup = 9,
                            Name = "DB Shoulder Press"
                        },
                        new
                        {
                            Id = 11,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 9,
                            Name = "DB Front Raise"
                        },
                        new
                        {
                            Id = 12,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 2,
                            Name = "DB Lateral Raise"
                        },
                        new
                        {
                            Id = 13,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 2,
                            Name = "Upright Row"
                        },
                        new
                        {
                            Id = 14,
                            ExerciseType = 2,
                            IsCompound = true,
                            MuscleGroup = 3,
                            Name = "DB Row"
                        },
                        new
                        {
                            Id = 15,
                            ExerciseType = 2,
                            IsCompound = true,
                            MuscleGroup = 3,
                            Name = "Chin-Ups"
                        },
                        new
                        {
                            Id = 16,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 4,
                            Name = "Hammer Curl"
                        },
                        new
                        {
                            Id = 17,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 4,
                            Name = "Preacher Curl"
                        },
                        new
                        {
                            Id = 18,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 5,
                            Name = "Reverse Pec Deck"
                        },
                        new
                        {
                            Id = 19,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 5,
                            Name = "Face Pull"
                        },
                        new
                        {
                            Id = 20,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 10,
                            Name = "DB Shrugs"
                        },
                        new
                        {
                            Id = 21,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 10,
                            Name = "Barbell Shrugs"
                        },
                        new
                        {
                            Id = 22,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 11,
                            Name = "DB Wrist Curl"
                        },
                        new
                        {
                            Id = 23,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 11,
                            Name = "Barbell Wrist Curl"
                        },
                        new
                        {
                            Id = 24,
                            ExerciseType = 0,
                            IsCompound = true,
                            MuscleGroup = 6,
                            Name = "Low Bar Squat"
                        },
                        new
                        {
                            Id = 25,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroup = 6,
                            Name = "Hack Squat"
                        },
                        new
                        {
                            Id = 26,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroup = 6,
                            Name = "High Bar Squat"
                        },
                        new
                        {
                            Id = 27,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 6,
                            Name = "Leg Extension"
                        },
                        new
                        {
                            Id = 28,
                            ExerciseType = 0,
                            IsCompound = true,
                            MuscleGroup = 7,
                            Name = "Sumo Deadlift"
                        },
                        new
                        {
                            Id = 29,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroup = 7,
                            Name = "RDL"
                        },
                        new
                        {
                            Id = 30,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroup = 7,
                            Name = "Conventional Deadlift"
                        },
                        new
                        {
                            Id = 31,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 7,
                            Name = "Leg Curl"
                        },
                        new
                        {
                            Id = 32,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 12,
                            Name = "Standing Calf Raise"
                        },
                        new
                        {
                            Id = 33,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 12,
                            Name = "Seated Calf Raise"
                        },
                        new
                        {
                            Id = 34,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 8,
                            Name = "Hanging Leg Raise"
                        },
                        new
                        {
                            Id = 35,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroup = 8,
                            Name = "Ab Wheel"
                        });
                });

            modelBuilder.Entity("LiftTracker.Data.MacroCycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("MacroCycles");
                });

            modelBuilder.Entity("LiftTracker.Data.MesoCycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("TrainingBlockId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainingBlockId");

                    b.ToTable("MesoCycles");
                });

            modelBuilder.Entity("LiftTracker.Data.MicroCycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MesoCycleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MesoCycleId");

                    b.ToTable("MicroCycles");
                });

            modelBuilder.Entity("LiftTracker.Data.RepRange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("High")
                        .HasColumnType("int");

                    b.Property<int>("Low")
                        .HasColumnType("int");

                    b.Property<int>("RepRangeType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RepRanges");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            High = 3,
                            Low = 1,
                            RepRangeType = 0
                        },
                        new
                        {
                            Id = 2,
                            High = 6,
                            Low = 3,
                            RepRangeType = 1
                        },
                        new
                        {
                            Id = 3,
                            High = 8,
                            Low = 6,
                            RepRangeType = 2
                        },
                        new
                        {
                            Id = 4,
                            High = 12,
                            Low = 8,
                            RepRangeType = 3
                        },
                        new
                        {
                            Id = 5,
                            High = 15,
                            Low = 12,
                            RepRangeType = 4
                        },
                        new
                        {
                            Id = 6,
                            High = 30,
                            Low = 15,
                            RepRangeType = 5
                        });
                });

            modelBuilder.Entity("LiftTracker.Data.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DayOfTheWeek")
                        .HasColumnType("int");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<int?>("MicroCycleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MicroCycleId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("LiftTracker.Data.SessionExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int?>("RepRangeId")
                        .HasColumnType("int");

                    b.Property<int?>("SessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.ToTable("SessionExercises");
                });

            modelBuilder.Entity("LiftTracker.Data.Set", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSkipped")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Load")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Reps")
                        .HasColumnType("int");

                    b.Property<int?>("Rpe")
                        .HasColumnType("int");

                    b.Property<int?>("SessionExerciseId")
                        .HasColumnType("int");

                    b.Property<int?>("TargetRpe")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SessionExerciseId");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("LiftTracker.Data.TrainingBlock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<int?>("MacroCycleId")
                        .HasColumnType("int");

                    b.Property<int>("TrainingPhase")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MacroCycleId");

                    b.ToTable("TrainingBlocks");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LiftTracker.Data.MacroCycle", b =>
                {
                    b.HasOne("LiftTracker.Data.ApplicationUser", null)
                        .WithMany("MacroCycles")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("LiftTracker.Data.MesoCycle", b =>
                {
                    b.HasOne("LiftTracker.Data.TrainingBlock", "TrainingBlock")
                        .WithMany("MesoCycles")
                        .HasForeignKey("TrainingBlockId");

                    b.Navigation("TrainingBlock");
                });

            modelBuilder.Entity("LiftTracker.Data.MicroCycle", b =>
                {
                    b.HasOne("LiftTracker.Data.MesoCycle", "MesoCycle")
                        .WithMany("MicroCycles")
                        .HasForeignKey("MesoCycleId");

                    b.Navigation("MesoCycle");
                });

            modelBuilder.Entity("LiftTracker.Data.Session", b =>
                {
                    b.HasOne("LiftTracker.Data.MicroCycle", "MicroCycle")
                        .WithMany("Sessions")
                        .HasForeignKey("MicroCycleId");

                    b.Navigation("MicroCycle");
                });

            modelBuilder.Entity("LiftTracker.Data.SessionExercise", b =>
                {
                    b.HasOne("LiftTracker.Data.Session", "Session")
                        .WithMany("SessionExercises")
                        .HasForeignKey("SessionId");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("LiftTracker.Data.Set", b =>
                {
                    b.HasOne("LiftTracker.Data.SessionExercise", "SessionExercise")
                        .WithMany("Sets")
                        .HasForeignKey("SessionExerciseId");

                    b.Navigation("SessionExercise");
                });

            modelBuilder.Entity("LiftTracker.Data.TrainingBlock", b =>
                {
                    b.HasOne("LiftTracker.Data.MacroCycle", "MacroCycle")
                        .WithMany("TrainingBlocks")
                        .HasForeignKey("MacroCycleId");

                    b.Navigation("MacroCycle");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LiftTracker.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LiftTracker.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LiftTracker.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LiftTracker.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LiftTracker.Data.ApplicationUser", b =>
                {
                    b.Navigation("MacroCycles");
                });

            modelBuilder.Entity("LiftTracker.Data.MacroCycle", b =>
                {
                    b.Navigation("TrainingBlocks");
                });

            modelBuilder.Entity("LiftTracker.Data.MesoCycle", b =>
                {
                    b.Navigation("MicroCycles");
                });

            modelBuilder.Entity("LiftTracker.Data.MicroCycle", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("LiftTracker.Data.Session", b =>
                {
                    b.Navigation("SessionExercises");
                });

            modelBuilder.Entity("LiftTracker.Data.SessionExercise", b =>
                {
                    b.Navigation("Sets");
                });

            modelBuilder.Entity("LiftTracker.Data.TrainingBlock", b =>
                {
                    b.Navigation("MesoCycles");
                });
#pragma warning restore 612, 618
        }
    }
}
