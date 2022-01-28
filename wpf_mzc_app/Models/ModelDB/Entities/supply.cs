namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.supplies")]
    public partial class supply
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public supply()
        {
            supplies_equipment_date = new HashSet<supplies_equipment_date>();
        }

        [Key]
        public int id_supplies { get; set; }

        public int id_vendor { get; set; }

        public DateTime data { get; set; }

        public bool is_received { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<supplies_equipment_date> supplies_equipment_date { get; set; }

        public virtual vendor vendor { get; set; }
    }
}
