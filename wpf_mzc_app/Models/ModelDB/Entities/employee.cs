namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.employees")]
    public partial class employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee()
        {
            employees_pays = new HashSet<employees_pays>();
        }

        [Key]
        public int id_emp { get; set; }

        [Required]
        [StringLength(54)]
        public string fname { get; set; }

        [Required]
        [StringLength(54)]
        public string lname { get; set; }

        [Required]
        [StringLength(54)]
        public string patronymic { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(36)]
        public string password { get; set; }

        public Post post { get; set; }

        public int? experience { get; set; }
        
        [Column(TypeName="bigint")]
        public long payment_card_number { get; set; }

        [StringLength(255)]
        public string photo_ref { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employees_pays> employees_pays { get; set; }
    }
}
