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
    [Migration("20240415002027_UpdateExerciseNames5")]
    partial class UpdateExerciseNames5
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

                    b.Property<int?>("ExerciseType")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompound")
                        .HasColumnType("bit");

                    b.Property<int?>("MuscleGroupId")
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
                            MuscleGroupId = 1,
                            Name = "Comp Bench"
                        },
                        new
                        {
                            Id = 2,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroupId = 1,
                            Name = "Touch-And-Go Bench"
                        },
                        new
                        {
                            Id = 3,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 1,
                            Name = "Incline Fly"
                        },
                        new
                        {
                            Id = 4,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 1,
                            Name = "Pec Deck"
                        },
                        new
                        {
                            Id = 5,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroupId = 2,
                            Name = "Close Grip Bench Press"
                        },
                        new
                        {
                            Id = 6,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroupId = 2,
                            Name = "Board Press"
                        },
                        new
                        {
                            Id = 7,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 2,
                            Name = "Rope Pushdown"
                        },
                        new
                        {
                            Id = 8,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 2,
                            Name = "Rope Extension"
                        },
                        new
                        {
                            Id = 9,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroupId = 10,
                            Name = "Overhead Press"
                        },
                        new
                        {
                            Id = 10,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 10,
                            Name = "DB Front Raise"
                        },
                        new
                        {
                            Id = 11,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 3,
                            Name = "DB Lateral Raise"
                        },
                        new
                        {
                            Id = 12,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 3,
                            Name = "Machine Lateral Raise"
                        },
                        new
                        {
                            Id = 13,
                            ExerciseType = 2,
                            IsCompound = true,
                            MuscleGroupId = 4,
                            Name = "DB Row"
                        },
                        new
                        {
                            Id = 14,
                            ExerciseType = 2,
                            IsCompound = true,
                            MuscleGroupId = 4,
                            Name = "Chin-Ups"
                        },
                        new
                        {
                            Id = 15,
                            ExerciseType = 2,
                            IsCompound = true,
                            MuscleGroupId = 4,
                            Name = "Neutral Grip Pulldown"
                        },
                        new
                        {
                            Id = 16,
                            ExerciseType = 2,
                            IsCompound = true,
                            MuscleGroupId = 4,
                            Name = "Seated Row"
                        },
                        new
                        {
                            Id = 17,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 5,
                            Name = "Hammer Curl"
                        },
                        new
                        {
                            Id = 18,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 5,
                            Name = "DB Curl"
                        },
                        new
                        {
                            Id = 19,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 5,
                            Name = "Preacher Curl"
                        },
                        new
                        {
                            Id = 20,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 5,
                            Name = "Cable Curl"
                        },
                        new
                        {
                            Id = 21,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 6,
                            Name = "Reverse Pec Deck"
                        },
                        new
                        {
                            Id = 22,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 6,
                            Name = "Face Pull"
                        },
                        new
                        {
                            Id = 23,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 11,
                            Name = "DB Shrugs"
                        },
                        new
                        {
                            Id = 24,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 12,
                            Name = "DB Wrist Curl"
                        },
                        new
                        {
                            Id = 25,
                            ExerciseType = 0,
                            IsCompound = true,
                            MuscleGroupId = 7,
                            Name = "Low Bar Squat"
                        },
                        new
                        {
                            Id = 26,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroupId = 7,
                            Name = "High Bar Squat"
                        },
                        new
                        {
                            Id = 27,
                            ExerciseType = 2,
                            IsCompound = true,
                            MuscleGroupId = 7,
                            Name = "Split Squat"
                        },
                        new
                        {
                            Id = 28,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 7,
                            Name = "Leg Extension"
                        },
                        new
                        {
                            Id = 29,
                            ExerciseType = 0,
                            IsCompound = true,
                            MuscleGroupId = 8,
                            Name = "Dead Stop Sumo Deadlift"
                        },
                        new
                        {
                            Id = 30,
                            ExerciseType = 1,
                            IsCompound = true,
                            MuscleGroupId = 8,
                            Name = "Touch-And-Go Conventional Deadlift"
                        },
                        new
                        {
                            Id = 31,
                            ExerciseType = 2,
                            IsCompound = true,
                            MuscleGroupId = 8,
                            Name = "Good Morning"
                        },
                        new
                        {
                            Id = 32,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 8,
                            Name = "Leg Curl"
                        },
                        new
                        {
                            Id = 33,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 13,
                            Name = "Standing Calf Raise"
                        },
                        new
                        {
                            Id = 34,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 13,
                            Name = "Seated Calf Raise"
                        },
                        new
                        {
                            Id = 35,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 9,
                            Name = "Hanging Leg Raise"
                        },
                        new
                        {
                            Id = 36,
                            ExerciseType = 2,
                            IsCompound = false,
                            MuscleGroupId = 9,
                            Name = "Weighted Decline Situp"
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

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

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

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

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

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<int?>("MesoCycleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MesoCycleId");

                    b.ToTable("MicroCycles");
                });

            modelBuilder.Entity("LiftTracker.Data.MuscleGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExercisesPerSession")
                        .HasColumnType("int");

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.Property<int>("MEV")
                        .HasColumnType("int");

                    b.Property<int>("MRV")
                        .HasColumnType("int");

                    b.Property<int>("MV")
                        .HasColumnType("int");

                    b.Property<int>("MuscleGroupEnum")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MuscleGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExercisesPerSession = 1,
                            Frequency = 2,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 0,
                            Name = "Chest"
                        },
                        new
                        {
                            Id = 2,
                            ExercisesPerSession = 1,
                            Frequency = 2,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 1,
                            Name = "Triceps"
                        },
                        new
                        {
                            Id = 3,
                            ExercisesPerSession = 1,
                            Frequency = 2,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 2,
                            Name = "Side Delts"
                        },
                        new
                        {
                            Id = 4,
                            ExercisesPerSession = 1,
                            Frequency = 2,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 3,
                            Name = "Back"
                        },
                        new
                        {
                            Id = 5,
                            ExercisesPerSession = 1,
                            Frequency = 2,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 4,
                            Name = "Biceps"
                        },
                        new
                        {
                            Id = 6,
                            ExercisesPerSession = 1,
                            Frequency = 2,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 5,
                            Name = "Rear Delts"
                        },
                        new
                        {
                            Id = 7,
                            ExercisesPerSession = 1,
                            Frequency = 2,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 6,
                            Name = "Quads"
                        },
                        new
                        {
                            Id = 8,
                            ExercisesPerSession = 1,
                            Frequency = 2,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 7,
                            Name = "Hamstrings"
                        },
                        new
                        {
                            Id = 9,
                            ExercisesPerSession = 1,
                            Frequency = 2,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 8,
                            Name = "Core"
                        },
                        new
                        {
                            Id = 10,
                            ExercisesPerSession = 1,
                            Frequency = 2,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 9,
                            Name = "Front Delts"
                        },
                        new
                        {
                            Id = 11,
                            ExercisesPerSession = 1,
                            Frequency = 1,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 10,
                            Name = "Traps"
                        },
                        new
                        {
                            Id = 12,
                            ExercisesPerSession = 1,
                            Frequency = 1,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 11,
                            Name = "Forearms"
                        },
                        new
                        {
                            Id = 13,
                            ExercisesPerSession = 1,
                            Frequency = 2,
                            MEV = 10,
                            MRV = 20,
                            MV = 5,
                            MuscleGroupEnum = 12,
                            Name = "Calves"
                        });
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
                    b.HasOne("LiftTracker.Data.Session", null)
                        .WithMany("SessionExercises")
                        .HasForeignKey("SessionId");
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
