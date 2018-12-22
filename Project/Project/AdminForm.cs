using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            Hide();
            CreateNewStudent NewStudentForm = new CreateNewStudent();
            NewStudentForm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
