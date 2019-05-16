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
    public partial class FormAdminShowCourse : Form
    {

        private CourseRegistrationEntities context = new CourseRegistrationEntities();

        public FormAdminShowCourse(string deptCode, int courseNumber)
        {
            InitializeComponent();

            labelAdminShowCourseDeptDisplay.Text = deptCode;

            labelAdminShowCourseNumberDisplay.Text = courseNumber.ToString();

            context.Courses.Load();

            var selectedCourse = from course in context.Courses
                                 where course.DepartmentCode == deptCode && course.CourseNumber == courseNumber
                                 select course;

            labelAdminShowCourseTitleDisplay.Text = selectedCourse.First().CourseTitle;

            dataGridViewAdminShowCourseInstructors.DataSource = selectedCourse.First().Instructors.ToList();
            dataGridViewAdminShowCourseInstructors.Columns["Courses"].Visible = false;
            dataGridViewAdminShowCourseInstructors.Columns[0].Width = 60;
            dataGridViewAdminShowCourseInstructors.Columns[0].HeaderText = "ID";
            dataGridViewAdminShowCourseInstructors.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAdminShowCourseInstructors.Columns[1].HeaderText = "Name";
            dataGridViewAdminShowCourseInstructors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdminShowCourseInstructors.ClearSelection();

            dataGridViewAdminShowCourseStudents.DataSource = selectedCourse.First().Students.ToList();
            dataGridViewAdminShowCourseStudents.Columns["Courses"].Visible = false;
            dataGridViewAdminShowCourseStudents.Columns[0].Width = 60;
            dataGridViewAdminShowCourseStudents.Columns[0].HeaderText = "ID";
            dataGridViewAdminShowCourseStudents.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAdminShowCourseStudents.Columns[1].HeaderText = "Name";
            dataGridViewAdminShowCourseStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdminShowCourseStudents.ClearSelection();
        }

        private void buttonAdminShowCourseOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
