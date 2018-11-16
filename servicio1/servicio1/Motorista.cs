namespace servicio1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Motorista")]
    public partial class Motorista
    {
        [Key]
        public int iMotoristaid { get; set; }

        [Required]
        [StringLength(50)]
        public string vNombre { get; set; }

        [Required]
        [StringLength(50)]
        public string vApellido { get; set; }

        public DateTime dDNI { get; set; }

        [Required]
        [StringLength(40)]
        public string vDireccion { get; set; }

        [Required]
        [StringLength(40)]
        public string vTelefono { get; set; }
    }
}
