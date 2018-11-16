namespace servicio1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Combo")]
    public partial class Combo
    {
        [Key]
        public int iComboid { get; set; }

        [Required]
        [StringLength(50)]
        public string vNombre { get; set; }

        [Required]
        [StringLength(50)]
        public string vDescripcion { get; set; }

        [Required]
        [StringLength(40)]
        public string vImagen { get; set; }

        public int iPrecio { get; set; }
    }
}
