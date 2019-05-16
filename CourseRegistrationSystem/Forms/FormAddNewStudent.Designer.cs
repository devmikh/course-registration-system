namespace CourseRegistrationSystem
{
    partial class FormAddNewStudent
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
            this.labelAddNewStudent = new System.Windows.Forms.Label();
            this.textBoxAddNewStudentName = new System.Windows.Forms.TextBox();
            this.labelAddNewStudentName = new System.Windows.Forms.Label();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddNewStudent
            // 
            this.labelAddNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNewStudent.Location = new System.Drawing.Point(97, 10);
            this.labelAddNewStudent.Name = "labelAddNewStudent";
            this.labelAddNewStudent.Size = new System.Drawing.Size(150, 30);
            this.labelAddNewStudent.TabIndex = 0;
            this.labelAddNewStudent.Text = "Add New Student";
            this.labelAddNewStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAddNewStudentName
            // 
            this.textBoxAddNewStudentName.Location = new System.Drawing.Point(172, 70);
            this.textBoxAddNewStudentName.Name = "textBoxAddNewStudentName";
            this.textBoxAddNewStudentName.Size = new System.Drawing.Size(140, 20);
            this.textBoxAddNewStudentName.TabIndex = 1;
            // 
            // labelAddNewStudentName
            // 
            this.labelAddNewStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNewStudentName.Location = new System.Drawing.Point(32, 70);
            this.labelAddNewStudentName.Name = "labelAddNewStudentName";
            this.labelAddNewStudentName.Size = new System.Drawing.Size(120, 20);
            this.labelAddNewStudentName.TabIndex = 2;
            this.labelAddNewStudentName.Text = "Student Name";
            this.labelAddNewStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddStudent.Location = new System.Drawing.Point(112, 120);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(120, 30);
            this.buttonAddStudent.TabIndex = 3;
            this.buttonAddStudent.Text = "Add Student";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // FormAddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 161);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.labelAddNewStudentName);
            this.Controls.Add(this.textBoxAddNewStudentName);
            this.Controls.Add(this.labelAddNewStudent);
            this.Name = "FormAddNewStudent";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddNewStudent;
        private System.Windows.Forms.TextBox textBoxAddNewStudentName;
        private System.Windows.Forms.Label labelAddNewStudentName;
        private System.Windows.Forms.Button buttonAddStudent;
    }
}