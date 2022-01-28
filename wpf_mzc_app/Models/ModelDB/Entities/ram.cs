namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.ram")]
    public partial class ram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ram()
        {
            list_component = new HashSet<list_component>();
        }

        [Key]
        public int id_ram { get; set; }

        [Required]
        [StringLength(100)]
        public string model { get; set; }

        public int id_type_mem { get; set; }

        public int capacity_mem { get; set; }

        public int frequence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<list_component> list_component { get; set; }

        public virtual types_mem types_mem { get; set; }
    }
}
