using System;
using System.Windows.Forms;

namespace Project
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {

        }

        private void TeacherButton_Click(object sender, EventArgs e)
        {
            Hide();
            TeacherForm form = new TeacherForm();
            form.Show();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            Hide();
            Entities.Student actualStudent = new Entities.Student();
            actualStudent.Name = "andrei";
            actualStudent.Surname = "lukashevich";
            actualStudent.Sex = "female";
            actualStudent.Scholarship = 120.43;
            StudentForm student = new StudentForm(actualStudent);
            
            student.Show();
        }

        private void AdminButton_Click_1(object sender, EventArgs e)
        {
            Hide();
            Entities.Admin actualAdmin = new Entities.Admin();
            actualAdmin.Name = "veron";
            actualAdmin.Surname = "makovik";
            actualAdmin.Sex = "female";
            //actualStudent.Scholarship = 120.43;
            AdminForm student = new AdminForm();

            student.Show();
        }
    }
}
