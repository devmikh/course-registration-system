using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Entity;
using CourseRegistrationSystem.EFClasses;
using CourseRegistrationSystem.Forms;

namespace CourseRegistrationSystem
{
    
    public partial class MainForm : Form
    {
        int currentStudentId = 0;
        int currentInstructorId = 0;
        //Instructor currentInstructor = null;
        private CourseRegistrationEntities context;
        public MainForm()
        {
            InitializeComponent();

            context = new CourseRegistrationEntities();

            context.Database.Log = s => Debug.Write(s);
            context.SaveChanges();

            context.Database.Delete();
            context.Database.Create();
        }

        /// <summary>
        /// Add data to the database.
        /// Initialize all DataGridViews and add data to them
        /// </summary>
        public void InitializeApplication()
        {
            // Add data to the database
            DBSeed.Seed();
            context.Students.Load();
            context.Departments.Load();
            context.Instructors.Load();
            context.Courses.Load();
            
            InitializeDeptListBox(listBoxStudentDepartment);
            InitializeDeptListBox(listBoxInstructorDepartment);

            PopulateDataGridViewAllCourses(dataGridViewStudentAllCourses, listBoxStudentDepartment);
            PopulateDataGridViewAllCourses(dataGridViewInstructorAllCourses, listBoxInstructorDepartment);

            listBoxStudentDepartment.SelectedIndexChanged += ListBoxStudentDepartment_SelectedIndexChanged;
            listBoxInstructorDepartment.SelectedIndexChanged += ListBoxInstructorDepartment_SelectedIndexChanged;

            InitializeAdminTab();

            context.SaveChanges();

        }

        /// <summary>
        /// Populate DataGridViews on Student and Instructor tabs
        /// </summary>
        public void PopulateDataGridViewAllCourses(DataGridView dgv, ListBox lb)
        {
            List<String> selectedDepartments = new List<string>();

            for (int i = 0; i < lb.SelectedItems.Count; i++)
            {
                selectedDepartments.Add(lb.SelectedItems[i].ToString());
            }

            var selectedCourses = from course in context.Courses
                                  where selectedDepartments.Contains(course.DepartmentCode)
                                  select course;

            dgv.DataSource = selectedCourses.ToList();
            dgv.Columns["Students"].Visible = false;
            dgv.Columns["Instructors"].Visible = false;
            dgv.Columns["Department"].Visible = false;
            dgv.Columns[0].Width = 100;
            dgv.Columns[0].HeaderText = "Department Code";
            dgv.Columns[1].Width = 90;
            dgv.Columns[1].HeaderText = "Number";
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[2].HeaderText = "Title";
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.ClearSelection();
        }

        /// <summary>
        /// Reset Student and Instructor tabs to default
        /// </summary>
        public void ResetSelections()
        {
            context.Students.Load();
            context.Departments.Load();
            context.Instructors.Load();
            context.Courses.Load();

            currentStudentId = 0;
            currentInstructorId = 0;

            textBoxStudentId.Clear();
            textBoxInstructorId.Clear();

            labelStudentNameDisplay.Text = "";
            labelInstructorNameDisplay.Text = "";

            dataGridViewStudentRegisteredCourses.DataSource = null;
            dataGridViewInstructorTeachingCourses.DataSource = null;

            PopulateDataGridViewAllCourses(dataGridViewStudentAllCourses, listBoxStudentDepartment);
            PopulateDataGridViewAllCourses(dataGridViewInstructorAllCourses, listBoxInstructorDepartment);
        }

        /// <summary>
        /// Initialize department list box with values
        /// </summary>
        public void InitializeDeptListBox(ListBox listBox)
        {
            context.Departments.Load();
            listBox.DataSource = context.Departments.Select(x => x.DepartmentCode).ToList();
            listBox.SelectionMode = SelectionMode.MultiExtended;

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                listBox.SelectedIndex = i;
            }
        }

