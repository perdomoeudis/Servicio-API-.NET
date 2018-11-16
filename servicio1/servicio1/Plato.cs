namespace servicio1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Plato")]
    public partial class Plato
    {
        [Key]
        public int iPlatoid { get; set; }

        [Required]
        [StringLength(50)]
        public string vNombre { get; set; }

        [Required]
        [StringLength(50)]
        public string vDescripcion { get; set; }

        [Required]
        [StringLength(40)]
        public string vImagen { get; set; }

        [StringLength(10)]
        public string iPrecio { get; set; }
    }
}
