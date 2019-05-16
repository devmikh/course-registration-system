namespace CourseRegistrationSystem.Forms
{
    partial class FormAdminShowInstructor
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
            this.buttonAdminShowInstructorOK = new System.Windows.Forms.Button();
            this.labelAdminShowInstructorNameDisplay = new System.Windows.Forms.Label();
            this.labelAdminShowInstructorIdDisplay = new System.Windows.Forms.Label();
            this.labelAdminShowInstructorCourses = new System.Windows.Forms.Label();
            this.dataGridViewAdminShowInstructorCourses = new System.Windows.Forms.DataGridView();
            this.labelAdminShowInstructorName = new System.Windows.Forms.Label();
            this.labelAdminShowInstructorId = new System.Windows.Forms.Label();
            this.labelAdminInstructorInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminShowInstructorCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdminShowInstructorOK
            // 
            this.buttonAdminShowInstructorOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminShowInstructorOK.Location = new System.Drawing.Point(132, 285);
            this.buttonAdminShowInstructorOK.Name = "buttonAdminShowInstructorOK";
            this.buttonAdminShowInstructorOK.Size = new System.Drawing.Size(80, 30);
            this.buttonAdminShowInstructorOK.TabIndex = 13;
            this.buttonAdminShowInstructorOK.Text = "OK";
            this.buttonAdminShowInstructorOK.UseVisualStyleBackColor = true;
            this.buttonAdminShowInstructorOK.Click += new System.EventHandler(this.buttonAdminShowInstructorOK_Click);
            // 
            // labelAdminShowInstructorNameDisplay
            // 
            this.labelAdminShowInstructorNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdminShowInstructorNameDisplay.Location = new System.Drawing.Point(172, 89);
            this.labelAdminShowInstructorNameDisplay.Name = "labelAdminShowInstructorNameDisplay";
            this.labelAdminShowInstructorNameDisplay.Size = new System.Drawing.Size(140, 20);
            this.labelAdminShowInstructorNameDisplay.TabIndex = 12;
            this.labelAdminShowInstructorNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAdminShowInstructorIdDisplay
            // 
            this.labelAdminShowInstructorIdDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdminShowInstructorIdDisplay.Location = new System.Drawing.Point(172, 49);
            this.labelAdminShowInstructorIdDisplay.Name = "labelAdminShowInstructorIdDisplay";
            this.labelAdminShowInstructorIdDisplay.Size = new System.Drawing.Size(50, 20);
            this.labelAdminShowInstructorIdDisplay.TabIndex = 11;
            this.labelAdminShowInstructorIdDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAdminShowInstructorCourses
            // 
            this.labelAdminShowInstructorCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminShowInstructorCourses.Location = new System.Drawing.Point(112, 134);
            this.labelAdminShowInstructorCourses.Name = "labelAdminShowInstructorCourses";
            this.labelAdminShowInstructorCourses.Size = new System.Drawing.Size(120, 20);
            this.labelAdminShowInstructorCourses.TabIndex = 10;
            this.labelAdminShowInstructorCourses.Text = "Courses";
            this.labelAdminShowInstructorCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAdminShowInstructorCourses
            // 
            this.dataGridViewAdminShowInstructorCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminShowInstructorCourses.Location = new System.Drawing.Point(17, 159);
            this.dataGridViewAdminShowInstructorCourses.Name = "dataGridViewAdminShowInstructorCourses";
            this.dataGridViewAdminShowInstructorCourses.Size = new System.Drawing.Size(310, 120);
            this.dataGridViewAdminShowInstructorCourses.TabIndex = 9;
            // 
            // labelAdminShowInstructorName
            // 
            this.labelAdminShowInstructorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminShowInstructorName.Location = new System.Drawing.Point(32, 89);
            this.labelAdminShowInstructorName.Name = "labelAdminShowInstructorName";
            this.labelAdminShowInstructorName.Size = new System.Drawing.Size(120, 20);
            this.labelAdminShowInstructorName.TabIndex = 8;
            this.labelAdminShowInstructorName.Text = "Instructor Name";
            this.labelAdminShowInstructorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAdminShowInstructorId
            // 
            this.labelAdminShowInstructorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminShowInstructorId.Location = new System.Drawing.Point(32, 49);
            this.labelAdminShowInstructorId.Name = "labelAdminShowInstructorId";
            this.labelAdminShowInstructorId.Size = new System.Drawing.Size(120, 20);
            this.labelAdminShowInstructorId.TabIndex = 7;
            this.labelAdminShowInstructorId.Text = "Instructor ID";
            this.labelAdminShowInstructorId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAdminInstructorInformation
            // 
            this.labelAdminInstructorInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminInstructorInformation.Location = new System.Drawing.Point(72, 9);
            this.labelAdminInstructorInformation.Name = "labelAdminInstructorInformation";
            this.labelAdminInstructorInformation.Size = new System.Drawing.Size(200, 30);
            this.labelAdminInstructorInformation.TabIndex = 15;
            this.labelAdminInstructorInformation.Text = "Instructor Information";
            this.labelAdminInstructorInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdminShowInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.labelAdminInstructorInformation);
            this.Controls.Add(this.buttonAdminShowInstructorOK);
            this.Controls.Add(this.labelAdminShowInstructorNameDisplay);
            this.Controls.Add(this.labelAdminShowInstructorIdDisplay);
            this.Controls.Add(this.labelAdminShowInstructorCourses);
            this.Controls.Add(this.dataGridViewAdminShowInstructorCourses);
            this.Controls.Add(this.labelAdminShowInstructorName);
            this.Controls.Add(this.labelAdminShowInstructorId);
            this.Name = "FormAdminShowInstructor";
            this.Text = "Show Instructor Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminShowInstructorCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdminShowInstructorOK;
        private System.Windows.Forms.Label labelAdminShowInstructorNameDisplay;
        private System.Windows.Forms.Label labelAdminShowInstructorIdDisplay;
        private System.Windows.Forms.Label labelAdminShowInstructorCourses;
        private System.Windows.Forms.DataGridView dataGridViewAdminShowInstructorCourses;
        private System.Windows.Forms.Label labelAdminShowInstructorName;
        private System.Windows.Forms.Label labelAdminShowInstructorId;
        private System.Windows.Forms.Label labelAdminInstructorInformation;
    }
}