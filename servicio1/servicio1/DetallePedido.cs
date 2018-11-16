namespace servicio1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetallePedido")]
    public partial class DetallePedido
    {
        [Key]
        public int iDetallePedidoid { get; set; }

        public int iComboid { get; set; }

        public int iPedidoid { get; set; }

        public int iPlatoid { get; set; }

        public int iPrecioid { get; set; }
    }
}
