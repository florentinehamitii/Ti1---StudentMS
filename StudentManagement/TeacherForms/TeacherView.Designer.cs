
namespace StudentManagement.TeacherForms
{
    partial class TeacherView
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlActive = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblGrades = new System.Windows.Forms.Label();
            this.btnDelGrades = new System.Windows.Forms.Button();
            this.btnUpdGrades = new System.Windows.Forms.Button();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnAddGrades = new System.Windows.Forms.Button();
            this.pnlLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Thistle;
            this.pnlContent.Location = new System.Drawing.Point(196, 1);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(603, 449);
            this.pnlContent.TabIndex = 3;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Controls.Add(this.pnlMain);
            this.pnlLogo.Controls.Add(this.flowLayoutPanel1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(189, 75);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(194, 1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(606, 449);
            this.pnlMain.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(194, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(606, 447);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.pnlActive);
            this.panel1.Controls.Add(this.lblCourses);
            this.panel1.Controls.Add(this.lblGrades);
            this.panel1.Controls.Add(this.btnDelGrades);
            this.panel1.Controls.Add(this.btnUpdGrades);
            this.panel1.Controls.Add(this.btnViewCourses);
            this.panel1.Controls.Add(this.btnAddGrades);
            this.panel1.Controls.Add(this.pnlLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 450);
            this.panel1.TabIndex = 2;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlActive.Location = new System.Drawing.Point(1, 326);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(10, 40);
            this.pnlActive.TabIndex = 0;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.ForeColor = System.Drawing.Color.LightGreen;
            this.lblCourses.Location = new System.Drawing.Point(56, 271);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(91, 26);
            this.lblCourses.TabIndex = 8;
            this.lblCourses.Text = "Courses";
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrades.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblGrades.Location = new System.Drawing.Point(47, 78);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(82, 26);
            this.lblGrades.TabIndex = 7;
            this.lblGrades.Text = "Grades";
            // 
            // btnDelGrades
            // 
            this.btnDelGrades.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelGrades.FlatAppearance.BorderSize = 0;
            this.btnDelGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelGrades.Font = new System.Drawing.Font("Montserrat", 14F);
            this.btnDelGrades.ForeColor = System.Drawing.Color.White;
            this.btnDelGrades.Location = new System.Drawing.Point(12, 189);
            this.btnDelGrades.Name = "btnDelGrades";
            this.btnDelGrades.Size = new System.Drawing.Size(177, 40);
            this.btnDelGrades.TabIndex = 3;
            this.btnDelGrades.Text = "Delete";
            this.btnDelGrades.UseVisualStyleBackColor = true;
            this.btnDelGrades.Click += new System.EventHandler(this.btnDelGrades_Click);
            // 
            // btnUpdGrades
            // 
            this.btnUpdGrades.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdGrades.FlatAppearance.BorderSize = 0;
            this.btnUpdGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdGrades.Font = new System.Drawing.Font("Montserrat", 14F);
            this.btnUpdGrades.ForeColor = System.Drawing.Color.White;
            this.btnUpdGrades.Location = new System.Drawing.Point(12, 148);
            this.btnUpdGrades.Name = "btnUpdGrades";
            this.btnUpdGrades.Size = new System.Drawing.Size(177, 40);
            this.btnUpdGrades.TabIndex = 2;
            this.btnUpdGrades.Text = "Update";
            this.btnUpdGrades.UseVisualStyleBackColor = true;
            this.btnUpdGrades.Click += new System.EventHandler(this.btnUpdGrades_Click);
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewCourses.FlatAppearance.BorderSize = 0;
            this.btnViewCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCourses.Font = new System.Drawing.Font("Montserrat", 14F);
            this.btnViewCourses.ForeColor = System.Drawing.Color.White;
            this.btnViewCourses.Location = new System.Drawing.Point(11, 326);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(177, 40);
            this.btnViewCourses.TabIndex = 4;
            this.btnViewCourses.Text = "View";
            this.btnViewCourses.UseVisualStyleBackColor = true;
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);
            // 
            // btnAddGrades
            // 
            this.btnAddGrades.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddGrades.FlatAppearance.BorderSize = 0;
            this.btnAddGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGrades.Font = new System.Drawing.Font("Montserrat", 14F);
            this.btnAddGrades.ForeColor = System.Drawing.Color.White;
            this.btnAddGrades.Location = new System.Drawing.Point(12, 107);
            this.btnAddGrades.Name = "btnAddGrades";
            this.btnAddGrades.Size = new System.Drawing.Size(177, 40);
            this.btnAddGrades.TabIndex = 1;
            this.btnAddGrades.Text = "Add";
            this.btnAddGrades.UseVisualStyleBackColor = true;
            this.btnAddGrades.Click += new System.EventHandler(this.btnAddGrades_Click);
            // 
            // TeacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherView";
            this.Text = "TeacherVIew";
            this.pnlLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlActive;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.Button btnDelGrades;
        private System.Windows.Forms.Button btnUpdGrades;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Button btnAddGrades;
    }
}