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
    public partial class frmStudent : MetroForm
    {
        public static frmStudent _Instance = null;
        public static frmStudent Instacne()
        {
            if (_Instance == null)
                _Instance = new frmStudent();
            return _Instance;
        }
        public frmStudent()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_Manage_DB);

        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“student_Manage_DB.Class”中。您可以根据需要移动或删除它。
            this.classTableAdapter.Fill(this.student_Manage_DB.Class);
            // TODO: 这行代码将数据加载到表“student_Manage_DB.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.student_Manage_DB.Student);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void ChangeEnabledState()
        {
            studentBindingNavigator.Enabled = !studentBindingNavigator.Enabled;
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
        private void stuNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsbInsert_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            studentBindingSource.AddNew();
            stuNoTextBox.Focus();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            stuNoTextBox.Focus();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (studentBindingSource.Current != null)
            {
                if (MessageBox.Show("确定删除吗？", "确定", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    studentBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.student_Manage_DB);
                }
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student_Manage_DB);
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();
            this.studentBindingSource.CancelEdit();
        }
    }
}
