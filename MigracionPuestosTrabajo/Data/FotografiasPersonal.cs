namespace MigracionPuestosTrabajo.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FotografiasPersonal")]
    public partial class FotografiasPersonal
    {
        [Key]
        public int PersonalID { get; set; }

        [Required]
        public byte[] Foto { get; set; }

        public virtual Personal Personal { get; set; }
    }
}