        /// <summary>
        /// Initialize Admin tab and all of its DataGridViews
        /// </summary>
        public void InitializeAdminTab()
        {
            // Students

            dataGridViewAdminStudents.DataSource = context.Students.Local.ToBindingList();
            dataGridViewAdminStudents.Columns["Courses"].Visible = false;
            dataGridViewAdminStudents.Columns[0].Width = 40;
            dataGridViewAdminStudents.Columns[0].HeaderText = "ID";
            dataGridViewAdminStudents.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAdminStudents.Columns[1].HeaderText = "Name";
            dataGridViewAdminStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdminStudents.MultiSelect = false;
            dataGridViewAdminStudents.ClearSelection();

            // Instructors

            dataGridViewAdminInstructors.DataSource = context.Instructors.Local.ToBindingList();
            dataGridViewAdminInstructors.Columns["Courses"].Visible = false;
            dataGridViewAdminInstructors.Columns[0].Width = 40;
            dataGridViewAdminInstructors.Columns[0].HeaderText = "ID";
            dataGridViewAdminInstructors.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAdminInstructors.Columns[1].HeaderText = "Name";
            dataGridViewAdminInstructors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdminInstructors.MultiSelect = false;
            dataGridViewAdminInstructors.ClearSelection();

            // Departments

            dataGridViewAdminDepartments.DataSource = context.Departments.Local.ToBindingList();
            dataGridViewAdminDepartments.Columns["Courses"].Visible = false;
            dataGridViewAdminDepartments.Columns[0].Width = 50;
            dataGridViewAdminDepartments.Columns[0].HeaderText = "Code";
            dataGridViewAdminDepartments.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAdminDepartments.Columns[1].HeaderText = "Name";
            dataGridViewAdminDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdminDepartments.MultiSelect = false;
            dataGridViewAdminDepartments.ClearSelection();

            // Courses

            dataGridViewAdminCourses.DataSource = context.Courses.Local.ToBindingList();
            dataGridViewAdminCourses.Columns["Students"].Visible = false;
            dataGridViewAdminCourses.Columns["Instructors"].Visible = false;
            dataGridViewAdminCourses.Columns["Department"].Visible = false;
            dataGridViewAdminCourses.Columns[0].Width = 100;
            dataGridViewAdminCourses.Columns[0].HeaderText = "Department Code";
            dataGridViewAdminCourses.Columns[1].Width = 90;
            dataGridViewAdminCourses.Columns[1].HeaderText = "Number";
            dataGridViewAdminCourses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAdminCourses.Columns[2].HeaderText = "Title";
            dataGridViewAdminCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdminCourses.MultiSelect = false;
            dataGridViewAdminCourses.ClearSelection();
        }

        // Event Handlers

