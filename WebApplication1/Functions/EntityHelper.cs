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
            return "Название курса: " + course.Title.ToString() + ". Количество часов: " + course.StudyCredits + ".";
        }

        public static string StudentInfo(this Student student)
        {
            return "Фамилия: " + student.LastName + ". Имя: " + student.FirstMidName + ".";
        }

        public static string EnrollmentInfo(this Enrollment enrollment)
        {
            return "Студент: " + enrollment.Student.LastName + ". Предмет: " + enrollment.Course.Title + ". Оценка: " + enrollment.Grade + "."; 
        }
    }
}
