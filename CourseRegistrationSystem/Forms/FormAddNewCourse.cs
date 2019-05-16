using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseRegistrationSystem.EFClasses;


namespace CourseRegistrationSystem.Forms
{
    public partial class FormAddNewCourse : Form
    {
        private string deptCode;
        private int courseNumber;
        private string courseTitle;
        private List<int> selectedInstructorIds;

        private CourseRegistrationEntities context = new CourseRegistrationEntities();

        public FormAddNewCourse()
        {
            InitializeComponent();

            context.Departments.Load();
            listBoxAddNewCourseDepartment.DataSource = context.Departments.Select(x => x.DepartmentCode).ToList();

            context.Instructors.Load();
            dataGridViewAddNewCourseInstructor.DataSource = context.Instructors.Local.ToBindingList();
            dataGridViewAddNewCourseInstructor.Columns["Courses"].Visible = false;
            dataGridViewAddNewCourseInstructor.Columns[0].Width = 40;
            dataGridViewAddNewCourseInstructor.Columns[0].HeaderText = "ID";
            dataGridViewAddNewCourseInstructor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAddNewCourseInstructor.Columns[1].HeaderText = "Name";
            dataGridViewAddNewCourseInstructor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            // Retrieve the selected Instructor IDs
            selectedInstructorIds = new List<int>();

            Int32 selectedRowCount = dataGridViewAddNewCourseInstructor.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < dataGridViewAddNewCourseInstructor.Rows.Count; i++)
                {
                    if (dataGridViewAddNewCourseInstructor.Rows[i].Selected == true)
                    {
                        selectedInstructorIds.Add(Int32.Parse(dataGridViewAddNewCourseInstructor.Rows[i].Cells[0].Value.ToString()));
                    }
                    
                }
            }

            // If all fields are filled, retrieve course information and close the window
            if (listBoxAddNewCourseDepartment.SelectedItems.Count == 0 ||
                textBoxAddNewCourseNumber.Text.Trim().Length == 0 ||
                textBoxAddNewCourseTitle.Text.Trim().Length == 0)
            {
                MessageBox.Show("Course information is missing.");
            }
            else
            {
                deptCode = listBoxAddNewCourseDepartment.SelectedItem.ToString();
                courseNumber = Int32.Parse(textBoxAddNewCourseNumber.Text);
                courseTitle = textBoxAddNewCourseTitle.Text;

                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        public string getDeptCode()
        {
            return deptCode;
        }

        public int getCourseNumber()
        {
            return courseNumber;
        }

        public string getCourseTitle()
        {
            return courseTitle;
        }

        public List<int> getInstructorIds()
        {
            return selectedInstructorIds;
        }
    }
}
