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
            StudentForm student = new StudentForm(Entities.Student.GetSetupStudent());            
            student.Show();
        }

        private void AdminButton_Click_1(object sender, EventArgs e)
        {
            Hide();
            AdminForm student = new AdminForm(Entities.Admin.GetSetUpAdmit());
            student.Show();
        }
    }
}
