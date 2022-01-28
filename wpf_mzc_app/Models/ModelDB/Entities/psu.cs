namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.psu")]
    public partial class psu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public psu()
        {
            list_component = new HashSet<list_component>();
        }

        [Key]
        public int id_psu { get; set; }

        [Required]
        [StringLength(255)]
        public string model { get; set; }

        public int id_form_factor { get; set; }

        public int? certificate { get; set; }

        public int power { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<list_component> list_component { get; set; }

        public virtual types_form_factor types_form_factor { get; set; }
    }
}
