namespace CourseRegistrationSystem.Forms
{
    partial class FormAddNewDepartment
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
            this.labelAddNewDepartment = new System.Windows.Forms.Label();
            this.buttonAddDepartment = new System.Windows.Forms.Button();
            this.labelAddNewDepartmentCode = new System.Windows.Forms.Label();
            this.textBoxAddNewDepartmentCode = new System.Windows.Forms.TextBox();
            this.labelAddNewDepartmentName = new System.Windows.Forms.Label();
            this.textBoxAddNewDepartmentName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAddNewDepartment
            // 
            this.labelAddNewDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNewDepartment.Location = new System.Drawing.Point(95, 9);
            this.labelAddNewDepartment.Name = "labelAddNewDepartment";
            this.labelAddNewDepartment.Size = new System.Drawing.Size(170, 30);
            this.labelAddNewDepartment.TabIndex = 1;
            this.labelAddNewDepartment.Text = "Add New Department";
            this.labelAddNewDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddDepartment
            // 
            this.buttonAddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDepartment.Location = new System.Drawing.Point(112, 155);
            this.buttonAddDepartment.Name = "buttonAddDepartment";
            this.buttonAddDepartment.Size = new System.Drawing.Size(120, 30);
            this.buttonAddDepartment.TabIndex = 6;
            this.buttonAddDepartment.Text = "Add Department";
            this.buttonAddDepartment.UseVisualStyleBackColor = true;
            this.buttonAddDepartment.Click += new System.EventHandler(this.buttonAddDepartment_Click);
            // 
            // labelAddNewDepartmentCode
            // 
            this.labelAddNewDepartmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNewDepartmentCode.Location = new System.Drawing.Point(32, 70);
            this.labelAddNewDepartmentCode.Name = "labelAddNewDepartmentCode";
            this.labelAddNewDepartmentCode.Size = new System.Drawing.Size(120, 20);
            this.labelAddNewDepartmentCode.TabIndex = 5;
            this.labelAddNewDepartmentCode.Text = "Department Code";
            this.labelAddNewDepartmentCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAddNewDepartmentCode
            // 
            this.textBoxAddNewDepartmentCode.Location = new System.Drawing.Point(172, 70);
            this.textBoxAddNewDepartmentCode.Name = "textBoxAddNewDepartmentCode";
            this.textBoxAddNewDepartmentCode.Size = new System.Drawing.Size(140, 20);
            this.textBoxAddNewDepartmentCode.TabIndex = 4;
            // 
            // labelAddNewDepartmentName
            // 
            this.labelAddNewDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNewDepartmentName.Location = new System.Drawing.Point(32, 110);
            this.labelAddNewDepartmentName.Name = "labelAddNewDepartmentName";
            this.labelAddNewDepartmentName.Size = new System.Drawing.Size(120, 20);
            this.labelAddNewDepartmentName.TabIndex = 8;
            this.labelAddNewDepartmentName.Text = "Department Name";
            this.labelAddNewDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAddNewDepartmentName
            // 
            this.textBoxAddNewDepartmentName.Location = new System.Drawing.Point(172, 110);
            this.textBoxAddNewDepartmentName.Name = "textBoxAddNewDepartmentName";
            this.textBoxAddNewDepartmentName.Size = new System.Drawing.Size(140, 20);
            this.textBoxAddNewDepartmentName.TabIndex = 7;
            // 
            // FormAddNewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.labelAddNewDepartmentName);
            this.Controls.Add(this.textBoxAddNewDepartmentName);
            this.Controls.Add(this.buttonAddDepartment);
            this.Controls.Add(this.labelAddNewDepartmentCode);
            this.Controls.Add(this.textBoxAddNewDepartmentCode);
            this.Controls.Add(this.labelAddNewDepartment);
            this.Name = "FormAddNewDepartment";
            this.Text = "Add New Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddNewDepartment;
        private System.Windows.Forms.Button buttonAddDepartment;
        private System.Windows.Forms.Label labelAddNewDepartmentCode;
        private System.Windows.Forms.TextBox textBoxAddNewDepartmentCode;
        private System.Windows.Forms.Label labelAddNewDepartmentName;
        private System.Windows.Forms.TextBox textBoxAddNewDepartmentName;
    }
}