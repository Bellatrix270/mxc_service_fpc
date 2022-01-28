namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.ad_partners")]
    public partial class ad_partners
    {
        [Key]
        public int id_partners { get; set; }

        [Required]
        [StringLength(54)]
        public string fname { get; set; }

        [Required]
        [StringLength(54)]
        public string lname { get; set; }

        [StringLength(54)]
        public string patronymic { get; set; }

        public int platform { get; set; }

        public int amount_sub { get; set; }

        public int? views_for_month { get; set; }

        [Required]
        [StringLength(100)]
        public string account_ref { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string description { get; set; }
    }
}
