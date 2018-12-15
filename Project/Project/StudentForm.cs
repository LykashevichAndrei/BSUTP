using System;
using System.Windows.Forms;
using Entities;

namespace Project
{
    public partial class StudentForm : Form
    {
        public StudentForm(Student student)
        {
            InitializeComponent();
            NameLabel.Text = student.Name + " " + student.Surname;
            StatusLabel.Text = student.Status;
            FacultyLabel.Text = student.Faculty;
            SpecialityLabel.Text = student.Speciality;
            YearLabel.Text = student.Year.ToString();
            GroupLabel.Text = student.Group.ToString();
            

            if (student.Privileges == true) PrivilegesLabel.Text = "Есть";
            else PrivilegesLabel.Text = "Нет";

            if (student.LiveInSocialBehavior == true) LiveInSBLabel.Text = "Есть";
            else LiveInSBLabel.Text = "Нет";

            if (student.InBudget == true) BudgetLabel.Text = "Да";
            else BudgetLabel.Text = "Нет";
            ///private double _averageBall;
            ///private double _scholarship;
            ///List<int> marks;
        }

        private void NameLabelText_Click(object sender, EventArgs e)
        {

        }
        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
        private void StatusLabelText_Click(object sender, EventArgs e)
        {

        }
        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }
        private void FacultyLabelText_Click(object sender, EventArgs e)
        {

        }
        private void FacultyLabel_Click(object sender, EventArgs e)
        {

        }
        private void SpecialityLabelText_Click(object sender, EventArgs e)
        {

        }
        private void SpecialityLabel_Click(object sender, EventArgs e)
        {

        }
        private void YearLabelText_Click(object sender, EventArgs e)
        {

        }
        private void YearLabel_Click(object sender, EventArgs e)
        {

        }
        private void GroupLabelText_Click(object sender, EventArgs e)
        {

        }
        private void GroupLabel_Click(object sender, EventArgs e)
        {

        }
        private void PrivilegesLabelText_Click(object sender, EventArgs e)
        {

        }
        private void PrivilegesLabel_Click(object sender, EventArgs e)
        {

        }
        private void LiveInSBLabelText_Click(object sender, EventArgs e)
        {

        }
        private void LiveInSBLabel_Click(object sender, EventArgs e)
        {

        }
        private void BudgetLabelText_Click(object sender, EventArgs e)
        {

        }
        private void BudgetLabel_Click(object sender, EventArgs e)
        {

        }
        private void AverageBallLabelText_Click(object sender, EventArgs e)
        {

        }
        private void AverageBallLabel_Click(object sender, EventArgs e)
        {

        }
        private void ScholarshipLabelText_Click(object sender, EventArgs e)
        {

        }
    }
}
