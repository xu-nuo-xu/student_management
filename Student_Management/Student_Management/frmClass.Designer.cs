namespace Student_Management
{
    partial class frmClass
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
            System.Windows.Forms.Label classNoLabel;
            System.Windows.Forms.Label departNoLabel;
            System.Windows.Forms.Label classNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClass));
            this.classDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.classNoTextBox = new System.Windows.Forms.TextBox();
            this.departNoTextBox = new System.Windows.Forms.TextBox();
            this.classNameTextBox = new System.Windows.Forms.TextBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.classBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Manage_DB = new Student_Management.Student_Manage_DB();
            this.toolStripButton1 = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager();
            this.toolStripButton2 = new MetroFramework.Controls.MetroTile();
            this.toolStripButton3 = new MetroFramework.Controls.MetroTile();
            this.toolStripButton4 = new MetroFramework.Controls.MetroTile();
            this.toolStripButton5 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.tableAdapterManager = new Student_Management.Student_Manage_DBTableAdapters.TableAdapterManager();
            this.classTableAdapter = new Student_Management.Student_Manage_DBTableAdapters.ClassTableAdapter();
            classNoLabel = new System.Windows.Forms.Label();
            departNoLabel = new System.Windows.Forms.Label();
            classNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).BeginInit();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingNavigator)).BeginInit();
            this.classBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Manage_DB)).BeginInit();
            this.SuspendLayout();
            // 
            // classNoLabel
            // 
            classNoLabel.AutoSize = true;
            classNoLabel.Location = new System.Drawing.Point(20, 75);
            classNoLabel.Name = "classNoLabel";
            classNoLabel.Size = new System.Drawing.Size(79, 15);
            classNoLabel.TabIndex = 3;
            classNoLabel.Text = "Class No:";
            // 
            // departNoLabel
            // 
            departNoLabel.AutoSize = true;
            departNoLabel.Location = new System.Drawing.Point(20, 106);
            departNoLabel.Name = "departNoLabel";
            departNoLabel.Size = new System.Drawing.Size(87, 15);
            departNoLabel.TabIndex = 5;
            departNoLabel.Text = "Depart No:";
            // 
            // classNameLabel
            // 
            classNameLabel.AutoSize = true;
            classNameLabel.Location = new System.Drawing.Point(20, 137);
            classNameLabel.Name = "classNameLabel";
            classNameLabel.Size = new System.Drawing.Size(95, 15);
            classNameLabel.TabIndex = 7;
            classNameLabel.Text = "Class Name:";
            // 
            // classDataGridView
            // 
            this.classDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.classDataGridView.Location = new System.Drawing.Point(26, 218);
            this.classDataGridView.Name = "classDataGridView";
            this.classDataGridView.ReadOnly = true;
            this.classDataGridView.RowTemplate.Height = 27;
            this.classDataGridView.Size = new System.Drawing.Size(539, 339);
            this.classDataGridView.TabIndex = 1;
            this.classDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClassNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "ClassNo";
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClassName";
            this.dataGridViewTextBoxColumn3.HeaderText = "ClassName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据总览(只读)";
            // 
            // classNoTextBox
            // 
            this.classNoTextBox.Location = new System.Drawing.Point(121, 72);
            this.classNoTextBox.Name = "classNoTextBox";
            this.classNoTextBox.ReadOnly = true;
            this.classNoTextBox.Size = new System.Drawing.Size(156, 25);
            this.classNoTextBox.TabIndex = 4;
            this.classNoTextBox.TextChanged += new System.EventHandler(this.classNoTextBox_TextChanged);
            // 
            // departNoTextBox
            // 
            this.departNoTextBox.Location = new System.Drawing.Point(121, 103);
            this.departNoTextBox.Name = "departNoTextBox";
            this.departNoTextBox.ReadOnly = true;
            this.departNoTextBox.Size = new System.Drawing.Size(156, 25);
            this.departNoTextBox.TabIndex = 6;
            // 
            // classNameTextBox
            // 
            this.classNameTextBox.Location = new System.Drawing.Point(121, 134);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.ReadOnly = true;
            this.classNameTextBox.Size = new System.Drawing.Size(156, 25);
            this.classNameTextBox.TabIndex = 8;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.classNameTextBox);
            this.gbEdit.Controls.Add(classNoLabel);
            this.gbEdit.Controls.Add(classNameLabel);
            this.gbEdit.Controls.Add(this.classNoTextBox);
            this.gbEdit.Controls.Add(this.departNoTextBox);
            this.gbEdit.Controls.Add(departNoLabel);
            this.gbEdit.Location = new System.Drawing.Point(606, 115);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(305, 210);
            this.gbEdit.TabIndex = 9;
            this.gbEdit.TabStop = false;
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
            // classBindingNavigator
            // 
            this.classBindingNavigator.AddNewItem = null;
            this.classBindingNavigator.BindingSource = this.classBindingSource;
            this.classBindingNavigator.CountItem = null;
            this.classBindingNavigator.DeleteItem = null;
            this.classBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.classBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.classBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.classBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.classBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.classBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.classBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.classBindingNavigator.Name = "classBindingNavigator";
            this.classBindingNavigator.PositionItem = null;
            this.classBindingNavigator.Size = new System.Drawing.Size(929, 27);
            this.classBindingNavigator.TabIndex = 0;
            this.classBindingNavigator.Text = "bindingNavigator1";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.student_Manage_DB;
            // 
            // student_Manage_DB
            // 
            this.student_Manage_DB.DataSetName = "Student_Manage_DB";
            this.student_Manage_DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ActiveControl = null;
            this.toolStripButton1.Location = new System.Drawing.Point(738, 398);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 147);
            this.toolStripButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton1.StyleManager = this.metroStyleManager;
            this.toolStripButton1.TabIndex = 11;
            this.toolStripButton1.Text = "新增";
            this.toolStripButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton1.TileCount = 0;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.OwnerForm = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ActiveControl = null;
            this.toolStripButton2.Location = new System.Drawing.Point(679, 398);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(42, 147);
            this.toolStripButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton2.StyleManager = this.metroStyleManager;
            this.toolStripButton2.TabIndex = 12;
            this.toolStripButton2.Text = "修改";
            this.toolStripButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton2.TileCount = 0;
            this.toolStripButton2.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ActiveControl = null;
            this.toolStripButton3.Location = new System.Drawing.Point(794, 398);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(41, 147);
            this.toolStripButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton3.StyleManager = this.metroStyleManager;
            this.toolStripButton3.TabIndex = 13;
            this.toolStripButton3.Text = "删除";
            this.toolStripButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton3.TileCount = 0;
            this.toolStripButton3.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ActiveControl = null;
            this.toolStripButton4.Enabled = false;
            this.toolStripButton4.Location = new System.Drawing.Point(849, 350);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(37, 195);
            this.toolStripButton4.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton4.StyleManager = this.metroStyleManager;
            this.toolStripButton4.TabIndex = 14;
            this.toolStripButton4.Text = "保存";
            this.toolStripButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton4.TileCount = 0;
            this.toolStripButton4.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ActiveControl = null;
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Location = new System.Drawing.Point(629, 398);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(39, 195);
            this.toolStripButton5.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton5.StyleManager = this.metroStyleManager;
            this.toolStripButton5.TabIndex = 15;
            this.toolStripButton5.Text = "放弃";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton5.TileCount = 0;
            this.toolStripButton5.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(691, 560);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(195, 33);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.StyleManager = this.metroStyleManager;
            this.metroTile1.TabIndex = 16;
            this.metroTile1.Text = "风格";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileCount = 0;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(629, 350);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(195, 33);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.StyleManager = this.metroStyleManager;
            this.metroTile2.TabIndex = 17;
            this.metroTile2.Text = "主题";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.TileCount = 0;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click_1);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = this.classTableAdapter;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.StuCouTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Student_Management.Student_Manage_DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 654);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.toolStripButton5);
            this.Controls.Add(this.toolStripButton4);
            this.Controls.Add(this.toolStripButton3);
            this.Controls.Add(this.toolStripButton2);
            this.Controls.Add(this.toolStripButton1);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classDataGridView);
            this.Controls.Add(this.classBindingNavigator);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmClass";
            this.Opacity = 0.8D;
            this.StyleManager = this.metroStyleManager;
            this.Text = "frmClass";
            this.Load += new System.EventHandler(this.frmClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).EndInit();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingNavigator)).EndInit();
            this.classBindingNavigator.ResumeLayout(false);
            this.classBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Manage_DB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Student_Manage_DB student_Manage_DB;
        private System.Windows.Forms.DataGridView classDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox classNoTextBox;
        private System.Windows.Forms.TextBox departNoTextBox;
        private System.Windows.Forms.TextBox classNameTextBox;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator classBindingNavigator;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Student_Manage_DBTableAdapters.TableAdapterManager tableAdapterManager;
        private Student_Manage_DBTableAdapters.ClassTableAdapter classTableAdapter;
        private MetroFramework.Controls.MetroTile toolStripButton1;
        private MetroFramework.Controls.MetroTile toolStripButton2;
        private MetroFramework.Controls.MetroTile toolStripButton3;
        private MetroFramework.Controls.MetroTile toolStripButton4;
        private MetroFramework.Controls.MetroTile toolStripButton5;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
    }
}