namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.hdd")]
    public partial class hdd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hdd()
        {
            list_component = new HashSet<list_component>();
        }

        [Key]
        public int id_hdd { get; set; }

        [Required]
        [StringLength(100)]
        public string model { get; set; }

        [Column(TypeName = "year")]
        public short release_data { get; set; }

        public int capacity_mem { get; set; }

        public int id_con_interface { get; set; }

        public int rotation_speed { get; set; }

        public int data_rate { get; set; }

        public virtual connection_interfaces connection_interfaces { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<list_component> list_component { get; set; }
    }
}
