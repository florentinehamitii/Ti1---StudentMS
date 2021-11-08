
namespace StudentManagement
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnlLogginMenu = new System.Windows.Forms.Panel();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.pnlLoginActive = new System.Windows.Forms.Panel();
            this.pnlLoginForm = new System.Windows.Forms.Panel();
            this.pnlLogginMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(0, 8);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(398, 50);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "ADMINISTRATOR";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pnlLogginMenu
            // 
            this.pnlLogginMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlLogginMenu.Controls.Add(this.btnTeacher);
            this.pnlLogginMenu.Controls.Add(this.btnAdmin);
            this.pnlLogginMenu.Location = new System.Drawing.Point(2, 4);
            this.pnlLogginMenu.Name = "pnlLogginMenu";
            this.pnlLogginMenu.Size = new System.Drawing.Size(797, 58);
            this.pnlLogginMenu.TabIndex = 1;
            // 
            // btnTeacher
            // 
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.ForeColor = System.Drawing.Color.White;
            this.btnTeacher.Location = new System.Drawing.Point(401, 8);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(394, 50);
            this.btnTeacher.TabIndex = 2;
            this.btnTeacher.Text = "PROFESOR";
            this.btnTeacher.UseVisualStyleBackColor = true;
            // 
            // pnlLoginActive
            // 
            this.pnlLoginActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlLoginActive.Location = new System.Drawing.Point(2, 4);
            this.pnlLoginActive.Name = "pnlLoginActive";
            this.pnlLoginActive.Size = new System.Drawing.Size(398, 8);
            this.pnlLoginActive.TabIndex = 2;
            // 
            // pnlLoginForm
            // 
            this.pnlLoginForm.Location = new System.Drawing.Point(2, 68);
            this.pnlLoginForm.Name = "pnlLoginForm";
            this.pnlLoginForm.Size = new System.Drawing.Size(797, 386);
            this.pnlLoginForm.TabIndex = 3;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLoginForm);
            this.Controls.Add(this.pnlLoginActive);
            this.Controls.Add(this.pnlLogginMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.pnlLogginMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnlLogginMenu;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Panel pnlLoginActive;
        private System.Windows.Forms.Panel pnlLoginForm;
    }
}