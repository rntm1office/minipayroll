using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPayroll.User
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtUserName.Text.Length > 0)
                {
                    txtOldPassword.Focus();
                }
                else
                {
                    txtUserName.Focus();
                }
            }
        }

        private void txtOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOldPassword.Text.Length > 0)
                {
                   txtNewPassword.Focus();
                }
                else
                {
                    txtOldPassword.Focus();
                }
            }
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNewPassword.Text.Length > 0)
                {
                    txtConfirmPassword.Focus();
                }
                else
                {
                    txtNewPassword.Focus();
                }
            }
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtConfirmPassword.Text.Length > 0)
                {
                    btnChange.Focus();
                }
                else
                {
                    txtConfirmPassword.Focus();
                }
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Change Password", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Connection con = new Connection();
                con.dataGet("Select 1 from [User] where UserName = '"+txtUserName.Text+"' and Password='"+txtOldPassword.Text+"'");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if(txtNewPassword.Text == txtConfirmPassword.Text)
                    {
                        if(txtNewPassword.Text.Length > 3)
                        {
                            con.dataSend("Update [User] Set Password='"+txtNewPassword.Text+"' where UserName='"+txtUserName.Text+"' and Password = '"+txtOldPassword.Text+"'");
                             MessageBox.Show("Password changed Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            errorProvider1.SetError(txtNewPassword, "Please enter minimum 4 Character Password");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtNewPassword,"Password Mismatch");
                        errorProvider1.SetError(txtConfirmPassword, "Password Mismatch");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtUserName, "Please Check UserName and Password");
                    errorProvider1.SetError(txtOldPassword, "Please Check UserName and Password");
                }
            }
        }
    }
}
