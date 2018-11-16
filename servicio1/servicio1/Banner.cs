namespace servicio1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Banner")]
    public partial class Banner
    {
        [Key]
        public int iBannerid { get; set; }

        [Required]
        [StringLength(50)]
        public string vNombre { get; set; }

        public int iImg { get; set; }

        public int iEstado { get; set; }
    }
}
