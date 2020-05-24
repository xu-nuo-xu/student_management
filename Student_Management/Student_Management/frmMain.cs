using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
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
            frmDepartment f = frmDepartment.Instacne();
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
                //LoginInfo.Text = "您好，" + CPublic.LoginInfo["UserName"] + "管理员，欢迎使用本系统！";
                this.Refresh();
            }
            else
            {
                // LoginInfo.Text = "您好，" + CPublic.LoginInfo["StuName"] + "同学，欢迎使用本系统！";
                系部信息Tile.Enabled = false;
                班级信息Tile.Enabled = false;
                学生信息Tile.Enabled = false;
                课程信息Tile.Enabled = false;
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

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmDepartment f = frmDepartment.Instacne();
            //f.MdiParent = this;
            f.Show();
            f.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            frmAboutBox f = new frmAboutBox();
            f.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmClass f = frmClass.Instacne();
            //f.MdiParent = this;
            f.Show();
            f.Focus();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            frmStudent f = frmStudent.Instacne();
            //f.MdiParent = this;
            f.Show();
            f.Focus();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            frmCourse f = frmCourse.Instacne();
            //f.MdiParent = this;
            f.Show();
            f.Focus();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Close();
        }
            
        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager.Style = (MetroColorStyle)next;
        }

        private void 学生选课表Tile_Click(object sender, EventArgs e)
        {
            frmStuCou f = new frmStuCou();
            //f.MdiParent = this;
            f.Show();
            f.Focus();
        }

        private void LINQTile_Click(object sender, EventArgs e)
        {
            frmLinqToSql f = new frmLinqToSql();
            f.Show();
        }
    }
}
