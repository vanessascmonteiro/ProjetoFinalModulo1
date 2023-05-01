﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using integralesaude.Models;

#nullable disable

namespace integralesaude.Migrations
{
    [DbContext(typeof(LabMedicineContext))]
    [Migration("20230424222006_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("integrale.Models.PacientesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContatodeEmergencia")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ContatodeEmergencia");

                    b.Property<string>("Convenio")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Convênio");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DatadeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ListaAlergias")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Lista de Alergias");

                    b.Property<string>("ListadeCuidadosEspecificos")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Lista de Cuidados Específicos");

                    b.Property<string>("NomeCompleto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("StatusAtendimento")
                        .HasColumnType("int")
                        .HasColumnName("Status de Atendimento");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotaldeAtendimentos")
                        .HasColumnType("int")
                        .HasColumnName("Total de Atendimentos");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique()
                        .HasFilter("[Cpf] IS NOT NULL");

                    b.ToTable("Pacientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContatodeEmergencia = "Maria Souza (mãe) - (11) 99999-8888",
                            Convenio = "Bradesco Saúde",
                            Cpf = "123.456.789-00",
                            DatadeNascimento = new DateTime(1990, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListaAlergias = "Penicilina",
                            ListadeCuidadosEspecificos = "Dieta sem glúten",
                            NomeCompleto = "Ana Souza Lima",
                            StatusAtendimento = 0,
                            TotaldeAtendimentos = 0
                        },
                        new
                        {
                            Id = 2,
                            ContatodeEmergencia = "João Oliveira (irmão) - (21) 98765-4321",
                            Convenio = "Unimed",
                            Cpf = "234.567.890-11",
                            DatadeNascimento = new DateTime(1990, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListaAlergias = "Nenhuma",
                            ListadeCuidadosEspecificos = "Nenhum",
                            NomeCompleto = "Pedro Santos Oliveira",
                            StatusAtendimento = 0,
                            TotaldeAtendimentos = 0
                        },
                        new
                        {
                            Id = 3,
                            ContatodeEmergencia = "Rafael Ferreira (irmão) - (31) 99999-5555",
                            Convenio = "Amil",
                            Cpf = "345.678.901-22",
                            DatadeNascimento = new DateTime(1996, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListaAlergias = "Nenhuma",
                            ListadeCuidadosEspecificos = "Hipertensão",
                            NomeCompleto = "Marina Ferreira Costa",
                            StatusAtendimento = 0,
                            TotaldeAtendimentos = 0
                        },
                        new
                        {
                            Id = 4,
                            ContatodeEmergencia = "Maria da Silva (esposa) - (81) 98888-7777",
                            Convenio = "Hapvida",
                            Cpf = "456.789.012-33",
                            DatadeNascimento = new DateTime(1960, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListaAlergias = "Aspirina",
                            ListadeCuidadosEspecificos = "Diabetes",
                            NomeCompleto = "José da Silva Santos",
                            StatusAtendimento = 0,
                            TotaldeAtendimentos = 0
                        },
                        new
                        {
                            Id = 5,
                            ContatodeEmergencia = "Ana Almeida (mãe) - (51) 98765-4321",
                            Convenio = "SulAmérica Saúde",
                            Cpf = "567.890.123-44",
                            DatadeNascimento = new DateTime(1998, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListaAlergias = "Frutos do mar",
                            ListadeCuidadosEspecificos = "Nenhum",
                            NomeCompleto = "Juliana Almeida Rodrigues",
                            StatusAtendimento = 0,
                            TotaldeAtendimentos = 0
                        },
                        new
                        {
                            Id = 6,
                            ContatodeEmergencia = "Maria Santos (esposa) - (21) 99999-4444",
                            Convenio = "Bradesco Saúde",
                            Cpf = "678.901.234-55",
                            DatadeNascimento = new DateTime(1975, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListaAlergias = "Nenhuma",
                            ListadeCuidadosEspecificos = "Nenhum",
                            NomeCompleto = "Ricardo Santos Silva",
                            StatusAtendimento = 0,
                            TotaldeAtendimentos = 0
                        },
                        new
                        {
                            Id = 7,
                            ContatodeEmergencia = "Luiz Pereira (pai) - (27) 98888-2222",
                            Convenio = "Unimed",
                            Cpf = "789.012.345-66",
                            DatadeNascimento = new DateTime(1987, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListaAlergias = "Nenhuma",
                            ListadeCuidadosEspecificos = "Nenhum",
                            NomeCompleto = "Fernanda Pereira Nunes",
                            StatusAtendimento = 0,
                            TotaldeAtendimentos = 0
                        },
                        new
                        {
                            Id = 8,
                            ContatodeEmergencia = "Joana Costa (irmã) - (85) 99999-3333",
                            Convenio = "Unimed",
                            Cpf = "890.123.456-77",
                            DatadeNascimento = new DateTime(1995, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListaAlergias = "ovo",
                            ListadeCuidadosEspecificos = "Nenhum",
                            NomeCompleto = "Marcelo Costa Oliveira",
                            StatusAtendimento = 0,
                            TotaldeAtendimentos = 0
                        },
                        new
                        {
                            Id = 9,
                            ContatodeEmergencia = "Maria da Silva (esposa) - (11) 98888-5555",
                            Convenio = "Bradesco Saúde",
                            Cpf = "012.345.678-90",
                            DatadeNascimento = new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListaAlergias = "penicilina",
                            ListadeCuidadosEspecificos = "Hipertensão",
                            NomeCompleto = "João da Silva",
                            StatusAtendimento = 0,
                            TotaldeAtendimentos = 0
                        },
                        new
                        {
                            Id = 10,
                            ContatodeEmergencia = "Ana Oliveira (mãe) - (31) 99999-1111",
                            Convenio = "Amil",
                            Cpf = "123.456.789-01",
                            DatadeNascimento = new DateTime(1996, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListaAlergias = "nenhum",
                            ListadeCuidadosEspecificos = "Diabetes",
                            NomeCompleto = "Amanda Oliveira Santos",
                            StatusAtendimento = 0,
                            TotaldeAtendimentos = 0
                        });
                });

            modelBuilder.Entity("integralesaude.Models.EnfermeirosModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("COFEN")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COFEN");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DatadeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstituicaodeEnsino")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Instituição de Ensino");

                    b.Property<string>("NomeCompleto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique()
                        .HasFilter("[Cpf] IS NOT NULL");

                    b.ToTable("Enfermeiros");

                    b.HasData(
                        new
                        {
                            Id = 13,
                            COFEN = "125524",
                            Cpf = "256.547.218-27",
                            DatadeNascimento = new DateTime(1980, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InstituicaodeEnsino = "UFRJ",
                            NomeCompleto = "Fernando Silva Borges"
                        },
                        new
                        {
                            Id = 14,
                            COFEN = "25134684",
                            Cpf = "584.395.127-20",
                            DatadeNascimento = new DateTime(1990, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InstituicaodeEnsino = "UFSC",
                            NomeCompleto = "Karina Monteiro"
                        });
                });

            modelBuilder.Entity("integralesaude.Models.MedicosModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CRM")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CRM");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DatadeNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("EspecializacaoClinica")
                        .HasColumnType("int")
                        .HasColumnName("Especialização Clínica");

                    b.Property<int>("EstadonoSistema")
                        .HasColumnType("int")
                        .HasColumnName("Estado no Sistema");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstituicaodeEnsino")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Instituição de Ensino");

                    b.Property<string>("NomeCompleto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotaldeAtendimentos")
                        .HasColumnType("int")
                        .HasColumnName("Total de Atendimentos");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique()
                        .HasFilter("[Cpf] IS NOT NULL");

                    b.ToTable("Medicos");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            CRM = "04532",
                            Cpf = "256.589.129-27",
                            DatadeNascimento = new DateTime(1986, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EspecializacaoClinica = 0,
                            EstadonoSistema = 0,
                            InstituicaodeEnsino = "UFRJ",
                            NomeCompleto = "Victor Ferreira dos Santos",
                            TotaldeAtendimentos = 0
                        },
                        new
                        {
                            Id = 12,
                            CRM = "125623",
                            Cpf = "103.795.617-60",
                            DatadeNascimento = new DateTime(1984, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EspecializacaoClinica = 0,
                            EstadonoSistema = 0,
                            InstituicaodeEnsino = "UFSC",
                            NomeCompleto = "Vanessa Mendez",
                            TotaldeAtendimentos = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
