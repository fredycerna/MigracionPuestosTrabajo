namespace MigracionPuestosTrabajo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personal")]
    public partial class Personal
    {
        public int PersonalID { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Nombre { get; set; }

        public int? PuestoTrabajoID { get; set; }

        public virtual FotografiasPersonal FotografiasPersonal { get; set; }

        public virtual PuestosTrabajo PuestosTrabajo { get; set; }
    }
}
