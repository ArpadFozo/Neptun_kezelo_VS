namespace zhgyak2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Courses")
        {
        }

        public virtual DbSet<course> course { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<course>()
                .Property(e => e.courseId)
                .HasPrecision(3, 0);

            modelBuilder.Entity<course>()
                .Property(e => e.courseShortName)
                .IsUnicode(false);

            modelBuilder.Entity<course>()
                .Property(e => e.courseLongName)
                .IsUnicode(false);
        }
    }
}
