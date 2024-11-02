using Microsoft.VisualBasic.Devices;
using DBStudentApp_1191536.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStudentApp_1191536.DataLayer
{
    internal interface IRepository
    {
        List<Course> GetAllCourses();
        List<Enrollment> GetEnrollments(string courseNum);
    }
}
