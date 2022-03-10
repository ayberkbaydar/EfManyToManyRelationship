using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseFirst
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            GridView1.DataSource = (from student in employeeDBContext.Students
                                    from course in student.Courses
                                    select new
                                    {
                                        StudentName = student.StudentName,
                                        CourseName = course.CourseName
                                    }).ToList();
            GridView1.DataBind();
        }
    }
}