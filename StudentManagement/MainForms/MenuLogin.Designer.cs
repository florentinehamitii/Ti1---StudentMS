
namespace StudentManagement.MainForms
{
    partial class MenuLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnlLoginForm = new System.Windows.Forms.Panel();
            this.pnlLoginActive = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnTeacher);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 58);
            this.panel1.TabIndex = 0;
            // 
            // btnTeacher
            // 
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.ForeColor = System.Drawing.Color.White;
            this.btnTeacher.Location = new System.Drawing.Point(399, 8);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(398, 50);
            this.btnTeacher.TabIndex = 0;
            this.btnTeacher.Text = "TEACHER";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(0, 8);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(398, 50);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "ADMINISTRATOR";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pnlLoginForm
            // 
            this.pnlLoginForm.BackColor = System.Drawing.Color.Thistle;
            this.pnlLoginForm.Location = new System.Drawing.Point(2, 68);
            this.pnlLoginForm.Name = "pnlLoginForm";
            this.pnlLoginForm.Size = new System.Drawing.Size(797, 386);
            this.pnlLoginForm.TabIndex = 1;
            // 
            // pnlLoginActive
            // 
            this.pnlLoginActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlLoginActive.Location = new System.Drawing.Point(2, 4);
            this.pnlLoginActive.Name = "pnlLoginActive";
            this.pnlLoginActive.Size = new System.Drawing.Size(398, 8);
            this.pnlLoginActive.TabIndex = 2;
            // 
            // MenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLoginActive);
            this.Controls.Add(this.pnlLoginForm);
            this.Controls.Add(this.panel1);
            this.Name = "MenuLogin";
            this.Text = "MenuLogin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLoginForm;
        private System.Windows.Forms.Panel pnlLoginActive;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnTeacher;
    }
}