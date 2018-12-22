
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;

namespace Project
{
    public partial class CreateNewStudent : Form
    {
        private string _facultie;
        private string _name;
        private string _surname ;
        public CreateNewStudent()
        {
            InitializeComponent();
            listBox1.Items.AddRange(Repository.GetFaculties());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _surname = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _name = textBox1.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _facultie = Repository.GetFaculties()[listBox1.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentManager.AddStudent(_name, _surname, _facultie);
        }
    }
}
