using Entities;
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
        public AdminForm(Admin admin)
        {
            InitializeComponent();
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            Show();
            CreateNewStudent s = new CreateNewStudent();
            s.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
