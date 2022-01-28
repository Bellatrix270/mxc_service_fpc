namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.motherboards")]
    public partial class motherboard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public motherboard()
        {
            list_component = new HashSet<list_component>();
        }

        [Key]
        public int id_motherboard { get; set; }

        [Required]
        [StringLength(100)]
        public string model { get; set; }

        public int id_form_factor { get; set; }

        public int id_socket { get; set; }

        public int id_type_ram { get; set; }

        public bool nvme { get; set; }

        [Required]
        [StringLength(30)]
        public string chipset { get; set; }

        public int power_phases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<list_component> list_component { get; set; }

        public virtual types_form_factor types_form_factor { get; set; }

        public virtual socket socket { get; set; }

        public virtual types_mem types_mem { get; set; }
    }
}
