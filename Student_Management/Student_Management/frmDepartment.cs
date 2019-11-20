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
    public partial class frmDepartment : MetroForm
    {
        public static frmDepartment _Instance = null;
        public static frmDepartment Instacne()
        {
            if (_Instance == null)
                _Instance = new frmDepartment();
            return _Instance;
        }
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void departmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_Manage_DB);

        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“student_Manage_DB.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.student_Manage_DB.Course);
            // TODO: 这行代码将数据加载到表“student_Manage_DB.Department”中。您可以根据需要移动或删除它。
            this.departmentTableAdapter.Fill(this.student_Manage_DB.Department);

        }

        private void departmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            departmentBindingSource.AddNew();
            departNameTextBox.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            departNameTextBox.Focus();
        }
        private void ChangeEnabledState()
        {
            departmentBindingNavigator.Enabled = !departmentBindingNavigator.Enabled;
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

        private void tsbDelete_Click_1(object sender, EventArgs e)
        {
            if (departmentBindingSource.Current != null)
            {
                if (MessageBox.Show("确定删除吗？", "确定", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    departmentBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.student_Manage_DB);
                }
            }
        }

        private void tsbSave_Click_1(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.Validate();
            this.departmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_Manage_DB);
        }

        private void tsbCancel_Click_1(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.departmentBindingSource.CancelEdit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void departmentBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }
    }
}
