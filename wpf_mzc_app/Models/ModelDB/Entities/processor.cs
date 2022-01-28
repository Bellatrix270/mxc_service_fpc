namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.processors")]
    public partial class processor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public processor()
        {
            list_component = new HashSet<list_component>();
        }

        [Key]
        public int id_cpu { get; set; }

        [Required]
        [StringLength(100)]
        public string model { get; set; }

        [Column(TypeName = "year")]
        public short release_data { get; set; }

        public int id_socket { get; set; }

        public int cores_amount { get; set; }

        public int thread_amount { get; set; }

        public int frequency { get; set; }

        public int id_supported_RAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<list_component> list_component { get; set; }

        public virtual socket socket { get; set; }

        public virtual types_mem types_mem { get; set; }
    }
}
