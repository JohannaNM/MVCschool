using Microsoft.EntityFrameworkCore;
using MVCschool.Models;

namespace MVCschool.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) 
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }  
        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>().HasData(
                new Class() { ClassId = 1, ClassName = "1A"},
                new Class() { ClassId = 2, ClassName = "2B"},
                new Class() { ClassId = 3, ClassName = "3C"}
                );

            modelBuilder.Entity<student>().HasData(
                new student() { StudentId = 1, SFirstName = "Alexander", SLastName = "Carson", ClassId = 1},
                new student() { StudentId = 2, SFirstName = "Meredith", SLastName = "Alonso", ClassId = 1 },
                new student() { StudentId = 3, SFirstName = "Arturo", SLastName = "Anand", ClassId = 1 },
                new student() { StudentId = 4, SFirstName = "Gytis", SLastName = "Barzdukas", ClassId = 1 },
                new student() { StudentId = 5, SFirstName = "Laura", SLastName = "Norman", ClassId = 1 },
                new student() { StudentId = 6, SFirstName = "Irving", SLastName = "Hills", ClassId = 1 },

                new student() { StudentId = 7, SFirstName = "Yan", SLastName = "Li", ClassId = 2 },
                new student() { StudentId = 8, SFirstName = "Peggy", SLastName = "Justice", ClassId = 2 },
                new student() { StudentId = 9, SFirstName = "Nino", SLastName = "Olivetto", ClassId = 2 },
                new student() { StudentId = 10, SFirstName = "Adam", SLastName = "Adams", ClassId = 2 },
                new student() { StudentId = 11, SFirstName = "Lilith", SLastName = "Baker", ClassId = 2 },
                new student() { StudentId = 12, SFirstName = "Frank", SLastName = "Evans", ClassId = 2 },
                
                new student() { StudentId = 13, SFirstName = "Lee", SLastName = "Xiang", ClassId = 3 },
                new student() { StudentId = 14, SFirstName = "Mannie", SLastName = "Quinn", ClassId = 3 },
                new student() { StudentId = 15, SFirstName = "Andrea", SLastName = "Lopez", ClassId = 3 },
                new student() { StudentId = 16, SFirstName = "Alexander", SLastName = "Smith", ClassId = 3 },
                new student() { StudentId = 17, SFirstName = "Walter", SLastName = "White", ClassId = 3 },
                new student() { StudentId = 18, SFirstName = "Jacob", SLastName = "Yakub", ClassId = 3 }
                );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher() { TeacherId = 1, TFirstName = "Find", TLastName = "Waldo" },
                new Teacher() { TeacherId = 2, TFirstName = "David", TLastName = "Toll" },
                new Teacher() { TeacherId = 3, TFirstName = "Anders", TLastName = "Ullström" },
                new Teacher() { TeacherId = 4, TFirstName = "Léon", TLastName = "Nahum" }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course() { CourseID = 1, Title = "Programing 1", TeacherId = 1},
                new Course() { CourseID = 2, Title = "Math 1", TeacherId = 2},
                new Course() { CourseID = 3, Title = "English", TeacherId = 3},
                new Course() { CourseID = 4, Title = "Music", TeacherId = 4},
                new Course() { CourseID = 5, Title = "programing 2", TeacherId = 1}
                );

            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment() { EnrollmentId = 1, StudentId = 1, CourseId = 1 },
                new Enrollment() { EnrollmentId = 2, StudentId = 2, CourseId = 1 },
                new Enrollment() { EnrollmentId = 3, StudentId = 3, CourseId = 1 },
                new Enrollment() { EnrollmentId = 4, StudentId = 4, CourseId = 1 },
                new Enrollment() { EnrollmentId = 5, StudentId = 5, CourseId = 1 },
                new Enrollment() { EnrollmentId = 6, StudentId = 6, CourseId = 1 },

                new Enrollment() { EnrollmentId = 7, StudentId = 7, CourseId = 2 },
                new Enrollment() { EnrollmentId = 8, StudentId = 8, CourseId = 2 },
                new Enrollment() { EnrollmentId = 9, StudentId = 9, CourseId = 2 },
                new Enrollment() { EnrollmentId = 10, StudentId = 10, CourseId = 2 },
                new Enrollment() { EnrollmentId = 11, StudentId = 11, CourseId = 2 },
                new Enrollment() { EnrollmentId = 12, StudentId = 12, CourseId = 2 },

                new Enrollment() { EnrollmentId = 13, StudentId = 13, CourseId = 3 },
                new Enrollment() { EnrollmentId = 14, StudentId = 14, CourseId = 3 },
                new Enrollment() { EnrollmentId = 15, StudentId = 15, CourseId = 3 },
                new Enrollment() { EnrollmentId = 16, StudentId = 16, CourseId = 3 },
                new Enrollment() { EnrollmentId = 17, StudentId = 17, CourseId = 3 },
                new Enrollment() { EnrollmentId = 18, StudentId = 18, CourseId = 3 },
               
                new Enrollment() { EnrollmentId = 19, StudentId = 1, CourseId = 4 },
                new Enrollment() { EnrollmentId = 20, StudentId = 2, CourseId = 4 },
                new Enrollment() { EnrollmentId = 21, StudentId = 3, CourseId = 4 },
                new Enrollment() { EnrollmentId = 22, StudentId = 4, CourseId = 4 },
                new Enrollment() { EnrollmentId = 23, StudentId = 5, CourseId = 4 },
                new Enrollment() { EnrollmentId = 24, StudentId = 6, CourseId = 4 },

                new Enrollment() { EnrollmentId = 25, StudentId = 7, CourseId = 5 },
                new Enrollment() { EnrollmentId = 26, StudentId = 8, CourseId = 5 },
                new Enrollment() { EnrollmentId = 27, StudentId = 9, CourseId = 5 },
                new Enrollment() { EnrollmentId = 28, StudentId = 10, CourseId = 5 },
                new Enrollment() { EnrollmentId = 29, StudentId = 11, CourseId = 5 },
                new Enrollment() { EnrollmentId = 30, StudentId = 12, CourseId = 5 },

                new Enrollment() { EnrollmentId = 31, StudentId = 13, CourseId = 2 },
                new Enrollment() { EnrollmentId = 32, StudentId = 14, CourseId = 2 },
                new Enrollment() { EnrollmentId = 33, StudentId = 15, CourseId = 2 },
                new Enrollment() { EnrollmentId = 34, StudentId = 16, CourseId = 2 },
                new Enrollment() { EnrollmentId = 35, StudentId = 17, CourseId = 2 },
                new Enrollment() { EnrollmentId = 36, StudentId = 18, CourseId = 2 }
                );
        }
    }


}
