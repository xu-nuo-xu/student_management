namespace Student_Management
{
    partial class frmDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            _Instance = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label departNameLabel;
            System.Windows.Forms.Label departNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartment));
            this.departmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Manage_DB = new Student_Management.Student_Manage_DB();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableAdapterManager = new Student_Management.Student_Manage_DBTableAdapters.TableAdapterManager();
            this.departmentTableAdapter = new Student_Management.Student_Manage_DBTableAdapters.DepartmentTableAdapter();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.tsbInsert = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Student_Management.Student_Manage_DBTableAdapters.CourseTableAdapter();
            this.departNameTextBox = new System.Windows.Forms.TextBox();
            this.departNoTextBox = new System.Windows.Forms.TextBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.数据总览 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            departNameLabel = new System.Windows.Forms.Label();
            departNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingNavigator)).BeginInit();
            this.departmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Manage_DB)).BeginInit();
            this.tsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.数据总览)).BeginInit();
            this.SuspendLayout();
            // 
            // departNameLabel
            // 
            departNameLabel.AutoSize = true;
            departNameLabel.Location = new System.Drawing.Point(24, 56);
            departNameLabel.Name = "departNameLabel";
            departNameLabel.Size = new System.Drawing.Size(103, 15);
            departNameLabel.TabIndex = 3;
            departNameLabel.Text = "Depart Name:";
            // 
            // departNoLabel
            // 
            departNoLabel.AutoSize = true;
            departNoLabel.Location = new System.Drawing.Point(24, 87);
            departNoLabel.Name = "departNoLabel";
            departNoLabel.Size = new System.Drawing.Size(87, 15);
            departNoLabel.TabIndex = 5;
            departNoLabel.Text = "Depart No:";
            // 
            // departmentBindingNavigator
            // 
            this.departmentBindingNavigator.AddNewItem = null;
            this.departmentBindingNavigator.BindingSource = this.departmentBindingSource;
            this.departmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.departmentBindingNavigator.DeleteItem = null;
            this.departmentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.departmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.departmentBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.departmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.departmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.departmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.departmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.departmentBindingNavigator.Name = "departmentBindingNavigator";
            this.departmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.departmentBindingNavigator.Size = new System.Drawing.Size(1112, 27);
            this.departmentBindingNavigator.TabIndex = 0;
            this.departmentBindingNavigator.Text = "bindingNavigator1";
            this.departmentBindingNavigator.RefreshItems += new System.EventHandler(this.departmentBindingNavigator_RefreshItems);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.student_Manage_DB;
            // 
            // student_Manage_DB
            // 
            this.student_Manage_DB.DataSetName = "Student_Manage_DB";
            this.student_Manage_DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.StuCouTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Student_Management.Student_Manage_DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // tsControl
            // 
            this.tsControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsControl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsert,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbSave,
            this.tsbCancel});
            this.tsControl.Location = new System.Drawing.Point(20, 639);
            this.tsControl.Name = "tsControl";
            this.tsControl.Size = new System.Drawing.Size(1112, 27);
            this.tsControl.TabIndex = 2;
            this.tsControl.Text = "toolStrip1";
            // 
            // tsbInsert
            // 
            this.tsbInsert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbInsert.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsert.Image")));
            this.tsbInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsert.Name = "tsbInsert";
            this.tsbInsert.Size = new System.Drawing.Size(63, 24);
            this.tsbInsert.Text = "新增";
            this.tsbInsert.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(63, 24);
            this.tsbEdit.Text = "修改";
            this.tsbEdit.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(63, 24);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click_1);
            // 
            // tsbSave
            // 
            this.tsbSave.Enabled = false;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(63, 24);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click_1);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Enabled = false;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(63, 24);
            this.tsbCancel.Text = "放弃";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click_1);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.student_Manage_DB;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // departNameTextBox
            // 
            this.departNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "DepartName", true));
            this.departNameTextBox.Location = new System.Drawing.Point(133, 53);
            this.departNameTextBox.Name = "departNameTextBox";
            this.departNameTextBox.ReadOnly = true;
            this.departNameTextBox.Size = new System.Drawing.Size(184, 25);
            this.departNameTextBox.TabIndex = 4;
            // 
            // departNoTextBox
            // 
            this.departNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "DepartNo", true));
            this.departNoTextBox.Location = new System.Drawing.Point(133, 84);
            this.departNoTextBox.Name = "departNoTextBox";
            this.departNoTextBox.ReadOnly = true;
            this.departNoTextBox.Size = new System.Drawing.Size(184, 25);
            this.departNoTextBox.TabIndex = 6;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.departNameTextBox);
            this.gbEdit.Controls.Add(departNameLabel);
            this.gbEdit.Controls.Add(this.departNoTextBox);
            this.gbEdit.Controls.Add(departNoLabel);
            this.gbEdit.Location = new System.Drawing.Point(127, 178);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(376, 173);
            this.gbEdit.TabIndex = 7;
            this.gbEdit.TabStop = false;
            // 
            // 数据总览
            // 
            this.数据总览.AutoGenerateColumns = false;
            this.数据总览.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.数据总览.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.数据总览.DataSource = this.departmentBindingSource;
            this.数据总览.Location = new System.Drawing.Point(612, 138);
            this.数据总览.Name = "数据总览";
            this.数据总览.ReadOnly = true;
            this.数据总览.RowTemplate.Height = 27;
            this.数据总览.Size = new System.Drawing.Size(319, 336);
            this.数据总览.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DepartName";
            this.dataGridViewTextBoxColumn1.HeaderText = "DepartName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DepartNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "DepartNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "数据总览(只读)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.TabIndex = 0;
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.TabIndex = 0;
            this.metroButton1.UseSelectable = true;
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 686);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.数据总览);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.tsControl);
            this.Controls.Add(this.departmentBindingNavigator);
            this.Name = "frmDepartment";
            this.Text = "系部信息";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingNavigator)).EndInit();
            this.departmentBindingNavigator.ResumeLayout(false);
            this.departmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Manage_DB)).EndInit();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.数据总览)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Student_Manage_DB student_Manage_DB;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private Student_Manage_DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator departmentBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton tsbInsert;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Student_Manage_DBTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.TextBox departNameTextBox;
        private System.Windows.Forms.TextBox departNoTextBox;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.DataGridView 数据总览;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private Student_Manage_DBTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}