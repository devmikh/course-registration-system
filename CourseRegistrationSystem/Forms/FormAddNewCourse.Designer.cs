namespace CourseRegistrationSystem.Forms
{
    partial class FormAddNewCourse
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
            this.labelAddNewCourse = new System.Windows.Forms.Label();
            this.labelAddNewCourseDepartment = new System.Windows.Forms.Label();
            this.listBoxAddNewCourseDepartment = new System.Windows.Forms.ListBox();
            this.labelAddNewCourseNumber = new System.Windows.Forms.Label();
            this.textBoxAddNewCourseNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddNewCourseTitle = new System.Windows.Forms.TextBox();
            this.labelAddNewCourseTitle = new System.Windows.Forms.Label();
            this.dataGridViewAddNewCourseInstructor = new System.Windows.Forms.DataGridView();
            this.labelAddNewCourseInstructor = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddNewCourseInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddNewCourse
            // 
            this.labelAddNewCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNewCourse.Location = new System.Drawing.Point(102, 10);
            this.labelAddNewCourse.Name = "labelAddNewCourse";
            this.labelAddNewCourse.Size = new System.Drawing.Size(140, 30);
            this.labelAddNewCourse.TabIndex = 2;
            this.labelAddNewCourse.Text = "Add New Course";
            this.labelAddNewCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAddNewCourseDepartment
            // 
            this.labelAddNewCourseDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNewCourseDepartment.Location = new System.Drawing.Point(32, 55);
            this.labelAddNewCourseDepartment.Name = "labelAddNewCourseDepartment";
            this.labelAddNewCourseDepartment.Size = new System.Drawing.Size(120, 20);
            this.labelAddNewCourseDepartment.TabIndex = 3;
            this.labelAddNewCourseDepartment.Text = "Department Code";
            this.labelAddNewCourseDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxAddNewCourseDepartment
            // 
            this.listBoxAddNewCourseDepartment.FormattingEnabled = true;
            this.listBoxAddNewCourseDepartment.Location = new System.Drawing.Point(172, 55);
            this.listBoxAddNewCourseDepartment.Name = "listBoxAddNewCourseDepartment";
            this.listBoxAddNewCourseDepartment.Size = new System.Drawing.Size(140, 82);
            this.listBoxAddNewCourseDepartment.TabIndex = 4;
            // 
            // labelAddNewCourseNumber
            // 
            this.labelAddNewCourseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNewCourseNumber.Location = new System.Drawing.Point(32, 160);
            this.labelAddNewCourseNumber.Name = "labelAddNewCourseNumber";
            this.labelAddNewCourseNumber.Size = new System.Drawing.Size(120, 20);
            this.labelAddNewCourseNumber.TabIndex = 5;
            this.labelAddNewCourseNumber.Text = "Course Number";
            this.labelAddNewCourseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAddNewCourseNumber
            // 
            this.textBoxAddNewCourseNumber.Location = new System.Drawing.Point(172, 160);
            this.textBoxAddNewCourseNumber.Name = "textBoxAddNewCourseNumber";
            this.textBoxAddNewCourseNumber.Size = new System.Drawing.Size(140, 20);
            this.textBoxAddNewCourseNumber.TabIndex = 6;
            // 
            // textBoxAddNewCourseTitle
            // 
            this.textBoxAddNewCourseTitle.Location = new System.Drawing.Point(172, 200);
            this.textBoxAddNewCourseTitle.Name = "textBoxAddNewCourseTitle";
            this.textBoxAddNewCourseTitle.Size = new System.Drawing.Size(140, 20);
            this.textBoxAddNewCourseTitle.TabIndex = 8;
            // 
            // labelAddNewCourseTitle
            // 
            this.labelAddNewCourseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNewCourseTitle.Location = new System.Drawing.Point(32, 200);
            this.labelAddNewCourseTitle.Name = "labelAddNewCourseTitle";
            this.labelAddNewCourseTitle.Size = new System.Drawing.Size(120, 20);
            this.labelAddNewCourseTitle.TabIndex = 7;
            this.labelAddNewCourseTitle.Text = "Course Title";
            this.labelAddNewCourseTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewAddNewCourseInstructor
            // 
            this.dataGridViewAddNewCourseInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddNewCourseInstructor.Location = new System.Drawing.Point(32, 265);
            this.dataGridViewAddNewCourseInstructor.Name = "dataGridViewAddNewCourseInstructor";
            this.dataGridViewAddNewCourseInstructor.Size = new System.Drawing.Size(280, 150);
            this.dataGridViewAddNewCourseInstructor.TabIndex = 9;
            // 
            // labelAddNewCourseInstructor
            // 
            this.labelAddNewCourseInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNewCourseInstructor.Location = new System.Drawing.Point(112, 240);
            this.labelAddNewCourseInstructor.Name = "labelAddNewCourseInstructor";
            this.labelAddNewCourseInstructor.Size = new System.Drawing.Size(120, 20);
            this.labelAddNewCourseInstructor.TabIndex = 10;
            this.labelAddNewCourseInstructor.Text = "Instructor";
            this.labelAddNewCourseInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCourse.Location = new System.Drawing.Point(112, 425);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(120, 30);
            this.buttonAddCourse.TabIndex = 11;
            this.buttonAddCourse.Text = "Add Course";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // FormAddNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 461);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.labelAddNewCourseInstructor);
            this.Controls.Add(this.dataGridViewAddNewCourseInstructor);
            this.Controls.Add(this.textBoxAddNewCourseTitle);
            this.Controls.Add(this.labelAddNewCourseTitle);
            this.Controls.Add(this.textBoxAddNewCourseNumber);
            this.Controls.Add(this.labelAddNewCourseNumber);
            this.Controls.Add(this.listBoxAddNewCourseDepartment);
            this.Controls.Add(this.labelAddNewCourseDepartment);
            this.Controls.Add(this.labelAddNewCourse);
            this.Name = "FormAddNewCourse";
            this.Text = "Add New Course";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddNewCourseInstructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddNewCourse;
        private System.Windows.Forms.Label labelAddNewCourseDepartment;
        private System.Windows.Forms.ListBox listBoxAddNewCourseDepartment;
        private System.Windows.Forms.Label labelAddNewCourseNumber;
        private System.Windows.Forms.TextBox textBoxAddNewCourseNumber;
        private System.Windows.Forms.TextBox textBoxAddNewCourseTitle;
        private System.Windows.Forms.Label labelAddNewCourseTitle;
        private System.Windows.Forms.DataGridView dataGridViewAddNewCourseInstructor;
        private System.Windows.Forms.Label labelAddNewCourseInstructor;
        private System.Windows.Forms.Button buttonAddCourse;
    }
}