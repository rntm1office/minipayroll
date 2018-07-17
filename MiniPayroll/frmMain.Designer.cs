namespace MiniPayroll
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeSalaryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeAttendanceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.employeeToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRegisterToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.toolStripMenuItem1.Text = "User";
            // 
            // userRegisterToolStripMenuItem
            // 
            this.userRegisterToolStripMenuItem.Name = "userRegisterToolStripMenuItem";
            this.userRegisterToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.userRegisterToolStripMenuItem.Text = "User Register";
            this.userRegisterToolStripMenuItem.Click += new System.EventHandler(this.userRegisterToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeRegisterToolStripMenuItem,
            this.employeeSalaryToolStripMenuItem,
            this.employeeAttendanceToolStripMenuItem,
            this.attendanceViewToolStripMenuItem,
            this.salaryProcessToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // employeeRegisterToolStripMenuItem
            // 
            this.employeeRegisterToolStripMenuItem.Name = "employeeRegisterToolStripMenuItem";
            this.employeeRegisterToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.employeeRegisterToolStripMenuItem.Text = "Employee Register";
            this.employeeRegisterToolStripMenuItem.Click += new System.EventHandler(this.employeeRegisterToolStripMenuItem_Click);
            // 
            // employeeSalaryToolStripMenuItem
            // 
            this.employeeSalaryToolStripMenuItem.Name = "employeeSalaryToolStripMenuItem";
            this.employeeSalaryToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.employeeSalaryToolStripMenuItem.Text = "Employee Salary";
            this.employeeSalaryToolStripMenuItem.Click += new System.EventHandler(this.employeeSalaryToolStripMenuItem_Click);
            // 
            // employeeAttendanceToolStripMenuItem
            // 
            this.employeeAttendanceToolStripMenuItem.Name = "employeeAttendanceToolStripMenuItem";
            this.employeeAttendanceToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.employeeAttendanceToolStripMenuItem.Text = "Employee Attendance";
            this.employeeAttendanceToolStripMenuItem.Click += new System.EventHandler(this.employeeAttendanceToolStripMenuItem_Click);
            // 
            // attendanceViewToolStripMenuItem
            // 
            this.attendanceViewToolStripMenuItem.Name = "attendanceViewToolStripMenuItem";
            this.attendanceViewToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.attendanceViewToolStripMenuItem.Text = "Attendance View";
            this.attendanceViewToolStripMenuItem.Click += new System.EventHandler(this.attendanceViewToolStripMenuItem_Click);
            // 
            // salaryProcessToolStripMenuItem
            // 
            this.salaryProcessToolStripMenuItem.Name = "salaryProcessToolStripMenuItem";
            this.salaryProcessToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.salaryProcessToolStripMenuItem.Text = "Salary Process";
            this.salaryProcessToolStripMenuItem.Click += new System.EventHandler(this.salaryProcessToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userReportToolStripMenuItem,
            this.employeeSalaryReportToolStripMenuItem,
            this.employeeAttendanceReportToolStripMenuItem,
            this.employeeReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // userReportToolStripMenuItem
            // 
            this.userReportToolStripMenuItem.Name = "userReportToolStripMenuItem";
            this.userReportToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.userReportToolStripMenuItem.Text = "User Report";
            this.userReportToolStripMenuItem.Click += new System.EventHandler(this.userReportToolStripMenuItem_Click);
            // 
            // employeeSalaryReportToolStripMenuItem
            // 
            this.employeeSalaryReportToolStripMenuItem.Name = "employeeSalaryReportToolStripMenuItem";
            this.employeeSalaryReportToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.employeeSalaryReportToolStripMenuItem.Text = "Employee Salary Report";
            this.employeeSalaryReportToolStripMenuItem.Click += new System.EventHandler(this.employeeSalaryReportToolStripMenuItem_Click);
            // 
            // employeeAttendanceReportToolStripMenuItem
            // 
            this.employeeAttendanceReportToolStripMenuItem.Name = "employeeAttendanceReportToolStripMenuItem";
            this.employeeAttendanceReportToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.employeeAttendanceReportToolStripMenuItem.Text = "Employee Attendance Report";
            this.employeeAttendanceReportToolStripMenuItem.Click += new System.EventHandler(this.employeeAttendanceReportToolStripMenuItem_Click);
            // 
            // employeeReportToolStripMenuItem
            // 
            this.employeeReportToolStripMenuItem.Name = "employeeReportToolStripMenuItem";
            this.employeeReportToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.employeeReportToolStripMenuItem.Text = "Employee Report";
            this.employeeReportToolStripMenuItem.Click += new System.EventHandler(this.employeeReportToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 456);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeSalaryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeAttendanceReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem;
    }
}