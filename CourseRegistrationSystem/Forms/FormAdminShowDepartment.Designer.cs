namespace CourseRegistrationSystem.Forms
{
    partial class FormAdminShowDepartment
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
            this.labelAdminDepartmentInformation = new System.Windows.Forms.Label();
            this.buttonAdminShowDepartmentOK = new System.Windows.Forms.Button();
            this.labelAdminShowDepartmentNameDisplay = new System.Windows.Forms.Label();
            this.labelAdminShowDepartmentCodeDisplay = new System.Windows.Forms.Label();
            this.labelAdminShowDepartmentCourses = new System.Windows.Forms.Label();
            this.dataGridViewAdminShowDepartmentCourses = new System.Windows.Forms.DataGridView();
            this.labelAdminShowDepartmentName = new System.Windows.Forms.Label();
            this.labelAdminShowDepartmentCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminShowDepartmentCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdminDepartmentInformation
            // 
            this.labelAdminDepartmentInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminDepartmentInformation.Location = new System.Drawing.Point(72, 9);
            this.labelAdminDepartmentInformation.Name = "labelAdminDepartmentInformation";
            this.labelAdminDepartmentInformation.Size = new System.Drawing.Size(200, 30);
            this.labelAdminDepartmentInformation.TabIndex = 23;
            this.labelAdminDepartmentInformation.Text = "Department Information";
            this.labelAdminDepartmentInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdminShowDepartmentOK
            // 
            this.buttonAdminShowDepartmentOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminShowDepartmentOK.Location = new System.Drawing.Point(112, 284);
            this.buttonAdminShowDepartmentOK.Name = "buttonAdminShowDepartmentOK";
            this.buttonAdminShowDepartmentOK.Size = new System.Drawing.Size(120, 30);
            this.buttonAdminShowDepartmentOK.TabIndex = 22;
            this.buttonAdminShowDepartmentOK.Text = "OK";
            this.buttonAdminShowDepartmentOK.UseVisualStyleBackColor = true;
            this.buttonAdminShowDepartmentOK.Click += new System.EventHandler(this.buttonAdminShowDepartmentOK_Click);
            // 
            // labelAdminShowDepartmentNameDisplay
            // 
            this.labelAdminShowDepartmentNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdminShowDepartmentNameDisplay.Location = new System.Drawing.Point(172, 89);
            this.labelAdminShowDepartmentNameDisplay.Name = "labelAdminShowDepartmentNameDisplay";
            this.labelAdminShowDepartmentNameDisplay.Size = new System.Drawing.Size(140, 20);
            this.labelAdminShowDepartmentNameDisplay.TabIndex = 21;
            this.labelAdminShowDepartmentNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAdminShowDepartmentCodeDisplay
            // 
            this.labelAdminShowDepartmentCodeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdminShowDepartmentCodeDisplay.Location = new System.Drawing.Point(172, 49);
            this.labelAdminShowDepartmentCodeDisplay.Name = "labelAdminShowDepartmentCodeDisplay";
            this.labelAdminShowDepartmentCodeDisplay.Size = new System.Drawing.Size(60, 20);
            this.labelAdminShowDepartmentCodeDisplay.TabIndex = 20;
            this.labelAdminShowDepartmentCodeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAdminShowDepartmentCourses
            // 
            this.labelAdminShowDepartmentCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminShowDepartmentCourses.Location = new System.Drawing.Point(112, 134);
            this.labelAdminShowDepartmentCourses.Name = "labelAdminShowDepartmentCourses";
            this.labelAdminShowDepartmentCourses.Size = new System.Drawing.Size(120, 20);
            this.labelAdminShowDepartmentCourses.TabIndex = 19;
            this.labelAdminShowDepartmentCourses.Text = "Courses";
            this.labelAdminShowDepartmentCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAdminShowDepartmentCourses
            // 
            this.dataGridViewAdminShowDepartmentCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminShowDepartmentCourses.Location = new System.Drawing.Point(17, 159);
            this.dataGridViewAdminShowDepartmentCourses.Name = "dataGridViewAdminShowDepartmentCourses";
            this.dataGridViewAdminShowDepartmentCourses.Size = new System.Drawing.Size(310, 120);
            this.dataGridViewAdminShowDepartmentCourses.TabIndex = 18;
            // 
            // labelAdminShowDepartmentName
            // 
            this.labelAdminShowDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminShowDepartmentName.Location = new System.Drawing.Point(32, 89);
            this.labelAdminShowDepartmentName.Name = "labelAdminShowDepartmentName";
            this.labelAdminShowDepartmentName.Size = new System.Drawing.Size(120, 20);
            this.labelAdminShowDepartmentName.TabIndex = 17;
            this.labelAdminShowDepartmentName.Text = "Department Name";
            this.labelAdminShowDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAdminShowDepartmentCode
            // 
            this.labelAdminShowDepartmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminShowDepartmentCode.Location = new System.Drawing.Point(32, 49);
            this.labelAdminShowDepartmentCode.Name = "labelAdminShowDepartmentCode";
            this.labelAdminShowDepartmentCode.Size = new System.Drawing.Size(120, 20);
            this.labelAdminShowDepartmentCode.TabIndex = 16;
            this.labelAdminShowDepartmentCode.Text = "Department Code";
            this.labelAdminShowDepartmentCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormAdminShowDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.labelAdminDepartmentInformation);
            this.Controls.Add(this.buttonAdminShowDepartmentOK);
            this.Controls.Add(this.labelAdminShowDepartmentNameDisplay);
            this.Controls.Add(this.labelAdminShowDepartmentCodeDisplay);
            this.Controls.Add(this.labelAdminShowDepartmentCourses);
            this.Controls.Add(this.dataGridViewAdminShowDepartmentCourses);
            this.Controls.Add(this.labelAdminShowDepartmentName);
            this.Controls.Add(this.labelAdminShowDepartmentCode);
            this.Name = "FormAdminShowDepartment";
            this.Text = "Show Department Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminShowDepartmentCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAdminDepartmentInformation;
        private System.Windows.Forms.Button buttonAdminShowDepartmentOK;
        private System.Windows.Forms.Label labelAdminShowDepartmentNameDisplay;
        private System.Windows.Forms.Label labelAdminShowDepartmentCodeDisplay;
        private System.Windows.Forms.Label labelAdminShowDepartmentCourses;
        private System.Windows.Forms.DataGridView dataGridViewAdminShowDepartmentCourses;
        private System.Windows.Forms.Label labelAdminShowDepartmentName;
        private System.Windows.Forms.Label labelAdminShowDepartmentCode;
    }
}