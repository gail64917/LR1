using System;
using Xunit;
using LR1.Controllers;
using LR1.Data;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using LR1.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LR1.Functions;


namespace XUnitTest
{
    public class UnitTest
    {
        [Fact]
        public void StudentRepositoryExistsTest()
        {
            var result = Program.SuccesCode();
            var expect = 0;
            Assert.Equal(result, expect);
        }

        [Fact]
        public void CourseInfoTest()
        {
            var course = new Course { CourseID = 1, StudyCredits = 10, Title = "РСОИ" };
            var result = course.CourseInfo();
            var expect = "Название курса: РСОИ. Количество часов: 10.";
            Assert.Equal(result, expect);
        }

        [Fact]
        public void StudentInfoTest()
        {
            var student = new Student { ID=1, LastName="Новоженов", FirstMidName="Владимир"};
            var result = student.StudentInfo();
            var expect = "Фамилия: Новоженов. Имя: Владимир.";
            Assert.Equal(result, expect);
        }

        [Fact]
        public void EnrollmentInfoTest()
        {
            var course = new Course { CourseID = 1, StudyCredits = 10, Title = "РСОИ" };
            var student = new Student { ID = 1, LastName = "Новоженов", FirstMidName = "Владимир" };
            var enrollment = new Enrollment { Student = student, Course = course, Grade = Grade.Отлично };
            var result = enrollment.EnrollmentInfo();
            var expect = "Студент: Новоженов. Предмет: РСОИ. Оценка: Отлично.";
            Assert.Equal(result, expect);
        }
    }
}
