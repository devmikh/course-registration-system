using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using CourseRegistrationSystem.EFClasses;

namespace CourseRegistrationSystem.Forms
{
    public partial class FormAdminShowDepartment : Form
    {

        private CourseRegistrationEntities context = new CourseRegistrationEntities();

        public FormAdminShowDepartment(string departmentCode)
        {
            InitializeComponent();

            labelAdminShowDepartmentCodeDisplay.Text = departmentCode;

            context.Departments.Load();

            var selectedDepartment = from department in context.Departments
                                     where department.DepartmentCode == departmentCode
                                     select department;

            labelAdminShowDepartmentNameDisplay.Text = selectedDepartment.First().DepartmentName;

            dataGridViewAdminShowDepartmentCourses.DataSource = selectedDepartment.First().Courses.ToList();
            dataGridViewAdminShowDepartmentCourses.Columns["Department"].Visible = false;
            dataGridViewAdminShowDepartmentCourses.Columns["Instructors"].Visible = false;
            dataGridViewAdminShowDepartmentCourses.Columns["Students"].Visible = false;
            dataGridViewAdminShowDepartmentCourses.Columns[0].Width = 60;
            dataGridViewAdminShowDepartmentCourses.Columns[0].HeaderText = "Dept. Code";
            dataGridViewAdminShowDepartmentCourses.Columns[1].Width = 60;
            dataGridViewAdminShowDepartmentCourses.Columns[1].HeaderText = "Number";
            dataGridViewAdminShowDepartmentCourses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAdminShowDepartmentCourses.Columns[2].HeaderText = "Title";
            dataGridViewAdminShowDepartmentCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdminShowDepartmentCourses.ClearSelection();
        }

        private void buttonAdminShowDepartmentOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
