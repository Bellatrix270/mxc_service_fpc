namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.warehouses")]
    public partial class warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public warehouse()
        {
            stored_components = new HashSet<stored_components>();
        }

        [Key]
        public int id_warehouse { get; set; }

        [Required]
        [StringLength(255)]
        public string address { get; set; }

        public int occupied { get; set; }

        public int capacity { get; set; }

        public float per_of_fill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stored_components> stored_components { get; set; }
    }
}
