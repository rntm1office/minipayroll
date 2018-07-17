﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPayroll.Employee
{
    public partial class frmEmpAttendance : Form
    {
        public frmEmpAttendance()
        {
            InitializeComponent();
        }

        private void txtEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtTotalDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtWorkingDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtPresent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtAbsent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private DataGridView dgview;
        private DataGridViewTextBoxColumn dgviewcol1;
        private DataGridViewTextBoxColumn dgviewcol2;

        void Search()
        {
            dgview = new DataGridView();
            dgviewcol1 = new DataGridViewTextBoxColumn();
            dgviewcol2 = new DataGridViewTextBoxColumn();
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgviewcol1, this.dgviewcol2 });
            this.dgview.Name = "dgview";
            dgview.Visible = false;
            this.dgviewcol1.Visible = false;
            this.dgviewcol2.Visible = false;
            this.dgview.AllowUserToAddRows = false;
            this.dgview.RowHeadersVisible = false;
            this.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //this.dgview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgview_KeyDown);

            this.Controls.Add(dgview);
            this.dgview.ReadOnly = true;
            dgview.BringToFront();
        }

        //Two Column
        void Search(int LX, int LY, int DW, int DH, string ColName, String ColSize)
        {
            this.dgview.Location = new System.Drawing.Point(LX, LY);
            this.dgview.Size = new System.Drawing.Size(DW, DH);

            string[] ClSize = ColSize.Split(',');
            //Size
            for (int i = 0; i < ClSize.Length; i++)
            {
                if (int.Parse(ClSize[i]) != 0)
                {
                    dgview.Columns[i].Width = int.Parse(ClSize[i]);
                }
                else
                {
                    dgview.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            //Name 
            string[] ClName = ColName.Split(',');

            for (int i = 0; i < ClName.Length; i++)
            {
                this.dgview.Columns[i].HeaderText = ClName[i];
                this.dgview.Columns[i].Visible = true;
            }
        }

        private void frmEmpAttendance_Load(object sender, EventArgs e)
        {
            Search();
            this.ActiveControl = txtEmpId;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpId.Text.Length > 0)
            {
                this.dgview.Visible = true;
                dgview.BringToFront();
                Search(90, 70, 400, 200, "Emp Id,Emp Name", "100,0");
                this.dgview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.employee_MouseDoubleClick);
                Connection con = new Connection();
                con.dataGet("Select Top(10) EmpId,Name From Employee WHERE EmpId Like '" + txtEmpId.Text + "%'");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                dgview.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dgview.Rows.Add();
                    dgview.Rows[n].Cells[0].Value = row["EmpId"].ToString();
                    dgview.Rows[n].Cells[1].Value = row["Name"].ToString();
                }
            }
            else
            {
                dgview.Visible = false;
            }
        }
        bool change = true;
        private void employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (change)
            {
                change = false;
                txtEmpId.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                txtEmpName.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                this.dgview.Visible = false;
                cmbYear.Focus();
                change = true;
            }
        }

        private void txtEmpId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(dgview.Rows.Count > 0)
                {
                    txtEmpId.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                    txtEmpName.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                    this.dgview.Visible = false;
                    cmbYear.Focus();
                }
                else
                {
                    this.dgview.Visible = false;
                }
            }
        }

        private void cmbYear_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(cmbYear.SelectedIndex != -1)
                {
                    cmbMonth.Focus();
                }
                else
                {
                    cmbYear.Focus();
                }
            }
        }

        private void cmbMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbMonth.SelectedIndex != -1)
                {
                    txtTotalDays.Focus();
                }
                else
                {
                    cmbMonth.Focus();
                }
            }
        }

        private void txtTotalDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTotalDays.Text.Length > 0)
                {
                    txtWorkingDays.Focus();
                }
                else
                {
                    txtTotalDays.Focus();
                }
            }
        }

        private void txtWorkingDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtWorkingDays.Text.Length > 0)
                {
                    txtPresent.Focus();
                }
                else
                {
                    txtWorkingDays.Focus();
                }
            }
        }

        private void txtPresent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAbsent.Focus();
            }
        }

        private void txtAbsent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLOP.Focus();
            }
        }

        private void txtLOP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }
        Connection con = new Connection();
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMonth.SelectedIndex != -1)
            {
                con.dataGet("Select * from EmpAttendance where EmpId = '"+txtEmpId.Text+"' and Year = '"+cmbYear.Text+"' and Month = '"+cmbMonth.Text+"'");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    txtTotalDays.Text = dt.Rows[0]["TotalDays"].ToString();
                    txtWorkingDays.Text = dt.Rows[0]["WorkingDays"].ToString();
                    txtPresent.Text = dt.Rows[0]["PresentDays"].ToString();
                    txtAbsent.Text = dt.Rows[0]["AbsentDays"].ToString();
                    txtLOP.Text = dt.Rows[0]["LopDays"].ToString();
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    txtTotalDays.Text = "";
                    txtWorkingDays.Text = "";
                    txtPresent.Text = "";
                    txtAbsent.Text = "";
                    txtLOP.Text = "";
                    btnSave.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }
        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtEmpId.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmpId, "Emp Id Required");
            }
            else if (string.IsNullOrEmpty(cmbYear.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbYear, "Select Year");
            }
            else if (string.IsNullOrEmpty(cmbMonth.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbMonth, "Select Month");
            }
            else if (string.IsNullOrEmpty(txtTotalDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtTotalDays, "Total Days Requried");
            }
            else if (string.IsNullOrEmpty(txtWorkingDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtWorkingDays, "Working Days Required");
            }
            else if (string.IsNullOrEmpty(txtPresent.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPresent, "Present Days Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                con.dataSend(@"INSERT INTO EmpAttendance (EmpId, Year, Month, TotalDays, WorkingDays, PresentDays, AbsentDays, LopDays)
                              VALUES ('"+txtEmpId.Text+"','"+cmbYear.Text+"','"+cmbMonth.Text+"','"+txtTotalDays.Text+"','"+txtWorkingDays.Text+"','"+txtPresent.Text+"','"+txtAbsent.Text+"','"+txtLOP.Text+"')");
                MessageBox.Show("Saved Successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ClearData();
            }
        }
        private void ClearData()
        {
            txtEmpId.Clear();
            txtEmpName.Clear();
            cmbYear.SelectedIndex = -1;
            cmbMonth.SelectedIndex = -1;
            txtTotalDays.Clear();
            txtWorkingDays.Clear();
            txtPresent.Clear();
            txtAbsent.Clear();
            txtLOP.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Update", "Update", MessageBoxButtons.YesNo);
             if (dialogResult == DialogResult.Yes)
             {
                 con.dataSend("UPDATE EmpAttendance SET PresentDays ='"+txtPresent.Text+"', AbsentDays ='"+txtAbsent.Text+"', TotalDays ='"+txtTotalDays.Text+"', WorkingDays ='"+txtWorkingDays.Text+"', LopDays ='"+txtLOP.Text+"' Where EmpId = '"+txtEmpId.Text+"' And Year = '"+cmbYear.Text+"' And  Month = '"+cmbMonth.Text+"'");
                 MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 ClearData();
             }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Delete", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("Delete from EmpAttendance Where EmpId = '" + txtEmpId.Text + "' And Year = '" + cmbYear.Text + "' And  Month = '" + cmbMonth.Text + "'");
                MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Employee.frmAttendanceView frm = new Employee.frmAttendanceView();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
