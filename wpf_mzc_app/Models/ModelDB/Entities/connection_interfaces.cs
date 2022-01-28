namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.connection_interfaces")]
    public partial class connection_interfaces
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public connection_interfaces()
        {
            hdds = new HashSet<hdd>();
            ssds = new HashSet<ssd>();
        }

        [Key]
        public int id_con_interface { get; set; }

        [Required]
        [StringLength(30)]
        public string type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hdd> hdds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ssd> ssds { get; set; }
    }
}
