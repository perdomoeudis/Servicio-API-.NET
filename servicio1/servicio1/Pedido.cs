namespace servicio1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedido")]
    public partial class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iPedido { get; set; }

        [Required]
        [StringLength(50)]
        public string vDireccion { get; set; }

        [Required]
        [StringLength(50)]
        public string vPersona { get; set; }

        [Required]
        [StringLength(40)]
        public string vTelefono { get; set; }

        public int iPrecio { get; set; }

        public DateTime dFechaPedido { get; set; }

        public DateTime dFechaEnvio { get; set; }

        public DateTime dHoraPedido { get; set; }

        public DateTime dHoraEntrega { get; set; }

        public int iMotorizadoid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int iEstado { get; set; }
    }
}
