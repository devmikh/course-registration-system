namespace CourseRegistrationSystem.Forms
{
    partial class FormStudentShowCourse
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
            this.labelStudentCourseInformation = new System.Windows.Forms.Label();
            this.buttonStudentShowCourseOK = new System.Windows.Forms.Button();
            this.labelStudentShowCourseTitleDisplay = new System.Windows.Forms.Label();
            this.labelStudentShowCourseDeptDisplay = new System.Windows.Forms.Label();
            this.labelStudentShowCourseInstructors = new System.Windows.Forms.Label();
            this.dataGridViewStudentShowCourseInstructors = new System.Windows.Forms.DataGridView();
            this.labelStudentShowCourseTitle = new System.Windows.Forms.Label();
            this.labelStudentShowCourseDept = new System.Windows.Forms.Label();
            this.labelStudentShowCourseNumberDisplay = new System.Windows.Forms.Label();
            this.labelStudentShowCourseNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentShowCourseInstructors)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudentCourseInformation
            // 
            this.labelStudentCourseInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentCourseInformation.Location = new System.Drawing.Point(72, 9);
            this.labelStudentCourseInformation.Name = "labelStudentCourseInformation";
            this.labelStudentCourseInformation.Size = new System.Drawing.Size(200, 30);
            this.labelStudentCourseInformation.TabIndex = 23;
            this.labelStudentCourseInformation.Text = "Course Information";
            this.labelStudentCourseInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStudentShowCourseOK
            // 
            this.buttonStudentShowCourseOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudentShowCourseOK.Location = new System.Drawing.Point(112, 325);
            this.buttonStudentShowCourseOK.Name = "buttonStudentShowCourseOK";
            this.buttonStudentShowCourseOK.Size = new System.Drawing.Size(120, 30);
            this.buttonStudentShowCourseOK.TabIndex = 22;
            this.buttonStudentShowCourseOK.Text = "OK";
            this.buttonStudentShowCourseOK.UseVisualStyleBackColor = true;
            this.buttonStudentShowCourseOK.Click += new System.EventHandler(this.buttonStudentShowCourseOK_Click);
            // 
            // labelStudentShowCourseTitleDisplay
            // 
            this.labelStudentShowCourseTitleDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStudentShowCourseTitleDisplay.Location = new System.Drawing.Point(17, 150);
            this.labelStudentShowCourseTitleDisplay.Name = "labelStudentShowCourseTitleDisplay";
            this.labelStudentShowCourseTitleDisplay.Size = new System.Drawing.Size(310, 20);
            this.labelStudentShowCourseTitleDisplay.TabIndex = 21;
            this.labelStudentShowCourseTitleDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStudentShowCourseDeptDisplay
            // 
            this.labelStudentShowCourseDeptDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStudentShowCourseDeptDisplay.Location = new System.Drawing.Point(172, 49);
            this.labelStudentShowCourseDeptDisplay.Name = "labelStudentShowCourseDeptDisplay";
            this.labelStudentShowCourseDeptDisplay.Size = new System.Drawing.Size(50, 20);
            this.labelStudentShowCourseDeptDisplay.TabIndex = 20;
            this.labelStudentShowCourseDeptDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStudentShowCourseInstructors
            // 
            this.labelStudentShowCourseInstructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentShowCourseInstructors.Location = new System.Drawing.Point(112, 179);
            this.labelStudentShowCourseInstructors.Name = "labelStudentShowCourseInstructors";
            this.labelStudentShowCourseInstructors.Size = new System.Drawing.Size(120, 20);
            this.labelStudentShowCourseInstructors.TabIndex = 19;
            this.labelStudentShowCourseInstructors.Text = "Instructors";
            this.labelStudentShowCourseInstructors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewStudentShowCourseInstructors
            // 
            this.dataGridViewStudentShowCourseInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentShowCourseInstructors.Location = new System.Drawing.Point(17, 200);
            this.dataGridViewStudentShowCourseInstructors.Name = "dataGridViewStudentShowCourseInstructors";
            this.dataGridViewStudentShowCourseInstructors.Size = new System.Drawing.Size(310, 120);
            this.dataGridViewStudentShowCourseInstructors.TabIndex = 18;
            // 
            // labelStudentShowCourseTitle
            // 
            this.labelStudentShowCourseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentShowCourseTitle.Location = new System.Drawing.Point(112, 129);
            this.labelStudentShowCourseTitle.Name = "labelStudentShowCourseTitle";
            this.labelStudentShowCourseTitle.Size = new System.Drawing.Size(120, 20);
            this.labelStudentShowCourseTitle.TabIndex = 17;
            this.labelStudentShowCourseTitle.Text = "Course Title";
            this.labelStudentShowCourseTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStudentShowCourseDept
            // 
            this.labelStudentShowCourseDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentShowCourseDept.Location = new System.Drawing.Point(32, 49);
            this.labelStudentShowCourseDept.Name = "labelStudentShowCourseDept";
            this.labelStudentShowCourseDept.Size = new System.Drawing.Size(120, 20);
            this.labelStudentShowCourseDept.TabIndex = 16;
            this.labelStudentShowCourseDept.Text = "Department Code";
            this.labelStudentShowCourseDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStudentShowCourseNumberDisplay
            // 
            this.labelStudentShowCourseNumberDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStudentShowCourseNumberDisplay.Location = new System.Drawing.Point(172, 89);
            this.labelStudentShowCourseNumberDisplay.Name = "labelStudentShowCourseNumberDisplay";
            this.labelStudentShowCourseNumberDisplay.Size = new System.Drawing.Size(140, 20);
            this.labelStudentShowCourseNumberDisplay.TabIndex = 25;
            this.labelStudentShowCourseNumberDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStudentShowCourseNumber
            // 
            this.labelStudentShowCourseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentShowCourseNumber.Location = new System.Drawing.Point(32, 89);
            this.labelStudentShowCourseNumber.Name = "labelStudentShowCourseNumber";
            this.labelStudentShowCourseNumber.Size = new System.Drawing.Size(120, 20);
            this.labelStudentShowCourseNumber.TabIndex = 24;
            this.labelStudentShowCourseNumber.Text = "Course Number";
            this.labelStudentShowCourseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormStudentShowCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.labelStudentShowCourseNumberDisplay);
            this.Controls.Add(this.labelStudentShowCourseNumber);
            this.Controls.Add(this.labelStudentCourseInformation);
            this.Controls.Add(this.buttonStudentShowCourseOK);
            this.Controls.Add(this.labelStudentShowCourseTitleDisplay);
            this.Controls.Add(this.labelStudentShowCourseDeptDisplay);
            this.Controls.Add(this.labelStudentShowCourseInstructors);
            this.Controls.Add(this.dataGridViewStudentShowCourseInstructors);
            this.Controls.Add(this.labelStudentShowCourseTitle);
            this.Controls.Add(this.labelStudentShowCourseDept);
            this.Name = "FormStudentShowCourse";
            this.Text = "Show Course Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentShowCourseInstructors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStudentCourseInformation;
        private System.Windows.Forms.Button buttonStudentShowCourseOK;
        private System.Windows.Forms.Label labelStudentShowCourseTitleDisplay;
        private System.Windows.Forms.Label labelStudentShowCourseDeptDisplay;
        private System.Windows.Forms.Label labelStudentShowCourseInstructors;
        private System.Windows.Forms.DataGridView dataGridViewStudentShowCourseInstructors;
        private System.Windows.Forms.Label labelStudentShowCourseTitle;
        private System.Windows.Forms.Label labelStudentShowCourseDept;
        private System.Windows.Forms.Label labelStudentShowCourseNumberDisplay;
        private System.Windows.Forms.Label labelStudentShowCourseNumber;
    }
}