        // On load handler

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeApplication();
        }

        // Menu options handlers

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = true;
            panelInstructor.Visible = false;
            panelAdministrator.Visible = false;
        }

        private void instructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelInstructor.Visible = true;
            panelAdministrator.Visible = false;
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = false;
            panelInstructor.Visible = false;
            panelAdministrator.Visible = true;
        }

        // Student tab handlers

        private void ListBoxStudentDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDataGridViewAllCourses(dataGridViewStudentAllCourses, listBoxStudentDepartment);
        }

        private void buttonStudentCheckCourses_Click(object sender, EventArgs e)
        {
            if (textBoxStudentId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the student ID");
            }
            else
            {
                try
                {
                    currentStudentId = Int32.Parse(textBoxStudentId.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a number");
                    textBoxStudentId.Clear();
                    return;
                }
                var selectedStudent = from student in context.Students
                                      where student.StudentId == currentStudentId
                                      select student;

                if (!selectedStudent.Any())
                {
                    MessageBox.Show("Student was not found. Please re-enter the ID");
                }
                else
                {
                    labelStudentNameDisplay.Text = selectedStudent.First().StudentName;

                    dataGridViewStudentRegisteredCourses.DataSource = selectedStudent.First().Courses.ToList();
                    dataGridViewStudentRegisteredCourses.Columns["Students"].Visible = false;
                    dataGridViewStudentRegisteredCourses.Columns["Instructors"].Visible = false;
                    dataGridViewStudentRegisteredCourses.Columns["Department"].Visible = false;
                    dataGridViewStudentRegisteredCourses.Columns[0].Width = 100;
                    dataGridViewStudentRegisteredCourses.Columns[0].HeaderText = "Department Code";
                    dataGridViewStudentRegisteredCourses.Columns[1].Width = 90;
                    dataGridViewStudentRegisteredCourses.Columns[1].HeaderText = "Number";
                    dataGridViewStudentRegisteredCourses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewStudentRegisteredCourses.Columns[2].HeaderText = "Title";
                    dataGridViewStudentRegisteredCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewStudentRegisteredCourses.ReadOnly = true;
                    dataGridViewStudentRegisteredCourses.MultiSelect = false;
                    dataGridViewStudentRegisteredCourses.ClearSelection();
                }
            }
            
        }

        private void buttonStudentRemoveCourse_Click(object sender, EventArgs e)
        {

            if (currentStudentId == 0)
            {
                MessageBox.Show("Please enter the student ID");
            }
            else
            {
                var selectedStudent = from student in context.Students
                                      where student.StudentId == currentStudentId
                                      select student;
                Int32 selectedRowCount = dataGridViewStudentRegisteredCourses.Rows.GetRowCount(DataGridViewElementStates.Selected);
                List<Course> selectedCourses = new List<Course>();
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < dataGridViewStudentRegisteredCourses.Rows.Count; i++)
                    {
                        if (dataGridViewStudentRegisteredCourses.Rows[i].Selected == true)
                        {
                            selectedCourses.Add((Course)dataGridViewStudentRegisteredCourses.Rows[i].DataBoundItem);
                        }

                    }
                    for (int i = 0; i < selectedCourses.Count; i++)
                    {
                        selectedStudent.First().Courses.Remove(selectedCourses[i]);
                    }
                    context.SaveChanges();
                    dataGridViewStudentRegisteredCourses.DataSource = selectedStudent.First().Courses.ToList();
                    dataGridViewStudentRegisteredCourses.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Please choose a course you want to withdraw from");
                }
            }
            
        }

        private void buttonStudentAddCourse_Click(object sender, EventArgs e)
        {
            
            if (currentStudentId == 0)
            {
                MessageBox.Show("Please enter the student ID");
            }
            else
            {
                var selectedStudent = from student in context.Students
                                      where student.StudentId == currentStudentId
                                      select student;
                Int32 selectedRowCount = dataGridViewStudentAllCourses.Rows.GetRowCount(DataGridViewElementStates.Selected);
                List<Course> selectedCourses = new List<Course>();
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < dataGridViewStudentAllCourses.Rows.Count; i++)
                    {
                        if (dataGridViewStudentAllCourses.Rows[i].Selected == true)
                        {
                            selectedCourses.Add((Course)dataGridViewStudentAllCourses.Rows[i].DataBoundItem);
                        }

                    }
                    for (int i = 0; i < selectedCourses.Count; i++)
                    {
                        selectedStudent.First().Courses.Add(selectedCourses[i]);
                    }
                    context.SaveChanges();
                    dataGridViewStudentRegisteredCourses.DataSource = selectedStudent.First().Courses.ToList();
                    dataGridViewStudentRegisteredCourses.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Please choose a course you want to add");
                }
            }
        }

        private void buttonStudentShowInfo_Click(object sender, EventArgs e)
        {

            if (dataGridViewStudentAllCourses.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please choose one course to see its info");
            }
            else
            {
                string selectedDepartmentCode = dataGridViewStudentAllCourses.SelectedRows[0].Cells[0].Value.ToString();
                int selectedCourseNumber = Int32.Parse(dataGridViewStudentAllCourses.SelectedRows[0].Cells[1].Value.ToString());
                FormStudentShowCourse newShowCourseForm = new FormStudentShowCourse(selectedDepartmentCode, selectedCourseNumber);
                var result = newShowCourseForm.ShowDialog();
                newShowCourseForm.Close();
            }
        }

        // Instructor tab handlers

        private void ListBoxInstructorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDataGridViewAllCourses(dataGridViewInstructorAllCourses, listBoxInstructorDepartment);
        }

        private void buttonInstructorLogin_Click(object sender, EventArgs e)
        {
            
            if (textBoxInstructorId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the instructor ID");
            }
            else
            {
                try
                {
                    currentInstructorId = Int32.Parse(textBoxInstructorId.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a number");
                    textBoxInstructorId.Clear();
                    return;
                }
                var selectedInstructor = from instructor in context.Instructors
                                      where instructor.InstructorId == currentInstructorId
                                      select instructor;


                if (!selectedInstructor.Any())
                {
                    MessageBox.Show("Instructor was not found. Please re-enter the ID");
                }
                else
                {
                    
                    Instructor currentInstructor = selectedInstructor.First();
                    labelInstructorNameDisplay.Text = currentInstructor.InstructorName;

                    dataGridViewInstructorTeachingCourses.DataSource = currentInstructor.Courses.ToList();
                    dataGridViewInstructorTeachingCourses.Columns["Students"].Visible = false;
                    dataGridViewInstructorTeachingCourses.Columns["Instructors"].Visible = false;
                    dataGridViewInstructorTeachingCourses.Columns["Department"].Visible = false;
                    dataGridViewInstructorTeachingCourses.Columns[0].Width = 100;
                    dataGridViewInstructorTeachingCourses.Columns[0].HeaderText = "Department Code";
                    dataGridViewInstructorTeachingCourses.Columns[1].Width = 90;
                    dataGridViewInstructorTeachingCourses.Columns[1].HeaderText = "Number";
                    dataGridViewInstructorTeachingCourses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewInstructorTeachingCourses.Columns[2].HeaderText = "Title";
                    dataGridViewInstructorTeachingCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewInstructorTeachingCourses.ReadOnly = true;
                    dataGridViewInstructorTeachingCourses.MultiSelect = false;
                    dataGridViewInstructorTeachingCourses.ClearSelection();
                }
            }
        }

        private void buttonInstructorRemoveCourse_Click(object sender, EventArgs e)
        {
            if (currentInstructorId == 0)
            {
                MessageBox.Show("Please enter the instructor ID");
            }
            else
            {
                var selectedInstructor = from instructor in context.Instructors
                                      where instructor.InstructorId == currentInstructorId
                                      select instructor;
                Int32 selectedRowCount = dataGridViewInstructorTeachingCourses.Rows.GetRowCount(DataGridViewElementStates.Selected);
                List<Course> selectedCourses = new List<Course>();
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < dataGridViewInstructorTeachingCourses.Rows.Count; i++)
                    {
                        if (dataGridViewInstructorTeachingCourses.Rows[i].Selected == true)
                        {
                            selectedCourses.Add((Course)dataGridViewInstructorTeachingCourses.Rows[i].DataBoundItem);
                        }

                    }
                    for (int i = 0; i < selectedCourses.Count; i++)
                    {
                        selectedInstructor.First().Courses.Remove(selectedCourses[i]);
                    }
                    context.SaveChanges();
                    dataGridViewInstructorTeachingCourses.DataSource = selectedInstructor.First().Courses.ToList();
                    dataGridViewInstructorTeachingCourses.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Please choose courses you want to stop teaching");
                }
            }
        }

        private void buttonInstructorAddCourse_Click(object sender, EventArgs e)
        {
            if (currentInstructorId == 0)
            {
                MessageBox.Show("Please enter the instructor ID");
            }
            else
            {
                var selectedInstructor = from instructor in context.Instructors
                                      where instructor.InstructorId == currentInstructorId
                                      select instructor;
                Int32 selectedRowCount = dataGridViewInstructorAllCourses.Rows.GetRowCount(DataGridViewElementStates.Selected);
                List<Course> selectedCourses = new List<Course>();
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < dataGridViewInstructorAllCourses.Rows.Count; i++)
                    {
                        if (dataGridViewInstructorAllCourses.Rows[i].Selected == true)
                        {
                            selectedCourses.Add((Course)dataGridViewInstructorAllCourses.Rows[i].DataBoundItem);
                        }

                    }
                    for (int i = 0; i < selectedCourses.Count; i++)
                    {
                        selectedInstructor.First().Courses.Add(selectedCourses[i]);
                    }
                    context.SaveChanges();
                    dataGridViewInstructorTeachingCourses.DataSource = selectedInstructor.First().Courses.ToList();
                    dataGridViewInstructorTeachingCourses.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Please choose courses you want to add");
                }
            }
        }

        private void buttonInstructorShowInfo_Click(object sender, EventArgs e)
        {
            if (dataGridViewInstructorAllCourses.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please choose one course to see its info");
            }
            else
            {
                string selectedDepartmentCode = dataGridViewInstructorAllCourses.SelectedRows[0].Cells[0].Value.ToString();
                int selectedCourseNumber = Int32.Parse(dataGridViewInstructorAllCourses.SelectedRows[0].Cells[1].Value.ToString());
                FormAdminShowCourse newShowCourseForm = new FormAdminShowCourse(selectedDepartmentCode, selectedCourseNumber);
                var result = newShowCourseForm.ShowDialog();
                newShowCourseForm.Close();
            }
        }

        // Admin tab handlers

        // Add

        private void buttonAdminAddStudent_Click(object sender, EventArgs e)
        {
            FormAddNewStudent newStudentForm = new FormAddNewStudent();

            // Open a window
            var result = newStudentForm.ShowDialog();

            // Create a record based on user selection
            if (result == DialogResult.OK)
            {
                context.Students.Add(newStudentForm.GetStudent());
                context.SaveChanges();
                // Set Student and Instructor tabs to default
                ResetSelections();
            }

            newStudentForm.Close();
        }

        private void buttonAdminAddInstructor_Click(object sender, EventArgs e)
        {
            FormAddNewInstructor newInstructorForm = new FormAddNewInstructor();

            var result = newInstructorForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                context.Instructors.Add(newInstructorForm.GetInstructor());
                context.SaveChanges();
                ResetSelections();
            }

            newInstructorForm.Close();
        }

        private void buttonAdminAddDepartment_Click(object sender, EventArgs e)
        {
            FormAddNewDepartment newDepartmentForm = new FormAddNewDepartment();

            var result = newDepartmentForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                context.Departments.Add(newDepartmentForm.GetDepartment());
                context.SaveChanges();
                ResetSelections();
            }

            newDepartmentForm.Close();
        }

        private void buttonAdminAddCourse_Click(object sender, EventArgs e)
        {
            FormAddNewCourse newCourseForm = new FormAddNewCourse();
            
            var result = newCourseForm.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                Course course = new Course
                {
                    DepartmentCode = newCourseForm.getDeptCode(),
                    CourseNumber = newCourseForm.getCourseNumber(),
                    CourseTitle = newCourseForm.getCourseTitle()
                };

                List<int> instructorIds = newCourseForm.getInstructorIds();

                var instructors = from instructor in context.Instructors
                                  where instructorIds.Contains(instructor.InstructorId)
                                  select instructor;

                for (int i = 0; i < instructors.Count(); i++)
                {
                    course.Instructors.Add(instructors.ToList()[i]);
                }

                context.Courses.Add(course);
                context.SaveChanges();
                ResetSelections();
            }

            newCourseForm.Close();
        }

        // Delete

        private void buttonAdminDeleteStudent_Click(object sender, EventArgs e)
        {
            // If a row is selected, delete the corresponding record
            if (dataGridViewAdminStudents.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected student?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int selectedStudentId = (dataGridViewAdminStudents.SelectedCells[0].RowIndex);
                    dataGridViewAdminStudents.Rows.RemoveAt(selectedStudentId);
                    context.SaveChanges();
                    ResetSelections();
                }
            }
            else
            {
                MessageBox.Show("Please select a student");
            }

        }

        private void buttonAdminDeleteInstructor_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdminInstructors.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected instructor?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int selectedInstructorId = dataGridViewAdminInstructors.SelectedCells[0].RowIndex;
                    dataGridViewAdminInstructors.Rows.RemoveAt(selectedInstructorId);
                    context.SaveChanges();
                    ResetSelections();
                }
            }
            else
            {
                MessageBox.Show("Please select an instructor");
            }
        }

        private void buttonAdminDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdminDepartments.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected department?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int selectedDepartmentId = dataGridViewAdminDepartments.SelectedCells[0].RowIndex;
                    dataGridViewAdminDepartments.Rows.RemoveAt(selectedDepartmentId);
                    context.SaveChanges();
                    ResetSelections();
                }
            }
            else
            {
                MessageBox.Show("Please select a department");
            }
            
        }

        private void buttonAdminDeleteCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdminCourses.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected course?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int selectedCourseId = dataGridViewAdminCourses.SelectedCells[0].RowIndex;
                    dataGridViewAdminCourses.Rows.RemoveAt(selectedCourseId);
                    context.SaveChanges();
                    ResetSelections();
                }
            }
            else
            {
                MessageBox.Show("Please select a course");
            }
        }

        // Show info

        private void buttonAdminShowStudent_Click(object sender, EventArgs e)
        {
            // If a row is selected, show information about the corresponding record
            if (dataGridViewAdminStudents.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewAdminStudents.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewAdminStudents.Rows[selectedRowIndex];
                int selectedStudentId = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                FormAdminShowStudent newShowStudentForm = new FormAdminShowStudent(selectedStudentId);
                var result = newShowStudentForm.ShowDialog();
                newShowStudentForm.Close();
                
            }
            else
            {
                MessageBox.Show("Please select a student");
            }
            
        }

        private void buttonAdminShowInstructor_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdminInstructors.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewAdminInstructors.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewAdminInstructors.Rows[selectedRowIndex];
                int selectedInstructorId = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                FormAdminShowInstructor newShowInstructorForm = new FormAdminShowInstructor(selectedInstructorId);
                var result = newShowInstructorForm.ShowDialog();
                newShowInstructorForm.Close();
            }
            else
            {
                MessageBox.Show("Please select an instructor");
            }
        }

        private void buttonAdminShowDepartment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdminDepartments.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewAdminDepartments.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewAdminDepartments.Rows[selectedRowIndex];
                string selectedDepartmentCode = selectedRow.Cells[0].Value.ToString();
                FormAdminShowDepartment newShowDepartmentForm = new FormAdminShowDepartment(selectedDepartmentCode);
                var result = newShowDepartmentForm.ShowDialog();
                newShowDepartmentForm.Close();
            }
            else
            {
                MessageBox.Show("Please select a department");
            }
            
        }

        private void buttonAdminShowCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdminCourses.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewAdminCourses.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewAdminCourses.Rows[selectedRowIndex];
                string selectedDepartmentCode = selectedRow.Cells[0].Value.ToString();
                int selectedCourseNumber = Int32.Parse(selectedRow.Cells[1].Value.ToString());
                FormAdminShowCourse newShowCourseForm = new FormAdminShowCourse(selectedDepartmentCode, selectedCourseNumber);
                var result = newShowCourseForm.ShowDialog();
                newShowCourseForm.Close();
            }
            else
            {
                MessageBox.Show("Please select a course");
            }
            
        }
    }
}
