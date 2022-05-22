namespace Entities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Patient
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string IDNo { get; set; }

        public int GenderId { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public string ContactNo { get; set; }

        public string Doctor { get; set; }

        public DateTime AdmitDate { get; set; }

        public string WardNo { get; set; }

        public string Status { get; set; }
        public virtual Gender Gender { get; set; }

        [NotMapped]
        public string GenderName { get; set; }
    }
}
