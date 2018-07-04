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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.dataGet("Select * from [User] Where UserName = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }
    }
}
