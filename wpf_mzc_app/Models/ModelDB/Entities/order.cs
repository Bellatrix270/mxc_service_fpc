namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.orders")]
    public partial class order
    {
        [Key]
        public int id_order { get; set; }

        public int id_client { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime date_reg { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_finish { get; set; }

        public int difficult { get; set; }

        public int id_service { get; set; }

        public int? id_pc_config { get; set; }

        public int id_delivery { get; set; }

        public decimal price { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string description { get; set; }

        public virtual client client { get; set; }

        public virtual pc_configs pc_configs { get; set; }

        public virtual service service { get; set; }

        public virtual type_deliveries type_deliveries { get; set; }
    }
}
