﻿// <auto-generated />
using System;
using AllanNovalta.PollQuestion.Web.Infrastructures.Data.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AllanNovalta.PollQuestion.Web.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    [Migration("20190309182254_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AllanNovalta.PollQuestion.Web.Infrastructures.Data.Models.PollAnswer", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("PollChoiceId");

                    b.Property<Guid?>("PollQuestionId");

                    b.Property<DateTime>("Timestamp");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.ToTable("PollAnswers");
                });

            modelBuilder.Entity("AllanNovalta.PollQuestion.Web.Infrastructures.Data.Models.PollChoice", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Text");

                    b.Property<DateTime>("Timestamp");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("PollChoices");
                });

            modelBuilder.Entity("AllanNovalta.PollQuestion.Web.Infrastructures.Data.Models.PollQuestion", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("Description");

                    b.Property<bool>("IsPublished");

                    b.Property<DateTime>("PostExpiry");

                    b.Property<string>("TemplateName");

                    b.Property<DateTime>("Timestamp");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("PollQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}
