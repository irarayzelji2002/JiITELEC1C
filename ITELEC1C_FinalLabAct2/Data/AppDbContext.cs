using ITELEC1C_FinalLabAct2.Models;
using Microsoft.EntityFrameworkCore;

namespace ITELEC1C_FinalLabAct2.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> StudentList { get; set; }
        public DbSet<Instructor> InstructorList { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    FirstName = "Gabriel",
                    LastName = "Montano",
                    Course = Course.BSIT,
                    AdmissionDate = DateTime.Parse("2022-08-26"),
                    GPA = 1.5,
                    Email = "ghaby021@gmail.com"
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Zyx",
                    LastName = "Montano",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2022-08-07"),
                    GPA = 1,
                    Email = "zyx@gmail.com"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Aerdriel",
                    LastName = "Montano",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2020-01-25"),
                    GPA = 1.5,
                    Email = "aerdriel@gmail.com"
                }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Spenser",
                    LastName = "Mangubat",
                    IsTenured = true,
                    Rank = Rank.Instructor,
                    HiringDate = DateTime.Parse("2022-09-30")
                },
                new Instructor()
                {
                    Id = 2,
                    FirstName = "Devon",
                    LastName = "Mangubat",
                    IsTenured = false,
                    Rank = Rank.AssistantProfessor,
                    HiringDate = DateTime.Parse("2022-05-15")
                },
                new Instructor()
                {
                    Id = 3,
                    FirstName = "Nicolas",
                    LastName = "Mangubat",
                    IsTenured = true,
                    Rank = Rank.AssociateProfessor,
                    HiringDate = DateTime.Parse("2022-03-30")
                },
                new Instructor()
                {
                    Id = 4,
                    FirstName = "Emerson",
                    LastName = "Mangubat",
                    IsTenured = false,
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("2022-11-10")
                }
            );
        }
    }
}
