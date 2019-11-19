using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace Student_Management
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent f = frmStudent.Instacne();
            f.MdiParent = this;
            f.Show();
            f.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frnMain_Resize(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }

        private void 系部信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment f =frmDepartment.Instacne();
            f.MdiParent = this;
            f.Show();
            f.Focus();
        }

        private void 班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass f = frmClass.Instacne();
            f.MdiParent = this;
            f.Show();
            f.Focus();
        }

        private void 课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourse f = frmCourse.Instacne();
            f.MdiParent = this;
            f.Show();
            f.Focus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (CPublic.isManager)
            {
                LoginInfo.Text = "您好，" + CPublic.LoginInfo["UserName"] + "管理员，欢迎使用本系统！";
                学生选课表ToolStripMenuItem.Enabled = false;
                this.Refresh();
            }
            else
            {
                LoginInfo.Text = "您好，" + CPublic.LoginInfo["StuName"] + "同学，欢迎使用本系统！";
                系部信息ToolStripMenuItem.Enabled = false;
                班级信息ToolStripMenuItem.Enabled = false;
                学生信息ToolStripMenuItem.Enabled = false;
                课程信息ToolStripMenuItem.Enabled = false;
                lINQ示例ToolStripMenuItem.Enabled = false;
                this.Refresh();
            }
        }

        private void LoginInfo_Click(object sender, EventArgs e)
        {

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutBox f = new frmAboutBox();
            f.ShowDialog();
        }
    }
}
