namespace MigracionPuestosTrabajo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PuestosTrabajo")]
    public partial class PuestosTrabajo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PuestosTrabajo()
        {
            ElementosPuestoTrabajoes = new HashSet<ElementosPuestoTrabajo>();
            PasosProcedimientoes = new HashSet<PasosProcedimiento>();
            Personals = new HashSet<Personal>();
            PuestosTrabajo1 = new HashSet<PuestosTrabajo>();
            Unidades = new HashSet<Unidade>();
        }

        [Key]
        public int PuestoTrabajoID { get; set; }

        public bool? Activo { get; set; }

        public bool Aprobado { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaCreacion { get; set; }

        public int? JefeInmediatoID { get; set; }

        [Required]
        public string Objetivo { get; set; }

        public int? TipoPuestoID { get; set; }

        [Required]
        public string Titulo { get; set; }

        public int UnidadID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElementosPuestoTrabajo> ElementosPuestoTrabajoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PasosProcedimiento> PasosProcedimientoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personal> Personals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PuestosTrabajo> PuestosTrabajo1 { get; set; }

        public virtual PuestosTrabajo PuestosTrabajo2 { get; set; }

        public virtual TiposPuesto TiposPuesto { get; set; }

        public virtual Unidade Unidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Unidade> Unidades { get; set; }
    }
}
