namespace CourseRegistrationSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.accessAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.buttonStudentRemoveCourse = new System.Windows.Forms.Button();
            this.buttonStudentShowInfo = new System.Windows.Forms.Button();
            this.labelStudentNameDisplay = new System.Windows.Forms.Label();
            this.buttonStudentCheckCourses = new System.Windows.Forms.Button();
            this.buttonStudentAddCourse = new System.Windows.Forms.Button();
            this.labelStudentDepartment = new System.Windows.Forms.Label();
            this.listBoxStudentDepartment = new System.Windows.Forms.ListBox();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelStudentRegisteredCourses = new System.Windows.Forms.Label();
            this.labelStudentAllCourses = new System.Windows.Forms.Label();
            this.dataGridViewStudentRegisteredCourses = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudentAllCourses = new System.Windows.Forms.DataGridView();
            this.labelStudent = new System.Windows.Forms.Label();
            this.panelInstructor = new System.Windows.Forms.Panel();
            this.buttonInstructorRemoveCourse = new System.Windows.Forms.Button();
            this.buttonInstructorShowInfo = new System.Windows.Forms.Button();
            this.buttonInstructorAddCourse = new System.Windows.Forms.Button();
            this.labelInstructorAllCourses = new System.Windows.Forms.Label();
            this.dataGridViewInstructorAllCourses = new System.Windows.Forms.DataGridView();
            this.labelInstructorDepartment = new System.Windows.Forms.Label();
            this.listBoxInstructorDepartment = new System.Windows.Forms.ListBox();
            this.labelInstructorNameDisplay = new System.Windows.Forms.Label();
            this.labelInstructor = new System.Windows.Forms.Label();
            this.buttonInstructorLogin = new System.Windows.Forms.Button();
            this.labelInstructorTeaching = new System.Windows.Forms.Label();
            this.dataGridViewInstructorTeachingCourses = new System.Windows.Forms.DataGridView();
            this.textBoxInstructorId = new System.Windows.Forms.TextBox();
            this.labelInstructorId = new System.Windows.Forms.Label();
            this.labelInstructorName = new System.Windows.Forms.Label();
            this.panelAdministrator = new System.Windows.Forms.Panel();
            this.buttonAdminShowDepartment = new System.Windows.Forms.Button();
            this.buttonAdminDeleteDepartment = new System.Windows.Forms.Button();
            this.buttonAdminAddDepartment = new System.Windows.Forms.Button();
            this.dataGridViewAdminDepartments = new System.Windows.Forms.DataGridView();
            this.labelAdminDepartments = new System.Windows.Forms.Label();
            this.buttonAdminShowCourse = new System.Windows.Forms.Button();
            this.buttonAdminShowInstructor = new System.Windows.Forms.Button();
            this.buttonAdminShowStudent = new System.Windows.Forms.Button();
            this.buttonAdminDeleteCourse = new System.Windows.Forms.Button();
            this.buttonAdminAddCourse = new System.Windows.Forms.Button();
            this.buttonAdminDeleteInstructor = new System.Windows.Forms.Button();
            this.buttonAdminAddInstructor = new System.Windows.Forms.Button();
            this.buttonAdminDeleteStudent = new System.Windows.Forms.Button();
            this.buttonAdminAddStudent = new System.Windows.Forms.Button();
            this.dataGridViewAdminCourses = new System.Windows.Forms.DataGridView();
            this.dataGridViewAdminInstructors = new System.Windows.Forms.DataGridView();
            this.labelAdminCourses = new System.Windows.Forms.Label();
            this.labelAdminInstructors = new System.Windows.Forms.Label();
            this.labelAdminStudents = new System.Windows.Forms.Label();
            this.dataGridViewAdminStudents = new System.Windows.Forms.DataGridView();
            this.labelAdministrator = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentRegisteredCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentAllCourses)).BeginInit();
            this.panelInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructorAllCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructorTeachingCourses)).BeginInit();
            this.panelAdministrator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminInstructors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessAsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // accessAsToolStripMenuItem
            // 
            this.accessAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.instructorToolStripMenuItem,
            this.administratorToolStripMenuItem});
            this.accessAsToolStripMenuItem.Name = "accessAsToolStripMenuItem";
            this.accessAsToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.accessAsToolStripMenuItem.Text = "Access As:";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // instructorToolStripMenuItem
            // 
            this.instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            this.instructorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instructorToolStripMenuItem.Text = "Instructor";
            this.instructorToolStripMenuItem.Click += new System.EventHandler(this.instructorToolStripMenuItem_Click);
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.administratorToolStripMenuItem.Text = "Administrator";
            this.administratorToolStripMenuItem.Click += new System.EventHandler(this.administratorToolStripMenuItem_Click);
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.buttonStudentRemoveCourse);
            this.panelStudent.Controls.Add(this.buttonStudentShowInfo);
            this.panelStudent.Controls.Add(this.labelStudentNameDisplay);
            this.panelStudent.Controls.Add(this.buttonStudentCheckCourses);
            this.panelStudent.Controls.Add(this.buttonStudentAddCourse);
            this.panelStudent.Controls.Add(this.labelStudentDepartment);
            this.panelStudent.Controls.Add(this.listBoxStudentDepartment);
            this.panelStudent.Controls.Add(this.textBoxStudentId);
            this.panelStudent.Controls.Add(this.labelStudentId);
            this.panelStudent.Controls.Add(this.labelStudentName);
            this.panelStudent.Controls.Add(this.labelStudentRegisteredCourses);
            this.panelStudent.Controls.Add(this.labelStudentAllCourses);
            this.panelStudent.Controls.Add(this.dataGridViewStudentRegisteredCourses);
            this.panelStudent.Controls.Add(this.dataGridViewStudentAllCourses);
            this.panelStudent.Controls.Add(this.labelStudent);
            this.panelStudent.Location = new System.Drawing.Point(-8, 60);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(800, 600);
            this.panelStudent.TabIndex = 1;
            // 
            // buttonStudentRemoveCourse
            // 
            this.buttonStudentRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudentRemoveCourse.Location = new System.Drawing.Point(330, 340);
            this.buttonStudentRemoveCourse.Name = "buttonStudentRemoveCourse";
            this.buttonStudentRemoveCourse.Size = new System.Drawing.Size(130, 30);
            this.buttonStudentRemoveCourse.TabIndex = 52;
            this.buttonStudentRemoveCourse.Text = "Remove Course";
            this.buttonStudentRemoveCourse.UseVisualStyleBackColor = true;
            this.buttonStudentRemoveCourse.Click += new System.EventHandler(this.buttonStudentRemoveCourse_Click);
            // 
            // buttonStudentShowInfo
            // 
            this.buttonStudentShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudentShowInfo.Location = new System.Drawing.Point(500, 560);
            this.buttonStudentShowInfo.Name = "buttonStudentShowInfo";
            this.buttonStudentShowInfo.Size = new System.Drawing.Size(130, 30);
            this.buttonStudentShowInfo.TabIndex = 51;
            this.buttonStudentShowInfo.Text = "Show Info";
            this.buttonStudentShowInfo.UseVisualStyleBackColor = true;
            this.buttonStudentShowInfo.Click += new System.EventHandler(this.buttonStudentShowInfo_Click);
            // 
            // labelStudentNameDisplay
            // 
            this.labelStudentNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStudentNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentNameDisplay.Location = new System.Drawing.Point(240, 95);
            this.labelStudentNameDisplay.Name = "labelStudentNameDisplay";
            this.labelStudentNameDisplay.Size = new System.Drawing.Size(150, 20);
            this.labelStudentNameDisplay.TabIndex = 50;
            this.labelStudentNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonStudentCheckCourses
            // 
            this.buttonStudentCheckCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudentCheckCourses.Location = new System.Drawing.Point(180, 148);
            this.buttonStudentCheckCourses.Name = "buttonStudentCheckCourses";
            this.buttonStudentCheckCourses.Size = new System.Drawing.Size(130, 30);
            this.buttonStudentCheckCourses.TabIndex = 49;
            this.buttonStudentCheckCourses.Text = "Select Student";
            this.buttonStudentCheckCourses.UseVisualStyleBackColor = true;
            this.buttonStudentCheckCourses.Click += new System.EventHandler(this.buttonStudentCheckCourses_Click);
            // 
            // buttonStudentAddCourse
            // 
            this.buttonStudentAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudentAddCourse.Location = new System.Drawing.Point(180, 560);
            this.buttonStudentAddCourse.Name = "buttonStudentAddCourse";
            this.buttonStudentAddCourse.Size = new System.Drawing.Size(130, 30);
            this.buttonStudentAddCourse.TabIndex = 48;
            this.buttonStudentAddCourse.Text = "Add Course";
            this.buttonStudentAddCourse.UseVisualStyleBackColor = true;
            this.buttonStudentAddCourse.Click += new System.EventHandler(this.buttonStudentAddCourse_Click);
            // 
            // labelStudentDepartment
            // 
            this.labelStudentDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentDepartment.Location = new System.Drawing.Point(450, 50);
            this.labelStudentDepartment.Name = "labelStudentDepartment";
            this.labelStudentDepartment.Size = new System.Drawing.Size(120, 30);
            this.labelStudentDepartment.TabIndex = 47;
            this.labelStudentDepartment.Text = "Department";
            this.labelStudentDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxStudentDepartment
            // 
            this.listBoxStudentDepartment.FormattingEnabled = true;
            this.listBoxStudentDepartment.Location = new System.Drawing.Point(580, 50);
            this.listBoxStudentDepartment.Name = "listBoxStudentDepartment";
            this.listBoxStudentDepartment.Size = new System.Drawing.Size(120, 108);
            this.listBoxStudentDepartment.TabIndex = 46;
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStudentId.Location = new System.Drawing.Point(240, 55);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentId.TabIndex = 44;
            // 
            // labelStudentId
            // 
            this.labelStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentId.Location = new System.Drawing.Point(100, 50);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(120, 30);
            this.labelStudentId.TabIndex = 43;
            this.labelStudentId.Text = "Student ID";
            this.labelStudentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStudentName
            // 
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentName.Location = new System.Drawing.Point(100, 90);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(120, 30);
            this.labelStudentName.TabIndex = 42;
            this.labelStudentName.Text = "Student Name";
            this.labelStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStudentRegisteredCourses
            // 
            this.labelStudentRegisteredCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentRegisteredCourses.Location = new System.Drawing.Point(310, 200);
            this.labelStudentRegisteredCourses.Name = "labelStudentRegisteredCourses";
            this.labelStudentRegisteredCourses.Size = new System.Drawing.Size(180, 30);
            this.labelStudentRegisteredCourses.TabIndex = 41;
            this.labelStudentRegisteredCourses.Text = "Currently Registered In";
            this.labelStudentRegisteredCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStudentAllCourses
            // 
            this.labelStudentAllCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentAllCourses.Location = new System.Drawing.Point(320, 380);
            this.labelStudentAllCourses.Name = "labelStudentAllCourses";
            this.labelStudentAllCourses.Size = new System.Drawing.Size(160, 30);
            this.labelStudentAllCourses.TabIndex = 40;
            this.labelStudentAllCourses.Text = "Available Courses";
            this.labelStudentAllCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewStudentRegisteredCourses
            // 
            this.dataGridViewStudentRegisteredCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentRegisteredCourses.Location = new System.Drawing.Point(100, 230);
            this.dataGridViewStudentRegisteredCourses.Name = "dataGridViewStudentRegisteredCourses";
            this.dataGridViewStudentRegisteredCourses.Size = new System.Drawing.Size(600, 100);
            this.dataGridViewStudentRegisteredCourses.TabIndex = 39;
            // 
            // dataGridViewStudentAllCourses
            // 
            this.dataGridViewStudentAllCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentAllCourses.Location = new System.Drawing.Point(100, 410);
            this.dataGridViewStudentAllCourses.Name = "dataGridViewStudentAllCourses";
            this.dataGridViewStudentAllCourses.Size = new System.Drawing.Size(600, 140);
            this.dataGridViewStudentAllCourses.TabIndex = 38;
            // 
            // labelStudent
            // 
            this.labelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudent.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelStudent.Location = new System.Drawing.Point(290, 3);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(220, 30);
            this.labelStudent.TabIndex = 37;
            this.labelStudent.Text = "Student Portal";
            this.labelStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInstructor
            // 
            this.panelInstructor.Controls.Add(this.buttonInstructorRemoveCourse);
            this.panelInstructor.Controls.Add(this.buttonInstructorShowInfo);
            this.panelInstructor.Controls.Add(this.buttonInstructorAddCourse);
            this.panelInstructor.Controls.Add(this.labelInstructorAllCourses);
            this.panelInstructor.Controls.Add(this.dataGridViewInstructorAllCourses);
            this.panelInstructor.Controls.Add(this.labelInstructorDepartment);
            this.panelInstructor.Controls.Add(this.listBoxInstructorDepartment);
            this.panelInstructor.Controls.Add(this.labelInstructorNameDisplay);
            this.panelInstructor.Controls.Add(this.labelInstructor);
            this.panelInstructor.Controls.Add(this.buttonInstructorLogin);
            this.panelInstructor.Controls.Add(this.labelInstructorTeaching);
            this.panelInstructor.Controls.Add(this.dataGridViewInstructorTeachingCourses);
            this.panelInstructor.Controls.Add(this.textBoxInstructorId);
            this.panelInstructor.Controls.Add(this.labelInstructorId);
            this.panelInstructor.Controls.Add(this.labelInstructorName);
            this.panelInstructor.Location = new System.Drawing.Point(-8, 60);
            this.panelInstructor.Name = "panelInstructor";
            this.panelInstructor.Size = new System.Drawing.Size(800, 600);
            this.panelInstructor.TabIndex = 0;
            this.panelInstructor.Visible = false;
            // 
            // buttonInstructorRemoveCourse
            // 
            this.buttonInstructorRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstructorRemoveCourse.Location = new System.Drawing.Point(330, 340);
            this.buttonInstructorRemoveCourse.Name = "buttonInstructorRemoveCourse";
            this.buttonInstructorRemoveCourse.Size = new System.Drawing.Size(130, 30);
            this.buttonInstructorRemoveCourse.TabIndex = 56;
            this.buttonInstructorRemoveCourse.Text = "Remove Course";
            this.buttonInstructorRemoveCourse.UseVisualStyleBackColor = true;
            this.buttonInstructorRemoveCourse.Click += new System.EventHandler(this.buttonInstructorRemoveCourse_Click);
            // 
            // buttonInstructorShowInfo
            // 
            this.buttonInstructorShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstructorShowInfo.Location = new System.Drawing.Point(500, 560);
            this.buttonInstructorShowInfo.Name = "buttonInstructorShowInfo";
            this.buttonInstructorShowInfo.Size = new System.Drawing.Size(130, 30);
            this.buttonInstructorShowInfo.TabIndex = 55;
            this.buttonInstructorShowInfo.Text = "Show Info";
            this.buttonInstructorShowInfo.UseVisualStyleBackColor = true;
            this.buttonInstructorShowInfo.Click += new System.EventHandler(this.buttonInstructorShowInfo_Click);
            // 
            // buttonInstructorAddCourse
            // 
            this.buttonInstructorAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstructorAddCourse.Location = new System.Drawing.Point(180, 560);
            this.buttonInstructorAddCourse.Name = "buttonInstructorAddCourse";
            this.buttonInstructorAddCourse.Size = new System.Drawing.Size(130, 30);
            this.buttonInstructorAddCourse.TabIndex = 54;
            this.buttonInstructorAddCourse.Text = "Add Course";
            this.buttonInstructorAddCourse.UseVisualStyleBackColor = true;
            this.buttonInstructorAddCourse.Click += new System.EventHandler(this.buttonInstructorAddCourse_Click);
            // 
            // labelInstructorAllCourses
            // 
            this.labelInstructorAllCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstructorAllCourses.Location = new System.Drawing.Point(320, 380);
            this.labelInstructorAllCourses.Name = "labelInstructorAllCourses";
            this.labelInstructorAllCourses.Size = new System.Drawing.Size(160, 30);
            this.labelInstructorAllCourses.TabIndex = 53;
            this.labelInstructorAllCourses.Text = "Available Courses";
            this.labelInstructorAllCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewInstructorAllCourses
            // 
            this.dataGridViewInstructorAllCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstructorAllCourses.Location = new System.Drawing.Point(100, 410);
            this.dataGridViewInstructorAllCourses.Name = "dataGridViewInstructorAllCourses";
            this.dataGridViewInstructorAllCourses.Size = new System.Drawing.Size(600, 140);
            this.dataGridViewInstructorAllCourses.TabIndex = 52;
            // 
            // labelInstructorDepartment
            // 
            this.labelInstructorDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstructorDepartment.Location = new System.Drawing.Point(450, 50);
            this.labelInstructorDepartment.Name = "labelInstructorDepartment";
            this.labelInstructorDepartment.Size = new System.Drawing.Size(120, 30);
            this.labelInstructorDepartment.TabIndex = 49;
            this.labelInstructorDepartment.Text = "Department";
            this.labelInstructorDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxInstructorDepartment
            // 
            this.listBoxInstructorDepartment.FormattingEnabled = true;
            this.listBoxInstructorDepartment.Location = new System.Drawing.Point(580, 50);
            this.listBoxInstructorDepartment.Name = "listBoxInstructorDepartment";
            this.listBoxInstructorDepartment.Size = new System.Drawing.Size(120, 108);
            this.listBoxInstructorDepartment.TabIndex = 48;
            // 
            // labelInstructorNameDisplay
            // 
            this.labelInstructorNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInstructorNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstructorNameDisplay.Location = new System.Drawing.Point(240, 95);
            this.labelInstructorNameDisplay.Name = "labelInstructorNameDisplay";
            this.labelInstructorNameDisplay.Size = new System.Drawing.Size(150, 20);
            this.labelInstructorNameDisplay.TabIndex = 46;
            // 
            // labelInstructor
            // 
            this.labelInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstructor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelInstructor.Location = new System.Drawing.Point(290, 3);
            this.labelInstructor.Name = "labelInstructor";
            this.labelInstructor.Size = new System.Drawing.Size(220, 30);
            this.labelInstructor.TabIndex = 45;
            this.labelInstructor.Text = "Instructor Portal";
            this.labelInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInstructorLogin
            // 
            this.buttonInstructorLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstructorLogin.Location = new System.Drawing.Point(180, 148);
            this.buttonInstructorLogin.Name = "buttonInstructorLogin";
            this.buttonInstructorLogin.Size = new System.Drawing.Size(130, 30);
            this.buttonInstructorLogin.TabIndex = 44;
            this.buttonInstructorLogin.Text = "Select Instructor";
            this.buttonInstructorLogin.UseVisualStyleBackColor = true;
            this.buttonInstructorLogin.Click += new System.EventHandler(this.buttonInstructorLogin_Click);
            // 
            // labelInstructorTeaching
            // 
            this.labelInstructorTeaching.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstructorTeaching.Location = new System.Drawing.Point(320, 200);
            this.labelInstructorTeaching.Name = "labelInstructorTeaching";
            this.labelInstructorTeaching.Size = new System.Drawing.Size(150, 30);
            this.labelInstructorTeaching.TabIndex = 43;
            this.labelInstructorTeaching.Text = "Currently Teaching";
            this.labelInstructorTeaching.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewInstructorTeachingCourses
            // 
            this.dataGridViewInstructorTeachingCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstructorTeachingCourses.Location = new System.Drawing.Point(100, 230);
            this.dataGridViewInstructorTeachingCourses.Name = "dataGridViewInstructorTeachingCourses";
            this.dataGridViewInstructorTeachingCourses.Size = new System.Drawing.Size(600, 100);
            this.dataGridViewInstructorTeachingCourses.TabIndex = 42;
            // 
            // textBoxInstructorId
            // 
            this.textBoxInstructorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInstructorId.Location = new System.Drawing.Point(240, 55);
            this.textBoxInstructorId.Name = "textBoxInstructorId";
            this.textBoxInstructorId.Size = new System.Drawing.Size(100, 22);
            this.textBoxInstructorId.TabIndex = 40;
            // 
            // labelInstructorId
            // 
            this.labelInstructorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstructorId.Location = new System.Drawing.Point(100, 50);
            this.labelInstructorId.Name = "labelInstructorId";
            this.labelInstructorId.Size = new System.Drawing.Size(130, 30);
            this.labelInstructorId.TabIndex = 39;
            this.labelInstructorId.Text = "Instructor ID";
            this.labelInstructorId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInstructorName
            // 
            this.labelInstructorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstructorName.Location = new System.Drawing.Point(100, 90);
            this.labelInstructorName.Name = "labelInstructorName";
            this.labelInstructorName.Size = new System.Drawing.Size(130, 30);
            this.labelInstructorName.TabIndex = 38;
            this.labelInstructorName.Text = "Instructor Name";
            this.labelInstructorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAdministrator
            // 
            this.panelAdministrator.Controls.Add(this.buttonAdminShowDepartment);
            this.panelAdministrator.Controls.Add(this.buttonAdminDeleteDepartment);
            this.panelAdministrator.Controls.Add(this.buttonAdminAddDepartment);
            this.panelAdministrator.Controls.Add(this.dataGridViewAdminDepartments);
            this.panelAdministrator.Controls.Add(this.labelAdminDepartments);
            this.panelAdministrator.Controls.Add(this.buttonAdminShowCourse);
            this.panelAdministrator.Controls.Add(this.buttonAdminShowInstructor);
            this.panelAdministrator.Controls.Add(this.buttonAdminShowStudent);
            this.panelAdministrator.Controls.Add(this.buttonAdminDeleteCourse);
            this.panelAdministrator.Controls.Add(this.buttonAdminAddCourse);
            this.panelAdministrator.Controls.Add(this.buttonAdminDeleteInstructor);
            this.panelAdministrator.Controls.Add(this.buttonAdminAddInstructor);
            this.panelAdministrator.Controls.Add(this.buttonAdminDeleteStudent);
            this.panelAdministrator.Controls.Add(this.buttonAdminAddStudent);
            this.panelAdministrator.Controls.Add(this.dataGridViewAdminCourses);
            this.panelAdministrator.Controls.Add(this.dataGridViewAdminInstructors);
            this.panelAdministrator.Controls.Add(this.labelAdminCourses);
            this.panelAdministrator.Controls.Add(this.labelAdminInstructors);
            this.panelAdministrator.Controls.Add(this.labelAdminStudents);
            this.panelAdministrator.Controls.Add(this.dataGridViewAdminStudents);
            this.panelAdministrator.Controls.Add(this.labelAdministrator);
            this.panelAdministrator.Location = new System.Drawing.Point(-8, 60);
            this.panelAdministrator.Name = "panelAdministrator";
            this.panelAdministrator.Size = new System.Drawing.Size(800, 600);
            this.panelAdministrator.TabIndex = 0;
            this.panelAdministrator.Visible = false;
            // 
            // buttonAdminShowDepartment
            // 
            this.buttonAdminShowDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminShowDepartment.Location = new System.Drawing.Point(590, 330);
            this.buttonAdminShowDepartment.Name = "buttonAdminShowDepartment";
            this.buttonAdminShowDepartment.Size = new System.Drawing.Size(130, 30);
            this.buttonAdminShowDepartment.TabIndex = 58;
            this.buttonAdminShowDepartment.Text = "Show Info";
            this.buttonAdminShowDepartment.UseVisualStyleBackColor = true;
            this.buttonAdminShowDepartment.Click += new System.EventHandler(this.buttonAdminShowDepartment_Click);
            // 
            // buttonAdminDeleteDepartment
            // 
            this.buttonAdminDeleteDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminDeleteDepartment.Location = new System.Drawing.Point(590, 295);
            this.buttonAdminDeleteDepartment.Name = "buttonAdminDeleteDepartment";
            this.buttonAdminDeleteDepartment.Size = new System.Drawing.Size(130, 30);
            this.buttonAdminDeleteDepartment.TabIndex = 57;
            this.buttonAdminDeleteDepartment.Text = "Delete Department";
            this.buttonAdminDeleteDepartment.UseVisualStyleBackColor = true;
            this.buttonAdminDeleteDepartment.Click += new System.EventHandler(this.buttonAdminDeleteDepartment_Click);
            // 
            // buttonAdminAddDepartment
            // 
            this.buttonAdminAddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminAddDepartment.Location = new System.Drawing.Point(590, 260);
            this.buttonAdminAddDepartment.Name = "buttonAdminAddDepartment";
            this.buttonAdminAddDepartment.Size = new System.Drawing.Size(130, 30);
            this.buttonAdminAddDepartment.TabIndex = 56;
            this.buttonAdminAddDepartment.Text = "Add Department";
            this.buttonAdminAddDepartment.UseVisualStyleBackColor = true;
            this.buttonAdminAddDepartment.Click += new System.EventHandler(this.buttonAdminAddDepartment_Click);
            // 
            // dataGridViewAdminDepartments
            // 
            this.dataGridViewAdminDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminDepartments.Location = new System.Drawing.Point(545, 72);
            this.dataGridViewAdminDepartments.Name = "dataGridViewAdminDepartments";
            this.dataGridViewAdminDepartments.Size = new System.Drawing.Size(220, 180);
            this.dataGridViewAdminDepartments.TabIndex = 55;
            // 
            // labelAdminDepartments
            // 
            this.labelAdminDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminDepartments.Location = new System.Drawing.Point(595, 40);
            this.labelAdminDepartments.Name = "labelAdminDepartments";
            this.labelAdminDepartments.Size = new System.Drawing.Size(120, 30);
            this.labelAdminDepartments.TabIndex = 54;
            this.labelAdminDepartments.Text = "Departments";
            this.labelAdminDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdminShowCourse
            // 
            this.buttonAdminShowCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminShowCourse.Location = new System.Drawing.Point(590, 550);
            this.buttonAdminShowCourse.Name = "buttonAdminShowCourse";
            this.buttonAdminShowCourse.Size = new System.Drawing.Size(130, 30);
            this.buttonAdminShowCourse.TabIndex = 53;
            this.buttonAdminShowCourse.Text = "Show Info";
            this.buttonAdminShowCourse.UseVisualStyleBackColor = true;
            this.buttonAdminShowCourse.Click += new System.EventHandler(this.buttonAdminShowCourse_Click);
            // 
            // buttonAdminShowInstructor
            // 
            this.buttonAdminShowInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminShowInstructor.Location = new System.Drawing.Point(335, 330);
            this.buttonAdminShowInstructor.Name = "buttonAdminShowInstructor";
            this.buttonAdminShowInstructor.Size = new System.Drawing.Size(130, 30);
            this.buttonAdminShowInstructor.TabIndex = 52;
            this.buttonAdminShowInstructor.Text = "Show Info";
            this.buttonAdminShowInstructor.UseVisualStyleBackColor = true;
            this.buttonAdminShowInstructor.Click += new System.EventHandler(this.buttonAdminShowInstructor_Click);
            // 
            // buttonAdminShowStudent
            // 
            this.buttonAdminShowStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminShowStudent.Location = new System.Drawing.Point(80, 330);
            this.buttonAdminShowStudent.Name = "buttonAdminShowStudent";
            this.buttonAdminShowStudent.Size = new System.Drawing.Size(130, 30);
            this.buttonAdminShowStudent.TabIndex = 51;
            this.buttonAdminShowStudent.Text = "Show Info";
            this.buttonAdminShowStudent.UseVisualStyleBackColor = true;
            this.buttonAdminShowStudent.Click += new System.EventHandler(this.buttonAdminShowStudent_Click);
            // 
            // buttonAdminDeleteCourse
            // 
            this.buttonAdminDeleteCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminDeleteCourse.Location = new System.Drawing.Point(335, 550);
            this.buttonAdminDeleteCourse.Name = "buttonAdminDeleteCourse";
            this.buttonAdminDeleteCourse.Size = new System.Drawing.Size(130, 30);
            this.buttonAdminDeleteCourse.TabIndex = 50;
            this.buttonAdminDeleteCourse.Text = "Delete Course";
            this.buttonAdminDeleteCourse.UseVisualStyleBackColor = true;
            this.buttonAdminDeleteCourse.Click += new System.EventHandler(this.buttonAdminDeleteCourse_Click);
            // 
            // buttonAdminAddCourse
            // 
            this.buttonAdminAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminAddCourse.Location = new System.Drawing.Point(80, 550);
            this.buttonAdminAddCourse.Name = "buttonAdminAddCourse";
            this.buttonAdminAddCourse.Size = new System.Drawing.Size(130, 30);
            this.buttonAdminAddCourse.TabIndex = 49;
            this.buttonAdminAddCourse.Text = "Add Course";
            this.buttonAdminAddCourse.UseVisualStyleBackColor = true;
            this.buttonAdminAddCourse.Click += new System.EventHandler(this.buttonAdminAddCourse_Click);
            // 
            // buttonAdminDeleteInstructor
            // 
            this.buttonAdminDeleteInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminDeleteInstructor.Location = new System.Drawing.Point(335, 295);
            this.buttonAdminDeleteInstructor.Name = "buttonAdminDeleteInstructor";
            this.buttonAdminDeleteInstructor.Size = new System.Drawing.Size(130, 30);
            this.buttonAdminDeleteInstructor.TabIndex = 48;
            this.buttonAdminDeleteInstructor.Text = "Delete Instructor";
            this.buttonAdminDeleteInstructor.UseVisualStyleBackColor = true;
            this.buttonAdminDeleteInstructor.Click += new System.EventHandler(this.buttonAdminDeleteInstructor_Click);
            // 
            // buttonAdminAddInstructor
            // 
            this.buttonAdminAddInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminAddInstructor.Location = new System.Drawing.Point(335, 260);
            this.buttonAdminAddInstructor.Name = "buttonAdminAddInstructor";
            this.buttonAdminAddInstructor.Size = new System.Drawing.Size(130, 30);
            this.buttonAdminAddInstructor.TabIndex = 47;
            this.buttonAdminAddInstructor.Text = "Add Instructor";
            this.buttonAdminAddInstructor.UseVisualStyleBackColor = true;
            this.buttonAdminAddInstructor.Click += new System.EventHandler(this.buttonAdminAddInstructor_Click);
            // 
            // buttonAdminDeleteStudent
            // 
            this.buttonAdminDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminDeleteStudent.Location = new System.Drawing.Point(80, 295);
            this.buttonAdminDeleteStudent.Name = "buttonAdminDeleteStudent";
            this.buttonAdminDeleteStudent.Size = new System.Drawing.Size(130, 30);
            this.buttonAdminDeleteStudent.TabIndex = 46;
            this.buttonAdminDeleteStudent.Text = "Delete Student";
            this.buttonAdminDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonAdminDeleteStudent.Click += new System.EventHandler(this.buttonAdminDeleteStudent_Click);
            // 
            // buttonAdminAddStudent
            // 
            this.buttonAdminAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminAddStudent.Location = new System.Drawing.Point(80, 260);
            this.buttonAdminAddStudent.Name = "buttonAdminAddStudent";
            this.buttonAdminAddStudent.Size = new System.Drawing.Size(130, 30);
            this.buttonAdminAddStudent.TabIndex = 45;
            this.buttonAdminAddStudent.Text = "Add Student";
            this.buttonAdminAddStudent.UseVisualStyleBackColor = true;
            this.buttonAdminAddStudent.Click += new System.EventHandler(this.buttonAdminAddStudent_Click);
            // 
            // dataGridViewAdminCourses
            // 
            this.dataGridViewAdminCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminCourses.Location = new System.Drawing.Point(35, 420);
            this.dataGridViewAdminCourses.Name = "dataGridViewAdminCourses";
            this.dataGridViewAdminCourses.Size = new System.Drawing.Size(730, 120);
            this.dataGridViewAdminCourses.TabIndex = 44;
            // 
            // dataGridViewAdminInstructors
            // 
            this.dataGridViewAdminInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminInstructors.Location = new System.Drawing.Point(290, 72);
            this.dataGridViewAdminInstructors.Name = "dataGridViewAdminInstructors";
            this.dataGridViewAdminInstructors.Size = new System.Drawing.Size(220, 180);
            this.dataGridViewAdminInstructors.TabIndex = 43;
            // 
            // labelAdminCourses
            // 
            this.labelAdminCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminCourses.Location = new System.Drawing.Point(340, 390);
            this.labelAdminCourses.Name = "labelAdminCourses";
            this.labelAdminCourses.Size = new System.Drawing.Size(120, 30);
            this.labelAdminCourses.TabIndex = 42;
            this.labelAdminCourses.Text = "Courses";
            this.labelAdminCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAdminInstructors
            // 
            this.labelAdminInstructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminInstructors.Location = new System.Drawing.Point(340, 40);
            this.labelAdminInstructors.Name = "labelAdminInstructors";
            this.labelAdminInstructors.Size = new System.Drawing.Size(120, 30);
            this.labelAdminInstructors.TabIndex = 41;
            this.labelAdminInstructors.Text = "Instructors";
            this.labelAdminInstructors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAdminStudents
            // 
            this.labelAdminStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminStudents.Location = new System.Drawing.Point(85, 40);
            this.labelAdminStudents.Name = "labelAdminStudents";
            this.labelAdminStudents.Size = new System.Drawing.Size(120, 30);
            this.labelAdminStudents.TabIndex = 40;
            this.labelAdminStudents.Text = "Students";
            this.labelAdminStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAdminStudents
            // 
            this.dataGridViewAdminStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminStudents.Location = new System.Drawing.Point(35, 72);
            this.dataGridViewAdminStudents.Name = "dataGridViewAdminStudents";
            this.dataGridViewAdminStudents.Size = new System.Drawing.Size(220, 180);
            this.dataGridViewAdminStudents.TabIndex = 37;
            // 
            // labelAdministrator
            // 
            this.labelAdministrator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdministrator.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelAdministrator.Location = new System.Drawing.Point(290, 3);
            this.labelAdministrator.Name = "labelAdministrator";
            this.labelAdministrator.Size = new System.Drawing.Size(220, 30);
            this.labelAdministrator.TabIndex = 36;
            this.labelAdministrator.Text = "Administrator Portal";
            this.labelAdministrator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeadingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HeadingLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HeadingLabel.Location = new System.Drawing.Point(240, 10);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Padding = new System.Windows.Forms.Padding(10);
            this.HeadingLabel.Size = new System.Drawing.Size(301, 47);
            this.HeadingLabel.TabIndex = 2;
            this.HeadingLabel.Text = "Course Registration System";
            this.HeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.HeadingLabel);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.panelInstructor);
            this.Controls.Add(this.panelAdministrator);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Course Registration System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentRegisteredCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentAllCourses)).EndInit();
            this.panelInstructor.ResumeLayout(false);
            this.panelInstructor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructorAllCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructorTeachingCourses)).EndInit();
            this.panelAdministrator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminInstructors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem accessAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Panel panelInstructor;
        private System.Windows.Forms.Panel panelAdministrator;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelAdministrator;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.DataGridView dataGridViewAdminCourses;
        private System.Windows.Forms.DataGridView dataGridViewAdminInstructors;
        private System.Windows.Forms.Label labelAdminCourses;
        private System.Windows.Forms.Label labelAdminInstructors;
        private System.Windows.Forms.Label labelAdminStudents;
        private System.Windows.Forms.DataGridView dataGridViewAdminStudents;
        private System.Windows.Forms.Button buttonStudentAddCourse;
        private System.Windows.Forms.Label labelStudentDepartment;
        private System.Windows.Forms.ListBox listBoxStudentDepartment;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelStudentRegisteredCourses;
        private System.Windows.Forms.Label labelStudentAllCourses;
        private System.Windows.Forms.DataGridView dataGridViewStudentRegisteredCourses;
        private System.Windows.Forms.DataGridView dataGridViewStudentAllCourses;
        private System.Windows.Forms.Label labelInstructorTeaching;
        private System.Windows.Forms.DataGridView dataGridViewInstructorTeachingCourses;
        private System.Windows.Forms.TextBox textBoxInstructorId;
        private System.Windows.Forms.Label labelInstructorId;
        private System.Windows.Forms.Label labelInstructorName;
        private System.Windows.Forms.Button buttonAdminDeleteCourse;
        private System.Windows.Forms.Button buttonAdminAddCourse;
        private System.Windows.Forms.Button buttonAdminDeleteInstructor;
        private System.Windows.Forms.Button buttonAdminAddInstructor;
        private System.Windows.Forms.Button buttonAdminDeleteStudent;
        private System.Windows.Forms.Button buttonAdminAddStudent;
        private System.Windows.Forms.Button buttonStudentCheckCourses;
        private System.Windows.Forms.Button buttonInstructorLogin;
        private System.Windows.Forms.Button buttonAdminShowCourse;
        private System.Windows.Forms.Button buttonAdminShowInstructor;
        private System.Windows.Forms.Button buttonAdminShowStudent;
        private System.Windows.Forms.Button buttonAdminShowDepartment;
        private System.Windows.Forms.Button buttonAdminDeleteDepartment;
        private System.Windows.Forms.Button buttonAdminAddDepartment;
        private System.Windows.Forms.DataGridView dataGridViewAdminDepartments;
        private System.Windows.Forms.Label labelAdminDepartments;
        private System.Windows.Forms.Label labelStudentNameDisplay;
        private System.Windows.Forms.Button buttonStudentShowInfo;
        private System.Windows.Forms.Label labelInstructor;
        private System.Windows.Forms.Label labelInstructorNameDisplay;
        private System.Windows.Forms.Button buttonInstructorShowInfo;
        private System.Windows.Forms.Button buttonInstructorAddCourse;
        private System.Windows.Forms.Label labelInstructorAllCourses;
        private System.Windows.Forms.DataGridView dataGridViewInstructorAllCourses;
        private System.Windows.Forms.Label labelInstructorDepartment;
        private System.Windows.Forms.ListBox listBoxInstructorDepartment;
        private System.Windows.Forms.Button buttonStudentRemoveCourse;
        private System.Windows.Forms.Button buttonInstructorRemoveCourse;
    }
}

