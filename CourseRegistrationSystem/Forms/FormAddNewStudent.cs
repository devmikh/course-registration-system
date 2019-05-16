using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseRegistrationSystem.EFClasses;

namespace CourseRegistrationSystem
{
    public partial class FormAddNewStudent : Form
    {
        private Student student;

        public FormAddNewStudent()
        {
            InitializeComponent();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (textBoxAddNewStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Enter the Student Name.");
            }
            else
            {
                student = new Student
                {
                    StudentName = textBoxAddNewStudentName.Text,
                };
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        public Student GetStudent()
        {
            return student;
        }
    }
}
