namespace servicio1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComboPlato")]
    public partial class ComboPlato
    {
        [Key]
        public int iComboPlatoid { get; set; }

        public int iPlatoid { get; set; }

        public int iComboid { get; set; }

        public int iPrecioid { get; set; }
    }
}
