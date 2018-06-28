﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TESTABP;
using TESTABP.EntityFrameworkCore;

namespace TESTABP.Migrations
{
    [DbContext(typeof(TESTABPDbContext))]
    [Migration("20180625050454_CourseId")]
    partial class CourseId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TESTABP.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int>("Score");

                    b.Property<string>("Teacher");

                    b.HasKey("Id");

                    b.ToTable("AppCourses");
                });

            modelBuilder.Entity("TESTABP.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Phone");

                    b.Property<string>("Sex");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("AppPersons");
                });

            modelBuilder.Entity("TESTABP.SelectCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("PersonId");

                    b.HasKey("Id");

                    b.ToTable("AppSelectCourse");
                });

            modelBuilder.Entity("TESTABP.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description")
                        .HasMaxLength(65536);

                    b.Property<byte>("State");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("AppTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
