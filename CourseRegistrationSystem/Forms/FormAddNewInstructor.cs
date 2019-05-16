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
    public partial class FormAddNewInstructor : Form
    {
        private Instructor instructor;

        public FormAddNewInstructor()
        {
            InitializeComponent();
        }

        private void buttonAddInstructor_Click(object sender, EventArgs e)
        {
            if (textBoxAddNewInstructorName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Enter the Instructor Name.");
            }
            else
            {
                instructor = new Instructor
                {
                    InstructorName = textBoxAddNewInstructorName.Text,
                };
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        public Instructor GetInstructor()
        {
            return instructor;
        }

    }
}
