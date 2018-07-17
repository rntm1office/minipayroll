using System;
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
    public partial class frmEmpSalary : Form
    {
        public frmEmpSalary()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        private void txtEmpId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(dataGridView2.Rows.Count > 0)
                {
                    txtEmpId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                    txtEmpName.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                    dtpJoinDate.Focus();
                }
            }
        }

        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select Top(10) EmpId,Name from Employee Where EmpId Like '" + txtEmpId.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void txtEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("Select Top(10) EmpId,Name from Employee Where Name Like '" + txtEmpName.Text + "%'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void txtEmpName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    txtEmpId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                    txtEmpName.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                    dtpJoinDate.Focus();
                }
            }
        }

        private void frmEmpSalary_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtEmpId;
            LoadData();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void dtpJoinDate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtSalary.Focus();
            }
        }

        private void txtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(txtSalary.Text.Length > 0)
                {
                    btnSave.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                if(IfEmployeeExists(txtEmpId.Text))
                {
                    MessageBox.Show("Record Already Exists");
                }
                else
                {
                    con.dataSend("INSERT INTO EmpSalary (EmpId, JoinDate, Salary) VALUES ('" + txtEmpId.Text + "','" + dtpJoinDate.Value.ToString("MM/dd/yyyy") + "','" + txtSalary.Text + "')");
                    MessageBox.Show("Successfully Saved","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ClearData();
                    LoadData();
                }
            }           

        }
        private void ClearData()
        {
            txtEmpId.Clear();
            txtEmpName.Clear();
            txtSalary.Clear();
            dtpJoinDate.Value = DateTime.Now;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void LoadData()
        {
            con.dataGet("Select EmpSalary.*,Employee.Name from Employee Inner Join EmpSalary On Employee.EmpId = EmpSalary.EmpId");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgEmpId"].Value = row["EmpId"].ToString();
                dataGridView1.Rows[n].Cells["dgName"].Value = row["Name"].ToString();
                dataGridView1.Rows[n].Cells["dgJoinDate"].Value = Convert.ToDateTime(row["JoinDate"].ToString()).ToString("dd/MM/yyyy"); 
                dataGridView1.Rows[n].Cells["dgSalary"].Value = row["Salary"].ToString();
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
            else if (string.IsNullOrEmpty(txtSalary.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtSalary, "Salary Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        private bool IfEmployeeExists(string empId)
        {
            con.dataGet("Select 1 From EmpSalary WHERE EmpId = '" + empId + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmpId.Text = dataGridView1.SelectedRows[0].Cells["dgEmpId"].Value.ToString();
            txtEmpName.Text = dataGridView1.SelectedRows[0].Cells["dgName"].Value.ToString();
            dtpJoinDate.Text = dataGridView1.SelectedRows[0].Cells["dgJoinDate"].Value.ToString();
            txtSalary.Text = dataGridView1.SelectedRows[0].Cells["dgSalary"].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Update", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("Update EmpSalary Set JoinDate = '" + dtpJoinDate.Value.ToString("MM/dd/yyyy") + "', Salary = '"+txtSalary.Text+"' Where EmpId = '"+txtEmpId.Text+"' ");
                MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Delete", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("Delete From EmpSalary Where EmpId = '" + txtEmpId.Text + "' ");
                MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearData();
            }
        }
       
    }
}
