namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.list_component")]
    public partial class list_component
    {
        [Key]
        public int id_component { get; set; }

        public int? id_case { get; set; }

        public int? id_hdd { get; set; }

        public int? id_motherboard { get; set; }

        public int? id_processor { get; set; }

        public int? id_psu { get; set; }

        public int? id_ram { get; set; }

        public int? id_ssd { get; set; }

        public int? id_videocard { get; set; }

        public virtual _case _case { get; set; }

        public virtual hdd hdd { get; set; }

        public virtual motherboard motherboard { get; set; }

        public virtual processor processor { get; set; }

        public virtual psu psu { get; set; }

        public virtual ram ram { get; set; }

        public virtual ssd ssd { get; set; }

        public virtual videocard videocard { get; set; }
    }
}
