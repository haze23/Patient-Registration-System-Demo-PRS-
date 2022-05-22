namespace Entities.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PRSContext : DbContext
    {
        public PRSContext()
            : base("name=PRSContext")
        {
        }

        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
