namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.vendors")]
    public partial class vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vendor()
        {
            supplies = new HashSet<supply>();
        }

        [Key]
        public int id_vendor { get; set; }

        [Required]
        [StringLength(100)]
        public string name_company { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_reg { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_end { get; set; }

        public bool confirm { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<supply> supplies { get; set; }
    }
}
