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

namespace CourseRegistrationSystem
{
    public partial class FormAdminShowStudent : Form
    {

        private CourseRegistrationEntities context = new CourseRegistrationEntities();

        public FormAdminShowStudent(int studentId)
        {
            InitializeComponent();

            labelAdminShowStudentIdDisplay.Text = studentId.ToString();

            context.Students.Load();

            var selectedStudent = from student in context.Students
                                  where student.StudentId == studentId
                                  select student;
            

            labelAdminShowStudentNameDisplay.Text = selectedStudent.First().StudentName;

            dataGridViewAdminShowStudentCourses.DataSource = selectedStudent.First().Courses.ToList();
            dataGridViewAdminShowStudentCourses.Columns["Department"].Visible = false;
            dataGridViewAdminShowStudentCourses.Columns["Instructors"].Visible = false;
            dataGridViewAdminShowStudentCourses.Columns["Students"].Visible = false;
            dataGridViewAdminShowStudentCourses.Columns[0].Width = 60;
            dataGridViewAdminShowStudentCourses.Columns[0].HeaderText = "Dept. Code";
            dataGridViewAdminShowStudentCourses.Columns[1].Width = 60;
            dataGridViewAdminShowStudentCourses.Columns[1].HeaderText = "Number";
            dataGridViewAdminShowStudentCourses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAdminShowStudentCourses.Columns[2].HeaderText = "Title";
            dataGridViewAdminShowStudentCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdminShowStudentCourses.ClearSelection();

        }

        private void buttonAdminShowStudentOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        
    }
}
