﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Twitter.Clone.Settings.Infrastructure;

#nullable disable

namespace Twitter.Clone.Settings.Migrations
{
    [DbContext(typeof(SettingsDbContext))]
    [Migration("20240217111847_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Twitter.Clone.Settings.Features.BlockedList.BlockedPage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<Guid>("BlockedPageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("UserId");

                    b.ToTable("BlockedPages");
                });

            modelBuilder.Entity("Twitter.Clone.Settings.Features.BlockedList.BlockedUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<Guid>("BlockedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("UserId");

                    b.ToTable("BlockedUsers");
                });

            modelBuilder.Entity("Twitter.Clone.Settings.Features.Notification.EmailNotificationSetting", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("DirectMessage")
                        .HasColumnType("bit");

                    b.Property<bool>("Following")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("Mention")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("EmailNotificationSetting");
                });

            modelBuilder.Entity("Twitter.Clone.Settings.Features.Notification.PushNotificationSetting", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("DirectMessage")
                        .HasColumnType("bit");

                    b.Property<bool>("Following")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("Mention")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("PushNotificationSetting");
                });

            modelBuilder.Entity("Twitter.Clone.Settings.Features.Notification.SmsNotificationSetting", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("PasswordChange")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("SmsNotificationSetting");
                });
#pragma warning restore 612, 618
        }
    }
}