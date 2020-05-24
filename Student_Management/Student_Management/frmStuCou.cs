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
    public partial class frmStuCou : MetroForm
    {
        public static frmClass _Instance = null;
        public static frmClass Instacne()
        {
            if (_Instance == null)
                _Instance = new frmClass();
            return _Instance;
        }
        public frmStuCou()
        {
            InitializeComponent();
        }
        private void ChangeEnabledState()
        {
            stuCouBindingNavigator.Enabled = !stuCouBindingNavigator.Enabled;
            toolStripButton1.Enabled = toolStripButton1.Enabled == true ? false : true;
            toolStripButton2.Enabled = toolStripButton2.Enabled == true ? false : true;
            toolStripButton3.Enabled = toolStripButton3.Enabled == true ? false : true;
            toolStripButton4.Enabled = toolStripButton4.Enabled == true ? false : true;
            toolStripButton5.Enabled = toolStripButton5.Enabled == true ? false : true;
            foreach (Control c in gbEdit.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = !((TextBox)c).ReadOnly;
            }
        }
        private void StuCou_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“student_Manage_DB.StuCou”中。您可以根据需要移动或删除它。
            this.stuCouTableAdapter.Fill(this.student_Manage_DB.StuCou);

        }

        private void stuCouBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stuCouBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_Manage_DB);

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.Validate();
            this.stuCouBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_Manage_DB);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            stuCouBindingSource.AddNew();
            stuNoTextBox.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            stuNoTextBox.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (stuCouBindingSource.Current != null)
            {
                if (MessageBox.Show("确定删除吗？", "确定", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    stuCouBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.student_Manage_DB);
                }
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.stuCouBindingSource.CancelEdit();
        }

        private void stuCouBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
