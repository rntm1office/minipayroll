using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPayroll.Employee
{
    public partial class frmEmployeeRegister : Form
    {
        string fileName;
        public frmEmployeeRegister()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog () {Filter = "JPEG|*.jpg",ValidateNames =true,Multiselect=false})
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    lblFileName.Text = fileName;
                    pictureBox.Image = Image.FromFile(fileName);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void frmEmployeeRegister_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtName;
            LoadData();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtName.Text.Length > 0)
                {
                    txtMobile.Focus();
                }
                else
                {
                    txtName.Focus();
                }                
            }
        }

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMobile.Text.Length > 0)
                {
                    txtEmail.Focus();
                }
                else
                {
                    txtMobile.Focus();
                }
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmail.Text.Length > 0)
                {
                    txtPanNo.Focus();
                }
                else
                {
                    txtEmail.Focus();
                }
            }
        }

        private void txtPanNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPanNo.Text.Length > 0)
                {
                    dtpDob.Focus();
                }
                else
                {
                    txtPanNo.Focus();
                }
            }
        }

        private void dtpDob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBankDetails.Focus();
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtName, "Name Required");
            }
            else if (string.IsNullOrEmpty(txtMobile.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMobile, "Mobile No Required");
            }
            else if (string.IsNullOrEmpty(txtPanNo.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPanNo, "PAN No. Required");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Email Required");
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAddress, "Address Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        Connection con = new Connection();
        private bool IfEmployeeExists(string name, string mobile, string panNo)
        {
            con.dataGet("Select 1 From Employee WHERE Name ='" + name + "' And Mobile = '" + mobile + "' And PANNo = '" + panNo + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream () )
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                if(IfEmployeeExists(txtName.Text,txtMobile.Text,txtPanNo.Text))
                {
                    MessageBox.Show("Employee Already Exists");
                }
                else
                {
                    con.dataSend(@"INSERT INTO Employee (Name, Mobile, Email, PANNo, Dob, BankDetails, Address,FileName, ImageData)
                                VALUES ('" + txtName.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "','" + txtPanNo.Text + "','" + dtpDob.Value.ToString("MM/dd/yyyy") + "','" + txtBankDetails.Text + "','" + txtAddress.Text + "','" + fileName + "','" + ConvertImageToBinary (pictureBox.Image)+ "')");
                    MessageBox.Show("Successfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadData();
                }
            }
        }
        private void ClearData()
        {
            txtName.Clear();
            txtEmpId.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtPanNo.Clear();
            dtpDob.Value = DateTime.Now;
            txtBankDetails.Clear();
            txtAddress.Clear();
            pictureBox.Image = null;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void LoadData()
        {
            con.dataGet("Select * from Employee");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach(DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dgEmpId"].Value = row["EmpId"].ToString();
                dataGridView1.Rows[n].Cells["dgName"].Value = row["Name"].ToString();
                dataGridView1.Rows[n].Cells["dgDob"].Value = Convert.ToDateTime(row["Dob"].ToString()).ToString("dd/MM/yyyy");
                dataGridView1.Rows[n].Cells["dgEmail"].Value = row["Email"].ToString();
                dataGridView1.Rows[n].Cells["dgMobile"].Value = row["Mobile"].ToString();
                dataGridView1.Rows[n].Cells["dgPan"].Value = row["PANNo"].ToString();
                dataGridView1.Rows[n].Cells["dgBank"].Value = row["BankDetails"].ToString();
                dataGridView1.Rows[n].Cells["dgAddress"].Value = row["Address"].ToString();
                dataGridView1.Rows[n].Cells["dgFileName"].Value = row["FileName"].ToString();
                dataGridView1.Rows[n].Cells["dgImageData"].Value = row["ImageData"].ToString();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmpId.Text = dataGridView1.SelectedRows[0].Cells["dgEmpId"].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells["dgName"].Value.ToString();
            txtMobile.Text = dataGridView1.SelectedRows[0].Cells["dgMobile"].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells["dgEmail"].Value.ToString();
            txtPanNo.Text = dataGridView1.SelectedRows[0].Cells["dgPan"].Value.ToString();
            dtpDob.Text = dataGridView1.SelectedRows[0].Cells["dgDob"].Value.ToString();          
            txtBankDetails.Text = dataGridView1.SelectedRows[0].Cells["dgBank"].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells["dgAddress"].Value.ToString();
            lblFileName.Text = dataGridView1.SelectedRows[0].Cells["dgFileName"].Value.ToString();
            pictureBox.Image = Image.FromFile(dataGridView1.SelectedRows[0].Cells["dgFileName"].Value.ToString());
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Update", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("UPDATE Employee SET Email = '"+txtEmail.Text+"', BankDetails = '"+txtBankDetails.Text+"', Address ='"+txtAddress.Text+"', FileName ='"+fileName+"', ImageData ='"+ConvertImageToBinary(pictureBox.Image)+"' Where EmpId = '"+txtEmpId.Text+"'");
                MessageBox.Show("Updated Successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want to Delete", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("Delete From Employee Where EmpId = '" + txtEmpId.Text + "'");
                MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
    }
}
