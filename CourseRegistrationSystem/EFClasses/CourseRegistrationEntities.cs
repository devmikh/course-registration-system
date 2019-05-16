namespace CourseRegistrationSystem.EFClasses
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Validation;

    public partial class CourseRegistrationEntities : DbContext
    {
        public CourseRegistrationEntities()
            : base("name=CourseRegistrationConnection")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.Courses)
                .WithMany(e => e.Instructors)
                .Map(m => m.ToTable("InstructorCourse").MapLeftKey("InstructorId").MapRightKey(new[] { "DepartmentCode", "CourseNumber" }));

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Courses)
                .WithMany(e => e.Students)
                .Map(m => m.ToTable("StudentCourse").MapLeftKey("StudentId").MapRightKey(new[] { "DepartmentCode", "CourseNumber" }));
        }

        
    }
}
