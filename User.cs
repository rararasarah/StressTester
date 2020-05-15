namespace StresTester
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        [Column("Jenis Kelamin")]
        [Required]
        [StringLength(50)]
        public string Jenis_Kelamin { get; set; }

        [Required]
        [StringLength(100)]
        public string Umur { get; set; }
    }
}
