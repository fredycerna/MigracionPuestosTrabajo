namespace MigracionPuestosTrabajo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Competencia
    {
        public int CompetenciaID { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public int SubCategoriaId { get; set; }

        public virtual SubCategoria SubCategoria { get; set; }
    }
}
