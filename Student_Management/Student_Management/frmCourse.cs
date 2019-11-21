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
    public partial class frmCourse : MetroForm
    {
        public static frmCourse _Instance = null;
        public static frmCourse Instacne()
        {
            if (_Instance == null)
                _Instance = new frmCourse();
            return _Instance;
        }
        public frmCourse()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_Manage_DB);

        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“student_Manage_DB.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.student_Manage_DB.Course);

        }
        private void ChangeEnabledState()
        {
            courseBindingNavigator.Enabled = !courseBindingNavigator.Enabled;
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

        private void tsbInsert_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            courseBindingSource.AddNew();
            couNoTextBox.Focus();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            couNoTextBox.Focus();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_Manage_DB);
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.courseBindingSource.CancelEdit();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if(courseBindingSource.Current!=null)
            {
                if(MessageBox.Show("确定删除吗？","确定",MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    courseBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.student_Manage_DB);
                }
            }
        }

        private void courseBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            courseBindingSource.AddNew();
            couNoTextBox.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            couNoTextBox.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (courseBindingSource.Current != null)
            {
                if (MessageBox.Show("确定删除吗？", "确定", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    courseBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.student_Manage_DB);
                }
            }
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_Manage_DB);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.courseBindingSource.CancelEdit();
        }
    }
}
