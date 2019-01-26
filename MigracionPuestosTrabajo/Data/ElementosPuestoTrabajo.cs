namespace MigracionPuestosTrabajo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElementosPuestoTrabajo")]
    public partial class ElementosPuestoTrabajo
    {
        [Key]
        public int ElementoID { get; set; }

        public string Description { get; set; }

        public bool Escencial { get; set; }

        public int PuestoTrabajoId { get; set; }

        public int SubCategoriaId { get; set; }

        public virtual PuestosTrabajo PuestosTrabajo { get; set; }

        public virtual SubCategoria SubCategoria { get; set; }
    }
}
