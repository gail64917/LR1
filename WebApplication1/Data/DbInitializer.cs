using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LR1.Models;

namespace LR1.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstMidName="Vladimir",LastName="Novozhenov",EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Student{FirstMidName="Alexander",LastName="Zhuravlev",EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Student{FirstMidName="Natalia",LastName="Komova",EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Student{FirstMidName="Vladislav",LastName="Porin",EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Programming",StudyCredits=36},
            new Course{CourseID=4022,Title="Operation Systems",StudyCredits=36},
            new Course{CourseID=4041,Title="Parallel programming",StudyCredits=36},
            new Course{CourseID=1045,Title="RSOI",StudyCredits=48},
            new Course{CourseID=3141,Title="Neural webs",StudyCredits=48},
            new Course{CourseID=2021,Title="Compillers",StudyCredits=36},
            new Course{CourseID=2042,Title="Philosophy",StudyCredits=48}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.Great},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.Good},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.Good},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.Good},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.Worse},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.Worse},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.Worse},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.Bad},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.Great},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
