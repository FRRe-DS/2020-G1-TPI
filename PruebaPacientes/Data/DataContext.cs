using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Text.Json;
using Microsoft.Data.SqlClient;
namespace Data
{
    public class DataContext : DbContext
    {
        private readonly SqlConnection _SqlConnection;
        private readonly string _connectionString;

        public DataContext()
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json");
            var configuration = configurationBuilder.Build();
            _connectionString = configuration.GetValue<string>("Data:ConnectionStrings:defaultConnection");
            _SqlConnection = new SqlConnection(_connectionString);
        }

        public DbSet<AntecedenteEpidemiologicos1> ListaAntecedenteEpidemiologicos1 { get; set; }
        public DbSet<AntecedenteEpidemiologicos2> ListaAntecedenteEpidemiologicos2 { get; set; }
        public DbSet<EnfermedadesPreviasComorbilidades> ListaEnfermedadesPreviasComorbilidades { get; set; }
        public DbSet<SignosYSintomas> ListaSignosYSintomas { get; set; }
        public DbSet<Paciente> ListaPaciente { get; set; }
        public DbSet<FormularioParaAnalisis> ListaFormularioParaAnalisis { get; set; }
        public DbSet<Localidad> ListaLocalidades { get; set; }
        public DbSet<Provincia> ListaProvincias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_SqlConnection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //***************************************************************************************************
            // DOMICILIO
            //***************************************************************************************************
            modelBuilder.Entity<Domicilio>()
                .HasKey(c => c.DomicilioId);

            //***************************************************************************************************
            // PACIENTE
            //***************************************************************************************************
            modelBuilder.Entity<Paciente>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.TipoDeDocumento)
                    .HasConversion(
                     v => v.ToString(),
                        v => (TipoDeDocumento)Enum.Parse(typeof(TipoDeDocumento), v));

            //modelBuilder.Entity<Paciente>()
            //    .HasIndex(b => b.NroDeDocumento)
            //    .IsUnique();


            //***************************************************************************************************
            // PROVINCIA
            //***************************************************************************************************
            modelBuilder.Entity<Provincia>()
                .HasKey(c => c.Id);

            //***************************************************************************************************
            // LOCALIDAD
            //***************************************************************************************************
            modelBuilder.Entity<Localidad>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Localidad>()
               .HasOne(c => c.Provincia)
               .WithMany()
               .HasForeignKey(a => a.ProvinciaId);


            //***************************************************************************************************
            // FORMULARIO_PARA_ANALISIS
            //***************************************************************************************************
            modelBuilder.Entity<FormularioParaAnalisis>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<FormularioParaAnalisis>()
                .Property(e => e.EstadoDelFormulario)
                .HasConversion(
                    v => v.ToString(),
                    v => (EstadoDelFormulario)Enum.Parse(typeof(EstadoDelFormulario), v));

            //modelBuilder.Entity<FormularioParaAnalisis>() // Relacion 1 a 1
            //   .HasOne<AntecedenteEpidemiologicos1>(a => a.AntecedenteEpidemiologicos1)
            //   .WithOne(b => b.FormularioParaAnalisis)
            //    .HasForeignKey<AntecedenteEpidemiologicos1>(c => c.FormularioParaAnalisisId);

            //modelBuilder.Entity<FormularioParaAnalisis>() // Relacion 1 a 1
            // .HasOne(a => a.AntecedenteEpidemiologicos2)
            // .WithOne(b => b.FormularioParaAnalisis)
            //  .HasForeignKey<AntecedenteEpidemiologicos2>(c => c.FormularioParaAnalisisId);

            //modelBuilder.Entity<FormularioParaAnalisis>() // Relacion 1 a 1
            // .HasOne(a => a.EnfermedadesPreviasComorbilidades)
            // .WithOne(b => b.FormularioParaAnalisis)
            //  .HasForeignKey<EnfermedadesPreviasComorbilidades>(c => c.FormularioParaAnalisisId);

            //modelBuilder.Entity<FormularioParaAnalisis>() // Relacion 1 a 1
            // .HasOne(a => a.SignosYSintomas)
            // .WithOne(b => b.FormularioParaAnalisis)
            //  .HasForeignKey<SignosYSintomas>(c => c.FormularioParaAnalisisId);


            //***************************************************************************************************
            // ANTECEDENTE_EPIDEMIOLOGICOS1
            //***************************************************************************************************
            modelBuilder.Entity<AntecedenteEpidemiologicos1>()
                .Property(e => e.TipoDeOcupacionDelPaciente)
                .HasConversion(
                    v => v.ToString(),
                    v => (TipoDeOcupacionDelPaciente)Enum.Parse(typeof(TipoDeOcupacionDelPaciente), v));

            modelBuilder.Entity<AntecedenteEpidemiologicos1>()
                .Property(e => e.TipoDeOcupacionDelPaciente)
                .HasConversion(
                    v => v.ToString(),
                    v => (TipoDeOcupacionDelPaciente)Enum.Parse(typeof(TipoDeOcupacionDelPaciente), v));

            modelBuilder.Entity<AntecedenteEpidemiologicos1>()
                .Property(e => e.TipoDeTransporteUtilizado)
                .HasConversion(
                    v => v.ToString(),
                    v => (TipoDeTransporteUtilizado)Enum.Parse(typeof(TipoDeTransporteUtilizado), v));

            //***************************************************************************************************
            // ANTECEDENTE_EPIDEMIOLOGICOS2
            //***************************************************************************************************
            modelBuilder.Entity<AntecedenteEpidemiologicos2>()
                .Property(e => e.TipoDeAnimalesConContacto)
                .HasConversion(
                    v => v.ToString(),
                    v => (TipoDeAnimalesConContacto)Enum.Parse(typeof(TipoDeAnimalesConContacto), v));

            modelBuilder.Entity<AntecedenteEpidemiologicos2>()
                .Property(e => e.TipoDeEntornoDeContacto)
                .HasConversion(
                    v => v.ToString(),
                    v => (TipoDeEntornoDeContacto)Enum.Parse(typeof(TipoDeEntornoDeContacto), v));
        }
    }
}
