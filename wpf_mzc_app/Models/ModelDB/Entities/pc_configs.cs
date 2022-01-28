namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.pc_configs")]
    public partial class pc_configs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pc_configs()
        {
            orders = new HashSet<order>();
        }

        [Key]
        public int id_pc_config { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public int? id_case { get; set; }

        public int id_cpu { get; set; }

        public int id_motherboard { get; set; }

        public int id_videocard { get; set; }

        public int id_ram { get; set; }

        public int? id_hdd { get; set; }

        public int? id_ssd { get; set; }

        public int id_psu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
    }
}
