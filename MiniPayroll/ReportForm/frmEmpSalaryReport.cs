using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPayroll.ReportForm
{
    public partial class frmEmpSalaryReport : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        public frmEmpSalaryReport()
        {
            InitializeComponent();
        }

        private void frmEmpSalaryReport_Load(object sender, EventArgs e)
        {
            cryrpt.Load(@"C:\Users\Saranya\Documents\Visual Studio 2013\Projects\MiniPayroll\MiniPayroll\MiniPayroll\Reports\EmpSalary.rpt");
            Connection con = new Connection();
            DataSet dst = new DataSet();
            con.dataGet("Select * from Employee");
            con.sda.Fill(dst, "Employee");
            con.dataGet("Select * from EmpSalary");
            con.sda.Fill(dst, "EmpSalary");
            cryrpt.SetDataSource(dst);
            crystalReportViewer1.ReportSource = cryrpt;
        }
    }
}
