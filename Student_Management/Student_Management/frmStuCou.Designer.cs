namespace Student_Management
{
    partial class frmStuCou
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label stuNoLabel;
            System.Windows.Forms.Label couNoLabel;
            System.Windows.Forms.Label gradeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStuCou));
            this.student_Manage_DB = new Student_Management.Student_Manage_DB();
            this.stuCouBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuCouTableAdapter = new Student_Management.Student_Manage_DBTableAdapters.StuCouTableAdapter();
            this.tableAdapterManager = new Student_Management.Student_Manage_DBTableAdapters.TableAdapterManager();
            this.stuCouBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stuCouDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuNoTextBox = new System.Windows.Forms.TextBox();
            this.couNoTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new MetroFramework.Controls.MetroTile();
            this.toolStripButton2 = new MetroFramework.Controls.MetroTile();
            this.toolStripButton3 = new MetroFramework.Controls.MetroTile();
            this.toolStripButton4 = new MetroFramework.Controls.MetroTile();
            this.toolStripButton5 = new MetroFramework.Controls.MetroTile();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            stuNoLabel = new System.Windows.Forms.Label();
            couNoLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.student_Manage_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuCouBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuCouBindingNavigator)).BeginInit();
            this.stuCouBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuCouDataGridView)).BeginInit();
            this.gbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // stuNoLabel
            // 
            stuNoLabel.AutoSize = true;
            stuNoLabel.Location = new System.Drawing.Point(31, 56);
            stuNoLabel.Name = "stuNoLabel";
            stuNoLabel.Size = new System.Drawing.Size(63, 15);
            stuNoLabel.TabIndex = 2;
            stuNoLabel.Text = "Stu No:";
            // 
            // couNoLabel
            // 
            couNoLabel.AutoSize = true;
            couNoLabel.Location = new System.Drawing.Point(31, 87);
            couNoLabel.Name = "couNoLabel";
            couNoLabel.Size = new System.Drawing.Size(63, 15);
            couNoLabel.TabIndex = 4;
            couNoLabel.Text = "Cou No:";
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new System.Drawing.Point(31, 118);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(55, 15);
            gradeLabel.TabIndex = 6;
            gradeLabel.Text = "Grade:";
            // 
            // student_Manage_DB
            // 
            this.student_Manage_DB.DataSetName = "Student_Manage_DB";
            this.student_Manage_DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stuCouBindingSource
            // 
            this.stuCouBindingSource.DataMember = "StuCou";
            this.stuCouBindingSource.DataSource = this.student_Manage_DB;
            // 
            // stuCouTableAdapter
            // 
            this.stuCouTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.StuCouTableAdapter = this.stuCouTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Student_Management.Student_Manage_DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stuCouBindingNavigator
            // 
            this.stuCouBindingNavigator.AddNewItem = null;
            this.stuCouBindingNavigator.BindingSource = this.stuCouBindingSource;
            this.stuCouBindingNavigator.CountItem = null;
            this.stuCouBindingNavigator.DeleteItem = null;
            this.stuCouBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stuCouBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.stuCouBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.stuCouBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stuCouBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stuCouBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stuCouBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stuCouBindingNavigator.Name = "stuCouBindingNavigator";
            this.stuCouBindingNavigator.PositionItem = null;
            this.stuCouBindingNavigator.Size = new System.Drawing.Size(883, 27);
            this.stuCouBindingNavigator.TabIndex = 0;
            this.stuCouBindingNavigator.Text = "bindingNavigator1";
            this.stuCouBindingNavigator.RefreshItems += new System.EventHandler(this.stuCouBindingNavigator_RefreshItems);
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
            // stuCouDataGridView
            // 
            this.stuCouDataGridView.AutoGenerateColumns = false;
            this.stuCouDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuCouDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.stuCouDataGridView.DataSource = this.stuCouBindingSource;
            this.stuCouDataGridView.Enabled = false;
            this.stuCouDataGridView.Location = new System.Drawing.Point(48, 252);
            this.stuCouDataGridView.Name = "stuCouDataGridView";
            this.stuCouDataGridView.RowTemplate.Height = 27;
            this.stuCouDataGridView.Size = new System.Drawing.Size(493, 303);
            this.stuCouDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StuNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "StuNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CouNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "CouNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Grade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // stuNoTextBox
            // 
            this.stuNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuCouBindingSource, "StuNo", true));
            this.stuNoTextBox.Location = new System.Drawing.Point(100, 53);
            this.stuNoTextBox.Name = "stuNoTextBox";
            this.stuNoTextBox.ReadOnly = true;
            this.stuNoTextBox.Size = new System.Drawing.Size(151, 25);
            this.stuNoTextBox.TabIndex = 3;
            this.stuNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // couNoTextBox
            // 
            this.couNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuCouBindingSource, "CouNo", true));
            this.couNoTextBox.Location = new System.Drawing.Point(100, 84);
            this.couNoTextBox.Name = "couNoTextBox";
            this.couNoTextBox.ReadOnly = true;
            this.couNoTextBox.Size = new System.Drawing.Size(151, 25);
            this.couNoTextBox.TabIndex = 5;
            this.couNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuCouBindingSource, "Grade", true));
            this.gradeTextBox.Location = new System.Drawing.Point(100, 115);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.ReadOnly = true;
            this.gradeTextBox.Size = new System.Drawing.Size(151, 25);
            this.gradeTextBox.TabIndex = 7;
            this.gradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ActiveControl = null;
            this.toolStripButton1.Location = new System.Drawing.Point(593, 426);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(42, 205);
            this.toolStripButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton1.StyleManager = null;
            this.toolStripButton1.TabIndex = 8;
            this.toolStripButton1.Text = "新增";
            this.toolStripButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton1.TileCount = 0;
            this.toolStripButton1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ActiveControl = null;
            this.toolStripButton2.Location = new System.Drawing.Point(641, 583);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(232, 48);
            this.toolStripButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton2.StyleManager = null;
            this.toolStripButton2.TabIndex = 9;
            this.toolStripButton2.Text = "修改";
            this.toolStripButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton2.TileCount = 0;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ActiveControl = null;
            this.toolStripButton3.Location = new System.Drawing.Point(641, 426);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(89, 86);
            this.toolStripButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton3.StyleManager = null;
            this.toolStripButton3.TabIndex = 10;
            this.toolStripButton3.Text = "删除";
            this.toolStripButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton3.TileCount = 0;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ActiveControl = null;
            this.toolStripButton4.Enabled = false;
            this.toolStripButton4.Location = new System.Drawing.Point(736, 426);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(137, 151);
            this.toolStripButton4.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton4.StyleManager = null;
            this.toolStripButton4.TabIndex = 11;
            this.toolStripButton4.Text = "保存";
            this.toolStripButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton4.TileCount = 0;
            this.toolStripButton4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.ActiveControl = null;
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Location = new System.Drawing.Point(641, 518);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(89, 59);
            this.toolStripButton5.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolStripButton5.StyleManager = null;
            this.toolStripButton5.TabIndex = 12;
            this.toolStripButton5.Text = "放弃";
            this.toolStripButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolStripButton5.TileCount = 0;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.couNoTextBox);
            this.gbEdit.Controls.Add(this.gradeTextBox);
            this.gbEdit.Controls.Add(gradeLabel);
            this.gbEdit.Controls.Add(couNoLabel);
            this.gbEdit.Controls.Add(this.stuNoTextBox);
            this.gbEdit.Controls.Add(stuNoLabel);
            this.gbEdit.Location = new System.Drawing.Point(587, 187);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(277, 180);
            this.gbEdit.TabIndex = 13;
            this.gbEdit.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(48, 197);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "数据总览(只读)";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // frmStuCou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 711);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.toolStripButton5);
            this.Controls.Add(this.toolStripButton4);
            this.Controls.Add(this.toolStripButton3);
            this.Controls.Add(this.toolStripButton2);
            this.Controls.Add(this.toolStripButton1);
            this.Controls.Add(this.stuCouDataGridView);
            this.Controls.Add(this.stuCouBindingNavigator);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmStuCou";
            this.Opacity = 0.8D;
            this.Text = "StuCou";
            this.Load += new System.EventHandler(this.StuCou_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_Manage_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuCouBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuCouBindingNavigator)).EndInit();
            this.stuCouBindingNavigator.ResumeLayout(false);
            this.stuCouBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuCouDataGridView)).EndInit();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Student_Manage_DB student_Manage_DB;
        private System.Windows.Forms.BindingSource stuCouBindingSource;
        private Student_Manage_DBTableAdapters.StuCouTableAdapter stuCouTableAdapter;
        private Student_Manage_DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stuCouBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView stuCouDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox stuNoTextBox;
        private System.Windows.Forms.TextBox couNoTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private MetroFramework.Controls.MetroTile toolStripButton1;
        private MetroFramework.Controls.MetroTile toolStripButton2;
        private MetroFramework.Controls.MetroTile toolStripButton3;
        private MetroFramework.Controls.MetroTile toolStripButton4;
        private MetroFramework.Controls.MetroTile toolStripButton5;
        private System.Windows.Forms.GroupBox gbEdit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}