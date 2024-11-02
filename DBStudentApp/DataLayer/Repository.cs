using Microsoft.VisualBasic.Devices;
using DBStudentApp_1191536.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBStudentApp_1191536.DataLayer
{
    internal class Repository:IRepository
    {
        IDataAccess _idac = new DataAccess();
        public List<Course> GetAllCourses()
        {
            List<Course> CList = new List<Course>();
            try
            {
                string sql = "select * from courses";
                DataTable dt = _idac.GetManyRowsCols(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    Course c = new Course();
                    c.CourseNum = (string)dr["CourseNum"];
                    c.CourseName = (string)dr["CourseName"];
                    CList.Add(c);
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return CList;
        }

        public List<Enrollment> GetEnrollments(string courseNum)
        {
            List<Enrollment> EList = new List<Enrollment>();
            try
            {
                string sql = "select s.StudentId,s.FirstName,s.LastName,c.Credits " +
                               "from Students s " +
                               "join enrollments e on s.StudentId=e.StudentId " +
                               "join courses c on e.coursenum=c.coursenum " +
                               "where c.CourseNum='" + courseNum + "'";
                DataTable dt = _idac.GetManyRowsCols(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    Enrollment e = new Enrollment();
                    e.StudentId = (int)dr["StudentId"];
                    e.FirstName = (string)dr["FirstName"];
                    e.LastName = (string)dr["LastName"];
                    e.Credits = (int)dr["Credits"];
                    EList.Add(e);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return EList;
        }
    }
}
