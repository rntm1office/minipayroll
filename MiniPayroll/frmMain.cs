using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPayroll
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void userRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.frmUserRegister frm = new User.frmUserRegister();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
        bool close = true;
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.frmChangePassword frm = new User.frmChangePassword();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void employeeRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.frmEmployeeRegister frm = new Employee.frmEmployeeRegister();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void employeeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.frmEmpSalary frm = new Employee.frmEmpSalary();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void employeeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.frmEmpAttendance frm = new Employee.frmEmpAttendance();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void attendanceViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.frmAttendanceView frm = new Employee.frmAttendanceView();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void salaryProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.frmSalaryProcess frm = new Employee.frmSalaryProcess();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void userReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.frmUserReport frm = new ReportForm.frmUserReport();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void employeeSalaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.frmEmpSalaryReport frm = new ReportForm.frmEmpSalaryReport();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void employeeAttendanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.frmEmpAttendanceReport frm = new ReportForm.frmEmpAttendanceReport();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.frmEmpReport frm = new ReportForm.frmEmpReport();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }      
    }
}
