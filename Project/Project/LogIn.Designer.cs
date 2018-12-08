namespace Project
{
    partial class LogIn
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
            this.AdminButton = new System.Windows.Forms.Button();
            this.TeacherButton = new System.Windows.Forms.Button();
            this.StudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.Location = new System.Drawing.Point(101, 30);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(208, 41);
            this.AdminButton.TabIndex = 3;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click_1);
            // 
            // TeacherButton
            // 
            this.TeacherButton.Location = new System.Drawing.Point(101, 128);
            this.TeacherButton.Name = "TeacherButton";
            this.TeacherButton.Size = new System.Drawing.Size(208, 41);
            this.TeacherButton.TabIndex = 4;
            this.TeacherButton.Text = "Teacher";
            this.TeacherButton.UseVisualStyleBackColor = true;
            this.TeacherButton.Click += new System.EventHandler(this.TeacherButton_Click);
            // 
            // StudentButton
            // 
            this.StudentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentButton.Location = new System.Drawing.Point(101, 223);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(208, 41);
            this.StudentButton.TabIndex = 5;
            this.StudentButton.Text = "Student";
            this.StudentButton.UseVisualStyleBackColor = true;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 358);
            this.Controls.Add(this.StudentButton);
            this.Controls.Add(this.TeacherButton);
            this.Controls.Add(this.AdminButton);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button TeacherButton;
        private System.Windows.Forms.Button StudentButton;
    }
}

