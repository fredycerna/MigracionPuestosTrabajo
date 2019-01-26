namespace MigracionPuestosTrabajo.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PerfilesModel : DbContext
    {
        public PerfilesModel()
            : base("name=PerfilesModel")
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Competencia> Competencias { get; set; }
        public virtual DbSet<ElementosPuestoTrabajo> ElementosPuestoTrabajoes { get; set; }
        public virtual DbSet<FotografiasPersonal> FotografiasPersonals { get; set; }
        public virtual DbSet<FuncionesUnidad> FuncionesUnidads { get; set; }
        public virtual DbSet<PasosProcedimiento> PasosProcedimientoes { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<Procedimiento> Procedimientos { get; set; }
        public virtual DbSet<PuestosTrabajo> PuestosTrabajoes { get; set; }
        public virtual DbSet<SubCategoria> SubCategorias { get; set; }
        public virtual DbSet<TiposPaso> TiposPasoes { get; set; }
        public virtual DbSet<TiposPuesto> TiposPuestoes { get; set; }
        public virtual DbSet<Unidade> Unidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Competencia>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FuncionesUnidad>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PasosProcedimiento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PasosProcedimiento>()
                .Property(e => e.Predecesores)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Personal>()
                .HasOptional(e => e.FotografiasPersonal)
                .WithRequired(e => e.Personal);

            modelBuilder.Entity<Procedimiento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .Property(e => e.ObjetivoInicial)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .Property(e => e.ObjetvioFinal)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .HasMany(e => e.PasosProcedimientoes)
                .WithRequired(e => e.Procedimiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Procedimiento>()
                .HasMany(e => e.Unidades)
                .WithMany(e => e.Procedimientos)
                .Map(m => m.ToTable("ProcedimientoUnidad").MapLeftKey("ProcedimientoID").MapRightKey("UnidadID"));

            modelBuilder.Entity<PuestosTrabajo>()
                .Property(e => e.Objetivo)
                .IsUnicode(false);

            modelBuilder.Entity<PuestosTrabajo>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<PuestosTrabajo>()
                .HasMany(e => e.PuestosTrabajo1)
                .WithOptional(e => e.PuestosTrabajo2)
                .HasForeignKey(e => e.JefeInmediatoID);

            modelBuilder.Entity<PuestosTrabajo>()
                .HasMany(e => e.Unidades)
                .WithOptional(e => e.PuestosTrabajo)
                .HasForeignKey(e => e.PuestoResponsableID);

            modelBuilder.Entity<TiposPaso>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TiposPuesto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Unidade>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Unidade>()
                .Property(e => e.Objetivo)
                .IsUnicode(false);

            modelBuilder.Entity<Unidade>()
                .HasMany(e => e.PuestosTrabajoes)
                .WithRequired(e => e.Unidade)
                .HasForeignKey(e => e.UnidadID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unidade>()
                .HasMany(e => e.Unidades1)
                .WithOptional(e => e.Unidade1)
                .HasForeignKey(e => e.UnidadPadreID);
        }
    }
}
