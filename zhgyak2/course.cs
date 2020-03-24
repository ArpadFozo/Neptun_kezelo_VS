namespace zhgyak2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("course")]
    public partial class course
    {
        [Column(TypeName = "numeric")]
        public decimal courseId { get; set; }

        [StringLength(200)]
        public string courseShortName { get; set; }

        [StringLength(200)]
        public string courseLongName { get; set; }

        public int credit { get; set; }
    }
}
