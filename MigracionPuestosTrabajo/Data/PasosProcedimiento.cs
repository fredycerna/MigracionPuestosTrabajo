namespace MigracionPuestosTrabajo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PasosProcedimiento")]
    public partial class PasosProcedimiento
    {
        [Key]
        public int PasoProcedimientoID { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public int Numero { get; set; }

        [Required]
        public string Predecesores { get; set; }

        public int ProcedimientoID { get; set; }

        public int? PuestoTrabajoID { get; set; }

        public int? TipoPasoID { get; set; }

        public virtual Procedimiento Procedimiento { get; set; }

        public virtual PuestosTrabajo PuestosTrabajo { get; set; }

        public virtual TiposPaso TiposPaso { get; set; }
    }
}
