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
    public partial class frmClass : MetroForm
    {
        public static frmClass _Instance = null;
        public static frmClass Instacne()
        {
            if (_Instance == null)
                _Instance = new frmClass();
            return _Instance;
        }
        public frmClass()
        {
            InitializeComponent();
        }

        private void classBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_Manage_DB);

        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“student_Manage_DB.Class”中。您可以根据需要移动或删除它。
            this.classTableAdapter.Fill(this.student_Manage_DB.Class);

        }

        private void classDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ChangeEnabledState()
        {
            classBindingNavigator.Enabled = !classBindingNavigator.Enabled;
            foreach (ToolStripItem b in tsControl.Items)
            {
                b.Enabled = !b.Enabled;
            }
            foreach (Control c in gbEdit.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = !((TextBox)c).ReadOnly;
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            classBindingSource.AddNew();
            classNoTextBox.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            classNoTextBox.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (classBindingSource.Current != null)
            {
                if (MessageBox.Show("确定删除吗？", "确定", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    classBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.student_Manage_DB);
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.Validate();
            this.classBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_Manage_DB);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.classBindingSource.CancelEdit();
        }

        private void classNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
