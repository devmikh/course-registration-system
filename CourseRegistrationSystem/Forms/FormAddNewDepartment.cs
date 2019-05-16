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

namespace CourseRegistrationSystem.Forms
{

    public partial class FormAddNewDepartment : Form
    {

        private Department department;

        public FormAddNewDepartment()
        {
            InitializeComponent();
        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            if (textBoxAddNewDepartmentCode.Text.Trim().Length == 0 ||
                textBoxAddNewDepartmentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Enter the Department Information.");
            }
            else
            {
                department = new Department
                {
                    DepartmentCode = textBoxAddNewDepartmentCode.Text,
                    DepartmentName = textBoxAddNewDepartmentName.Text
                };
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        public Department GetDepartment()
        {
            return department;
        }
    }
}
