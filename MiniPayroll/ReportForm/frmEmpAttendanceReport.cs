using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class frmEmpAttendanceReport : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        public frmEmpAttendanceReport()
        {
            InitializeComponent();
        }

        private void frmEmpAttendanceReport_Load(object sender, EventArgs e)
        {
            cryrpt.Load(@"C:\Users\Saranya\Documents\Visual Studio 2013\Projects\MiniPayroll\MiniPayroll\MiniPayroll\Reports\EmpAttendance.rpt");
            Connection con = new Connection();
            DataSet dst = new DataSet();
            con.dataGet("Select * from Employee");
            con.sda.Fill(dst, "Employee");
            con.dataGet("Select * from EmpAttendance");
            con.sda.Fill(dst, "EmpAttendance");
            cryrpt.SetDataSource(dst);
            crystalReportViewer1.ReportSource = cryrpt;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportOptions exportOption;
            DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
            SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Pdf Files|*.pdf";
            sfd.Filter = "Excel|*.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                diskFileDestinationOptions.DiskFileName = sfd.FileName;
            }
            exportOption = cryrpt.ExportOptions;
            {
                exportOption.ExportDestinationType = ExportDestinationType.DiskFile;
                //exportOption.ExportFormatType = ExportFormatType.PortableDocFormat;
                exportOption.ExportFormatType = ExportFormatType.Excel;
                exportOption.ExportDestinationOptions = diskFileDestinationOptions;
                //exportOption.ExportFormatOptions = new PdfRtfWordFormatOptions();
                exportOption.ExportFormatOptions = new ExcelFormatOptions();
            }
            cryrpt.Export();
        }
    }
}
