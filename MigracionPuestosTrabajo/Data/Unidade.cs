namespace MigracionPuestosTrabajo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Unidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unidade()
        {
            FuncionesUnidads = new HashSet<FuncionesUnidad>();
            PuestosTrabajoes = new HashSet<PuestosTrabajo>();
            Unidades1 = new HashSet<Unidade>();
            Procedimientos = new HashSet<Procedimiento>();
        }

        [Key]
        public int UnidadID { get; set; }

        public bool? Activa { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Objetivo { get; set; }

        public int? PuestoResponsableID { get; set; }

        public int? UnidadPadreID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuncionesUnidad> FuncionesUnidads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PuestosTrabajo> PuestosTrabajoes { get; set; }

        public virtual PuestosTrabajo PuestosTrabajo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Unidade> Unidades1 { get; set; }

        public virtual Unidade Unidade1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Procedimiento> Procedimientos { get; set; }
    }
}
