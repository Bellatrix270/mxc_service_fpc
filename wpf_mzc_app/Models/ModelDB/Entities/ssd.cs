namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.ssd")]
    public partial class ssd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ssd()
        {
            list_component = new HashSet<list_component>();
        }

        [Key]
        public int id_ssd { get; set; }

        [Required]
        [StringLength(100)]
        public string model { get; set; }

        [Column(TypeName = "year")]
        public short release_data { get; set; }

        public int capacity_mem { get; set; }

        public int id_con_interface { get; set; }

        public bool nvme { get; set; }

        public int? socket_m2 { get; set; }

        public int speed_write { get; set; }

        public int speed_read { get; set; }

        public int tbw { get; set; }

        [Required]
        [StringLength(100)]
        public string controller { get; set; }

        public virtual connection_interfaces connection_interfaces { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<list_component> list_component { get; set; }
    }
}
