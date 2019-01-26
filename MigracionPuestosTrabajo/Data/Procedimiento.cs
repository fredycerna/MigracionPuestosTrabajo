namespace MigracionPuestosTrabajo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Procedimientos")]
    public partial class Procedimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Procedimiento()
        {
            PasosProcedimientoes = new HashSet<PasosProcedimiento>();
            Unidades = new HashSet<Unidade>();
        }

        public int ProcedimientoID { get; set; }

        public bool? Activo { get; set; }

        public bool Aprobado { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string ObjetivoInicial { get; set; }

        [Required]
        public string ObjetvioFinal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PasosProcedimiento> PasosProcedimientoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Unidade> Unidades { get; set; }
    }
}
