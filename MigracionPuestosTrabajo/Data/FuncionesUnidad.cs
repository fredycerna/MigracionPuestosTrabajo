namespace MigracionPuestosTrabajo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FuncionesUnidad")]
    public partial class FuncionesUnidad
    {
        [Key]
        public int FuncionUnidadID { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public int? UnidadID { get; set; }

        public virtual Unidade Unidade { get; set; }
    }
}
