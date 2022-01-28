using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace wpf_mzc_app.Models.ModelDB
{
    public partial class MZCServicePC : DbContext
    {
        public MZCServicePC()
            : base("name=MZCServicePC")
        {
            Database.SetInitializer<MZCServicePC>(null);
        }

        public virtual DbSet<ad_partners> ad_partners { get; set; }
        public virtual DbSet<_case> cases { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<connection_interfaces> connection_interfaces { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<employees_pays> employees_pays { get; set; }
        public virtual DbSet<hdd> hdds { get; set; }
        public virtual DbSet<list_component> list_component { get; set; }
        public virtual DbSet<motherboard> motherboards { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<pc_configs> pc_configs { get; set; }
        public virtual DbSet<processor> processors { get; set; }
        public virtual DbSet<psu> psus { get; set; }
        public virtual DbSet<ram> rams { get; set; }
        public virtual DbSet<service> services { get; set; }
        public virtual DbSet<socket> sockets { get; set; }
        public virtual DbSet<ssd> ssds { get; set; }
        public virtual DbSet<stored_components> stored_components { get; set; }
        public virtual DbSet<supply> supplies { get; set; }
        public virtual DbSet<supplies_equipment_date> supplies_equipment_date { get; set; }
        public virtual DbSet<type_deliveries> type_deliveries { get; set; }
        public virtual DbSet<types_form_factor> types_form_factor { get; set; }
        public virtual DbSet<types_mem> types_mem { get; set; }
        public virtual DbSet<vendor> vendors { get; set; }
        public virtual DbSet<videocard> videocards { get; set; }
        public virtual DbSet<warehouse> warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ad_partners>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<ad_partners>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<ad_partners>()
                .Property(e => e.patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<ad_partners>()
                .Property(e => e.account_ref)
                .IsUnicode(false);

            modelBuilder.Entity<ad_partners>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<_case>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<connection_interfaces>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<connection_interfaces>()
                .HasMany(e => e.hdds)
                .WithRequired(e => e.connection_interfaces)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<connection_interfaces>()
                .HasMany(e => e.ssds)
                .WithRequired(e => e.connection_interfaces)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.photo_ref)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .HasMany(e => e.employees_pays)
                .WithRequired(e => e.employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<hdd>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<motherboard>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<motherboard>()
                .Property(e => e.chipset)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<pc_configs>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<processor>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<processor>()
                .HasMany(e => e.list_component)
                .WithOptional(e => e.processor)
                .HasForeignKey(e => e.id_processor);

            modelBuilder.Entity<psu>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<ram>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<service>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<service>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<service>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<socket>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<socket>()
                .HasMany(e => e.motherboards)
                .WithRequired(e => e.socket)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<socket>()
                .HasMany(e => e.processors)
                .WithRequired(e => e.socket)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ssd>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<ssd>()
                .Property(e => e.controller)
                .IsUnicode(false);

            modelBuilder.Entity<supply>()
                .HasMany(e => e.supplies_equipment_date)
                .WithRequired(e => e.supply)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<type_deliveries>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<type_deliveries>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<type_deliveries>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.type_deliveries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<types_form_factor>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<types_form_factor>()
                .HasMany(e => e.cases)
                .WithRequired(e => e.types_form_factor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<types_form_factor>()
                .HasMany(e => e.motherboards)
                .WithRequired(e => e.types_form_factor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<types_form_factor>()
                .HasMany(e => e.psus)
                .WithRequired(e => e.types_form_factor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<types_mem>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<types_mem>()
                .HasMany(e => e.motherboards)
                .WithRequired(e => e.types_mem)
                .HasForeignKey(e => e.id_type_ram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<types_mem>()
                .HasMany(e => e.processors)
                .WithRequired(e => e.types_mem)
                .HasForeignKey(e => e.id_supported_RAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<types_mem>()
                .HasMany(e => e.rams)
                .WithRequired(e => e.types_mem)
                .HasForeignKey(e => e.id_type_mem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<types_mem>()
                .HasMany(e => e.videocards)
                .WithRequired(e => e.types_mem)
                .HasForeignKey(e => e.id_type_mem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.name_company)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .HasMany(e => e.supplies)
                .WithRequired(e => e.vendor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<videocard>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<warehouse>()
                .HasMany(e => e.stored_components)
                .WithRequired(e => e.warehouse)
                .HasForeignKey(e => e.id_warehouses)
                .WillCascadeOnDelete(false);
            
        }
    }
}
