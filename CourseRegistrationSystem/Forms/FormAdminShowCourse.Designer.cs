namespace CourseRegistrationSystem.Forms
{
    partial class FormAdminShowCourse
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
            this.labelAdminShowCourseNumberDisplay = new System.Windows.Forms.Label();
            this.labelAdminShowCourseNumber = new System.Windows.Forms.Label();
            this.labelAdminCourseInformation = new System.Windows.Forms.Label();
            this.buttonAdminShowCourseOK = new System.Windows.Forms.Button();
            this.labelAdminShowCourseTitleDisplay = new System.Windows.Forms.Label();
            this.labelAdminShowCourseDeptDisplay = new System.Windows.Forms.Label();
            this.labelAdminShowCourseInstructors = new System.Windows.Forms.Label();
            this.dataGridViewAdminShowCourseInstructors = new System.Windows.Forms.DataGridView();
            this.labelAdminShowCourseTitle = new System.Windows.Forms.Label();
            this.labelAdminShowCourseDept = new System.Windows.Forms.Label();
            this.labelAdminShowCourseStudents = new System.Windows.Forms.Label();
            this.dataGridViewAdminShowCourseStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminShowCourseInstructors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminShowCourseStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdminShowCourseNumberDisplay
            // 
            this.labelAdminShowCourseNumberDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdminShowCourseNumberDisplay.Location = new System.Drawing.Point(172, 89);
            this.labelAdminShowCourseNumberDisplay.Name = "labelAdminShowCourseNumberDisplay";
            this.labelAdminShowCourseNumberDisplay.Size = new System.Drawing.Size(140, 20);
            this.labelAdminShowCourseNumberDisplay.TabIndex = 35;
            this.labelAdminShowCourseNumberDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAdminShowCourseNumber
            // 
            this.labelAdminShowCourseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminShowCourseNumber.Location = new System.Drawing.Point(32, 89);
            this.labelAdminShowCourseNumber.Name = "labelAdminShowCourseNumber";
            this.labelAdminShowCourseNumber.Size = new System.Drawing.Size(120, 20);
            this.labelAdminShowCourseNumber.TabIndex = 34;
            this.labelAdminShowCourseNumber.Text = "Course Number";
            this.labelAdminShowCourseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAdminCourseInformation
            // 
            this.labelAdminCourseInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminCourseInformation.Location = new System.Drawing.Point(72, 9);
            this.labelAdminCourseInformation.Name = "labelAdminCourseInformation";
            this.labelAdminCourseInformation.Size = new System.Drawing.Size(200, 30);
            this.labelAdminCourseInformation.TabIndex = 33;
            this.labelAdminCourseInformation.Text = "Course Information";
            this.labelAdminCourseInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdminShowCourseOK
            // 
            this.buttonAdminShowCourseOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminShowCourseOK.Location = new System.Drawing.Point(112, 492);
            this.buttonAdminShowCourseOK.Name = "buttonAdminShowCourseOK";
            this.buttonAdminShowCourseOK.Size = new System.Drawing.Size(120, 30);
            this.buttonAdminShowCourseOK.TabIndex = 32;
            this.buttonAdminShowCourseOK.Text = "OK";
            this.buttonAdminShowCourseOK.UseVisualStyleBackColor = true;
            this.buttonAdminShowCourseOK.Click += new System.EventHandler(this.buttonAdminShowCourseOK_Click);
            // 
            // labelAdminShowCourseTitleDisplay
            // 
            this.labelAdminShowCourseTitleDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdminShowCourseTitleDisplay.Location = new System.Drawing.Point(17, 150);
            this.labelAdminShowCourseTitleDisplay.Name = "labelAdminShowCourseTitleDisplay";
            this.labelAdminShowCourseTitleDisplay.Size = new System.Drawing.Size(310, 20);
            this.labelAdminShowCourseTitleDisplay.TabIndex = 31;
            this.labelAdminShowCourseTitleDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAdminShowCourseDeptDisplay
            // 
            this.labelAdminShowCourseDeptDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdminShowCourseDeptDisplay.Location = new System.Drawing.Point(172, 49);
            this.labelAdminShowCourseDeptDisplay.Name = "labelAdminShowCourseDeptDisplay";
            this.labelAdminShowCourseDeptDisplay.Size = new System.Drawing.Size(50, 20);
            this.labelAdminShowCourseDeptDisplay.TabIndex = 30;
            this.labelAdminShowCourseDeptDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAdminShowCourseInstructors
            // 
            this.labelAdminShowCourseInstructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminShowCourseInstructors.Location = new System.Drawing.Point(112, 179);
            this.labelAdminShowCourseInstructors.Name = "labelAdminShowCourseInstructors";
            this.labelAdminShowCourseInstructors.Size = new System.Drawing.Size(120, 20);
            this.labelAdminShowCourseInstructors.TabIndex = 29;
            this.labelAdminShowCourseInstructors.Text = "Instructors";
            this.labelAdminShowCourseInstructors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAdminShowCourseInstructors
            // 
            this.dataGridViewAdminShowCourseInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminShowCourseInstructors.Location = new System.Drawing.Point(17, 200);
            this.dataGridViewAdminShowCourseInstructors.Name = "dataGridViewAdminShowCourseInstructors";
            this.dataGridViewAdminShowCourseInstructors.Size = new System.Drawing.Size(310, 120);
            this.dataGridViewAdminShowCourseInstructors.TabIndex = 28;
            // 
            // labelAdminShowCourseTitle
            // 
            this.labelAdminShowCourseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminShowCourseTitle.Location = new System.Drawing.Point(112, 129);
            this.labelAdminShowCourseTitle.Name = "labelAdminShowCourseTitle";
            this.labelAdminShowCourseTitle.Size = new System.Drawing.Size(120, 20);
            this.labelAdminShowCourseTitle.TabIndex = 27;
            this.labelAdminShowCourseTitle.Text = "Course Title";
            this.labelAdminShowCourseTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAdminShowCourseDept
            // 
            this.labelAdminShowCourseDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminShowCourseDept.Location = new System.Drawing.Point(32, 49);
            this.labelAdminShowCourseDept.Name = "labelAdminShowCourseDept";
            this.labelAdminShowCourseDept.Size = new System.Drawing.Size(120, 20);
            this.labelAdminShowCourseDept.TabIndex = 26;
            this.labelAdminShowCourseDept.Text = "Department Code";
            this.labelAdminShowCourseDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAdminShowCourseStudents
            // 
            this.labelAdminShowCourseStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminShowCourseStudents.Location = new System.Drawing.Point(112, 335);
            this.labelAdminShowCourseStudents.Name = "labelAdminShowCourseStudents";
            this.labelAdminShowCourseStudents.Size = new System.Drawing.Size(120, 20);
            this.labelAdminShowCourseStudents.TabIndex = 37;
            this.labelAdminShowCourseStudents.Text = "Students";
            this.labelAdminShowCourseStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAdminShowCourseStudents
            // 
            this.dataGridViewAdminShowCourseStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminShowCourseStudents.Location = new System.Drawing.Point(17, 357);
            this.dataGridViewAdminShowCourseStudents.Name = "dataGridViewAdminShowCourseStudents";
            this.dataGridViewAdminShowCourseStudents.Size = new System.Drawing.Size(310, 120);
            this.dataGridViewAdminShowCourseStudents.TabIndex = 36;
            // 
            // FormAdminShowCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 531);
            this.Controls.Add(this.labelAdminShowCourseStudents);
            this.Controls.Add(this.dataGridViewAdminShowCourseStudents);
            this.Controls.Add(this.labelAdminShowCourseNumberDisplay);
            this.Controls.Add(this.labelAdminShowCourseNumber);
            this.Controls.Add(this.labelAdminCourseInformation);
            this.Controls.Add(this.buttonAdminShowCourseOK);
            this.Controls.Add(this.labelAdminShowCourseTitleDisplay);
            this.Controls.Add(this.labelAdminShowCourseDeptDisplay);
            this.Controls.Add(this.labelAdminShowCourseInstructors);
            this.Controls.Add(this.dataGridViewAdminShowCourseInstructors);
            this.Controls.Add(this.labelAdminShowCourseTitle);
            this.Controls.Add(this.labelAdminShowCourseDept);
            this.Name = "FormAdminShowCourse";
            this.Text = "Show Course Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminShowCourseInstructors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminShowCourseStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAdminShowCourseNumberDisplay;
        private System.Windows.Forms.Label labelAdminShowCourseNumber;
        private System.Windows.Forms.Label labelAdminCourseInformation;
        private System.Windows.Forms.Button buttonAdminShowCourseOK;
        private System.Windows.Forms.Label labelAdminShowCourseTitleDisplay;
        private System.Windows.Forms.Label labelAdminShowCourseDeptDisplay;
        private System.Windows.Forms.Label labelAdminShowCourseInstructors;
        private System.Windows.Forms.DataGridView dataGridViewAdminShowCourseInstructors;
        private System.Windows.Forms.Label labelAdminShowCourseTitle;
        private System.Windows.Forms.Label labelAdminShowCourseDept;
        private System.Windows.Forms.Label labelAdminShowCourseStudents;
        private System.Windows.Forms.DataGridView dataGridViewAdminShowCourseStudents;
    }
}