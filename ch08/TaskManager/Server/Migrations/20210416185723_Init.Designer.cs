﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManager.Server.Data;

namespace TaskManager.Server.Migrations
{
    [DbContext(typeof(TaskManagerServerContext))]
    [Migration("20210416185723_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskManager.Shared.TaskItem", b =>
                {
                    b.Property<int>("TaskItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("TaskName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskItemId");

                    b.ToTable("TaskItem");
                });
#pragma warning restore 612, 618
        }
    }
}
