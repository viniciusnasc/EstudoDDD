﻿// <auto-generated />
using System;
using EstudoDDD.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EstudoDDD.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EstudoDDD.Domain.Entities.CepEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<Guid>("MunicipioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Cep");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Cep");
                });

            modelBuilder.Entity("EstudoDDD.Domain.Entities.MunicipioEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CodIBGE")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<Guid>("UfId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CodIBGE");

                    b.HasIndex("UfId");

                    b.ToTable("Municipio");
                });

            modelBuilder.Entity("EstudoDDD.Domain.Entities.UfEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Sigla")
                        .IsUnique();

                    b.ToTable("Uf");

                    b.HasData(
                        new
                        {
                            Id = new Guid("77df935a-ca53-4ffd-94ae-c197e016ccf0"),
                            CreateAt = new DateTime(2021, 12, 2, 20, 31, 14, 96, DateTimeKind.Utc).AddTicks(8899),
                            Nome = "Acre",
                            Sigla = "AC"
                        },
                        new
                        {
                            Id = new Guid("8f7ae6df-d6a5-4d86-8994-e64002ee557e"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(8934),
                            Nome = "Alagoas",
                            Sigla = "AL"
                        },
                        new
                        {
                            Id = new Guid("489e8c02-00cc-4113-8dab-8e44ead66543"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(8958),
                            Nome = "Amapa",
                            Sigla = "AP"
                        },
                        new
                        {
                            Id = new Guid("2b3cb7d6-f792-4ae6-b068-38da911997d8"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(8965),
                            Nome = "Amazonas",
                            Sigla = "AM"
                        },
                        new
                        {
                            Id = new Guid("3a8ca4e0-eb66-452c-b4d5-dd4b428f3cbf"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(8971),
                            Nome = "Bahia",
                            Sigla = "BA"
                        },
                        new
                        {
                            Id = new Guid("38cdbdab-bc0b-4f2e-b561-500a1708d8da"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(8976),
                            Nome = "Ceara",
                            Sigla = "CE"
                        },
                        new
                        {
                            Id = new Guid("20792100-80af-49a8-8195-f7c36441c38d"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(8980),
                            Nome = "Espirito Santo",
                            Sigla = "ES"
                        },
                        new
                        {
                            Id = new Guid("8c797ec8-ea24-4bc5-9288-56a6cb14a8ef"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(8984),
                            Nome = "Goias",
                            Sigla = "GO"
                        },
                        new
                        {
                            Id = new Guid("7451a52c-8460-4f6a-bca6-7573b9a44759"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(8988),
                            Nome = "Maranhao",
                            Sigla = "MA"
                        },
                        new
                        {
                            Id = new Guid("786e47a5-f326-40bc-afb5-0af531e7af9f"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(8993),
                            Nome = "Mato Grosso",
                            Sigla = "MT"
                        },
                        new
                        {
                            Id = new Guid("c4dc2412-b190-411a-8352-0a857b7e327b"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(8997),
                            Nome = "Mato Grosso do Sul",
                            Sigla = "MS"
                        },
                        new
                        {
                            Id = new Guid("3b72bc3f-4613-4313-963c-9621db443e32"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9001),
                            Nome = "Minas Gerais",
                            Sigla = "MG"
                        },
                        new
                        {
                            Id = new Guid("06759cc3-cf92-49fe-9d98-a8eacb5ee621"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9005),
                            Nome = "Para",
                            Sigla = "PA"
                        },
                        new
                        {
                            Id = new Guid("d4fdba6b-ee4c-4c06-b8d7-7dcbbc0d02fa"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9009),
                            Nome = "Paraiba",
                            Sigla = "PB"
                        },
                        new
                        {
                            Id = new Guid("ef7e5a58-45a2-4b80-8e13-fdeefb2f5a5e"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9012),
                            Nome = "Parana",
                            Sigla = "PR"
                        },
                        new
                        {
                            Id = new Guid("451ecb2b-0ba5-48c7-84ff-32772634c258"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9017),
                            Nome = "Pernambuco",
                            Sigla = "PE"
                        },
                        new
                        {
                            Id = new Guid("275002db-aa62-444e-a179-b801583c3568"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9021),
                            Nome = "Piaui",
                            Sigla = "PI"
                        },
                        new
                        {
                            Id = new Guid("3b0458c6-5eff-4342-bd53-4591d7c006de"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9024),
                            Nome = "Rio de Janeiro",
                            Sigla = "RJ"
                        },
                        new
                        {
                            Id = new Guid("dca93b97-5ef7-44ee-bfb4-5f63b0c72598"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9028),
                            Nome = "Rio Grande do Norte",
                            Sigla = "RN"
                        },
                        new
                        {
                            Id = new Guid("6b57ce63-eb3a-4c73-8b59-8098e6862d48"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9032),
                            Nome = "Rio Grande do Sul",
                            Sigla = "RS"
                        },
                        new
                        {
                            Id = new Guid("12405ad1-e3e5-43fd-9bfe-0c6fa4816105"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9036),
                            Nome = "Rondonia",
                            Sigla = "RO"
                        },
                        new
                        {
                            Id = new Guid("a850fb53-9f5b-449e-b691-d084f8b5a402"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9041),
                            Nome = "Roraima",
                            Sigla = "RR"
                        },
                        new
                        {
                            Id = new Guid("dbb01ebc-4776-4f72-b630-7b249d81c440"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9045),
                            Nome = "Santa Catarina",
                            Sigla = "SC"
                        },
                        new
                        {
                            Id = new Guid("5e684315-735e-4c8e-a508-8df50649dc1d"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9049),
                            Nome = "Sao Paulo",
                            Sigla = "SP"
                        },
                        new
                        {
                            Id = new Guid("6d2e386b-a450-4976-83ce-ed107120c9fb"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9053),
                            Nome = "Sergipe",
                            Sigla = "SE"
                        },
                        new
                        {
                            Id = new Guid("7fdaaa4c-13ed-49d4-b1aa-ceaae53254b6"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9057),
                            Nome = "Tocantins",
                            Sigla = "TO"
                        },
                        new
                        {
                            Id = new Guid("141a0daa-47e8-49fe-8dea-0ee97e4db538"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 96, DateTimeKind.Local).AddTicks(9061),
                            Nome = "Distrito Federal",
                            Sigla = "DF"
                        });
                });

            modelBuilder.Entity("EstudoDDD.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1980a9da-d23d-4e11-821f-82f3ab3ebb5b"),
                            CreateAt = new DateTime(2021, 12, 2, 17, 31, 14, 90, DateTimeKind.Local).AddTicks(5373),
                            Email = "vini.souza00@gmail.com",
                            Name = "Vinicius",
                            UpdateAt = new DateTime(2021, 12, 2, 17, 31, 14, 92, DateTimeKind.Local).AddTicks(5596)
                        });
                });

            modelBuilder.Entity("EstudoDDD.Domain.Entities.CepEntity", b =>
                {
                    b.HasOne("EstudoDDD.Domain.Entities.MunicipioEntity", "Municipio")
                        .WithMany("Ceps")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("EstudoDDD.Domain.Entities.MunicipioEntity", b =>
                {
                    b.HasOne("EstudoDDD.Domain.Entities.UfEntity", "Uf")
                        .WithMany("Municipios")
                        .HasForeignKey("UfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uf");
                });

            modelBuilder.Entity("EstudoDDD.Domain.Entities.MunicipioEntity", b =>
                {
                    b.Navigation("Ceps");
                });

            modelBuilder.Entity("EstudoDDD.Domain.Entities.UfEntity", b =>
                {
                    b.Navigation("Municipios");
                });
#pragma warning restore 612, 618
        }
    }
}
