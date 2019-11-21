using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Student_Management
{
    public partial class frmLogin : MetroForm
    {
        
        public static frmLogin fm;
        public static string ID;
        public frmLogin()
        {
            InitializeComponent();
            fm = (frmLogin)this;
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbIsManager.Checked)
                CPublic.CheckUsers(txtID.Text, txtPwd.Text);
            else
                CPublic.CheckStudent(txtID.Text, txtPwd.Text);

            if (CPublic.LoginInfo == null)
                MessageBox.Show("密码错误！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                ID = txtID.Text;
                Close();
            }
                

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cbIsManager.Checked)
                CPublic.CheckUsers(txtID.Text, txtPwd.Text);
            else
                CPublic.CheckStudent(txtID.Text, txtPwd.Text);

            if (CPublic.LoginInfo == null)
                MessageBox.Show("密码错误！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtID1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_Click(object sender, EventArgs e)
        {

        }
    }
}
