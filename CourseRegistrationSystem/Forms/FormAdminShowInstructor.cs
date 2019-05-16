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
    public partial class FormAdminShowInstructor : Form
    {
        private int instructorId;

        private Instructor selectedInstructor;

        private CourseRegistrationEntities context = new CourseRegistrationEntities();

        private List<Course> selectedCourses;

        public FormAdminShowInstructor(int instructorId)
        {
            InitializeComponent();

            this.instructorId = instructorId;

            labelAdminShowInstructorIdDisplay.Text = instructorId.ToString();

            //context.Instructors.Load();

            var selectInstructorQuery = from instructor in context.Instructors
                                  where instructor.InstructorId == instructorId
                                  select instructor;

            selectedInstructor = selectInstructorQuery.First();

            labelAdminShowInstructorNameDisplay.Text = selectedInstructor.InstructorName;

            dataGridViewAdminShowInstructorCourses.DataSource = selectedInstructor.Courses.ToList();
            dataGridViewAdminShowInstructorCourses.Columns["Department"].Visible = false;
            dataGridViewAdminShowInstructorCourses.Columns["Instructors"].Visible = false;
            dataGridViewAdminShowInstructorCourses.Columns["Students"].Visible = false;
            dataGridViewAdminShowInstructorCourses.Columns[0].Width = 60;
            dataGridViewAdminShowInstructorCourses.Columns[0].HeaderText = "Dept. Code";
            dataGridViewAdminShowInstructorCourses.Columns[1].Width = 60;
            dataGridViewAdminShowInstructorCourses.Columns[1].HeaderText = "Number";
            dataGridViewAdminShowInstructorCourses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAdminShowInstructorCourses.Columns[2].HeaderText = "Title";
            dataGridViewAdminShowInstructorCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdminShowInstructorCourses.ClearSelection();
        }

        private void buttonAdminShowInstructorOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
