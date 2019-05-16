namespace CourseRegistrationSystem
{
    partial class FormAddNewInstructor
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
            this.labelAddNewInstructor = new System.Windows.Forms.Label();
            this.buttonAddInstructor = new System.Windows.Forms.Button();
            this.labelAddNewInstructorName = new System.Windows.Forms.Label();
            this.textBoxAddNewInstructorName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAddNewInstructor
            // 
            this.labelAddNewInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNewInstructor.Location = new System.Drawing.Point(97, 10);
            this.labelAddNewInstructor.Name = "labelAddNewInstructor";
            this.labelAddNewInstructor.Size = new System.Drawing.Size(150, 30);
            this.labelAddNewInstructor.TabIndex = 1;
            this.labelAddNewInstructor.Text = "Add New Instructor";
            this.labelAddNewInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddInstructor
            // 
            this.buttonAddInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddInstructor.Location = new System.Drawing.Point(112, 120);
            this.buttonAddInstructor.Name = "buttonAddInstructor";
            this.buttonAddInstructor.Size = new System.Drawing.Size(120, 30);
            this.buttonAddInstructor.TabIndex = 6;
            this.buttonAddInstructor.Text = "Add Instructor";
            this.buttonAddInstructor.UseVisualStyleBackColor = true;
            this.buttonAddInstructor.Click += new System.EventHandler(this.buttonAddInstructor_Click);
            // 
            // labelAddNewInstructorName
            // 
            this.labelAddNewInstructorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNewInstructorName.Location = new System.Drawing.Point(32, 70);
            this.labelAddNewInstructorName.Name = "labelAddNewInstructorName";
            this.labelAddNewInstructorName.Size = new System.Drawing.Size(120, 20);
            this.labelAddNewInstructorName.TabIndex = 5;
            this.labelAddNewInstructorName.Text = "Instructor Name";
            this.labelAddNewInstructorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAddNewInstructorName
            // 
            this.textBoxAddNewInstructorName.Location = new System.Drawing.Point(172, 70);
            this.textBoxAddNewInstructorName.Name = "textBoxAddNewInstructorName";
            this.textBoxAddNewInstructorName.Size = new System.Drawing.Size(140, 20);
            this.textBoxAddNewInstructorName.TabIndex = 4;
            // 
            // FormAddNewInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 161);
            this.Controls.Add(this.buttonAddInstructor);
            this.Controls.Add(this.labelAddNewInstructorName);
            this.Controls.Add(this.textBoxAddNewInstructorName);
            this.Controls.Add(this.labelAddNewInstructor);
            this.Name = "FormAddNewInstructor";
            this.Text = "Add New Instructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddNewInstructor;
        private System.Windows.Forms.Button buttonAddInstructor;
        private System.Windows.Forms.Label labelAddNewInstructorName;
        private System.Windows.Forms.TextBox textBoxAddNewInstructorName;
    }
}