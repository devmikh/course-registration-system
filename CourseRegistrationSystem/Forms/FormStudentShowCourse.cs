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
    public partial class FormStudentShowCourse : Form
    {

        private CourseRegistrationEntities context = new CourseRegistrationEntities();

        public FormStudentShowCourse(string deptCode, int courseNumber)
        {
            InitializeComponent();

            labelStudentShowCourseDeptDisplay.Text = deptCode;

            labelStudentShowCourseNumberDisplay.Text = courseNumber.ToString();

            context.Courses.Load();

            var selectedCourse = from course in context.Courses
                                     where course.DepartmentCode == deptCode && course.CourseNumber == courseNumber
                                     select course;

            labelStudentShowCourseTitleDisplay.Text = selectedCourse.First().CourseTitle;

            dataGridViewStudentShowCourseInstructors.DataSource = selectedCourse.First().Instructors.ToList();
            dataGridViewStudentShowCourseInstructors.Columns["Courses"].Visible = false;
            dataGridViewStudentShowCourseInstructors.Columns[0].Width = 60;
            dataGridViewStudentShowCourseInstructors.Columns[0].HeaderText = "ID";
            dataGridViewStudentShowCourseInstructors.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewStudentShowCourseInstructors.Columns[1].HeaderText = "Name";
            dataGridViewStudentShowCourseInstructors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudentShowCourseInstructors.ClearSelection();
        }

        private void buttonStudentShowCourseOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
