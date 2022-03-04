﻿// <auto-generated />
using System;
using FeedbackWebsite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FeedbackWebsite.Migrations
{
    [DbContext(typeof(FeedbackWebsiteContext))]
    [Migration("20220303233530_SeedingMoved")]
    partial class SeedingMoved
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FeedbackWebsite.Models.AnswersInfoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("EventId");

                    b.Property<int>("QuestionId");

                    b.HasKey("Id");

                    b.ToTable("AnswersInfoModel");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AnswersInfoModel");
                });

            modelBuilder.Entity("FeedbackWebsite.Models.EventInfoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EventEndDate");

                    b.Property<string>("EventLocation");

                    b.Property<string>("EventName")
                        .IsRequired();

                    b.Property<string>("EventOrg");

                    b.Property<DateTime>("EventStartDate");

                    b.Property<string>("PresentersName");

                    b.HasKey("Id");

                    b.ToTable("EventInfoModel");
                });

            modelBuilder.Entity("FeedbackWebsite.Models.QuestionTextModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsEnum");

                    b.Property<string>("QuestionText");

                    b.HasKey("Id");

                    b.ToTable("QuestionTextModel");
                });

            modelBuilder.Entity("FeedbackWebsite.Models.UserEventModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserEventModels");
                });

            modelBuilder.Entity("FeedbackWebsite.Models.AnswerEnum", b =>
                {
                    b.HasBaseType("FeedbackWebsite.Models.AnswersInfoModel");

                    b.Property<int>("QuestionEnumAnswer");

                    b.HasDiscriminator().HasValue("AnswerEnum");
                });

            modelBuilder.Entity("FeedbackWebsite.Models.AnswerText", b =>
                {
                    b.HasBaseType("FeedbackWebsite.Models.AnswersInfoModel");

                    b.Property<string>("AnswerTextAnswer");

                    b.HasDiscriminator().HasValue("AnswerText");
                });
#pragma warning restore 612, 618
        }
    }
}
