using DBStudentApp_1191536.DataLayer;
using DBStudentApp_1191536.Models;

namespace DBStudentApp_1191536
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseNum = cmbCourses.SelectedValue.ToString();
            IRepository irep = new Repository();
            var EList = irep.GetEnrollments(courseNum);
            dg1.DataSource = EList;
            dg1.Refresh();


        }

        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IRepository irep = new Repository();
            List<Course> CList = irep.GetAllCourses();
            cmbCourses.DataSource = CList;
            cmbCourses.DisplayMember = "CourseNum";
            cmbCourses.ValueMember = "CourseNum";
            cmbCourses.Refresh();
        }
    }
}
