namespace wpf_mzc_app.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("u1478686_mzc_service_fpc.employees_pays")]
    public partial class employees_pays
    {
        [Key]
        public int id_pay { get; set; }

        public int id_emp { get; set; }

        public int hours_worked { get; set; }

        public decimal amount_pay { get; set; }

        public decimal? bonus_pay { get; set; }

        public decimal tax { get; set; }

        public decimal total_pay { get; set; }

        public virtual employee employee { get; set; }
    }
}
