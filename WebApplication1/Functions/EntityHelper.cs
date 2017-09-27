using LR1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LR1.Functions
{
    public static class EntityHelper
    {
        public static string CourseInfo(this Course course)
        {
            return "Course name: " + course.Title.ToString() + ". Amount of hours: " + course.StudyCredits + ".";
        }

        public static string StudentInfo(this Student student)
        {
            return "Surname: " + student.LastName + ". Name: " + student.FirstMidName + ".";
        }

        public static string EnrollmentInfo(this Enrollment enrollment)
        {
            return "Student: " + enrollment.Student.LastName + ". Subject: " + enrollment.Course.Title + ". Mark: " + enrollment.Grade + "."; 
        }
    }
}
