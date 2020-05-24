namespace Student_Management
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            MetroFramework.Controls.MetroLink metroLink1;
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.系部信息Tile = new MetroFramework.Controls.MetroTile();
            this.班级信息Tile = new MetroFramework.Controls.MetroTile();
            this.学生信息Tile = new MetroFramework.Controls.MetroTile();
            this.课程信息Tile = new MetroFramework.Controls.MetroTile();
            this.学生选课表Tile = new MetroFramework.Controls.MetroTile();
            this.LINQTile = new MetroFramework.Controls.MetroTile();
            this.关于Tile = new MetroFramework.Controls.MetroTile();
            this.退出Tile = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            metroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroLink1
            // 
            metroLink1.CustomBackground = false;
            metroLink1.FontSize = MetroFramework.MetroLinkSize.Small;
            metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            metroLink1.Location = new System.Drawing.Point(0, 653);
            metroLink1.Name = "metroLink1";
            metroLink1.Size = new System.Drawing.Size(625, 23);
            metroLink1.Style = MetroFramework.MetroColorStyle.Blue;
            metroLink1.StyleManager = this.metroStyleManager;
            metroLink1.TabIndex = 4;
            metroLink1.Text = "项目设计：许程远 西北工业大学";
            metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            metroLink1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLink1.UseStyleColors = true;
            metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.OwnerForm = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.CustomBackground = false;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Size = new System.Drawing.Size(200, 100);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.StyleManager = null;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseStyleColors = false;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.CustomBackground = false;
            this.metroToggle1.DisplayStatus = true;
            this.metroToggle1.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroToggle1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroToggle1.Location = new System.Drawing.Point(0, 0);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(104, 24);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToggle1.StyleManager = null;
            this.metroToggle1.TabIndex = 0;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToggle1.UseStyleColors = false;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.CustomBackground = false;
            this.metroTabControl2.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.metroTabControl2.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.metroTabControl2.ItemSize = new System.Drawing.Size(131, 36);
            this.metroTabControl2.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.Size = new System.Drawing.Size(200, 100);
            this.metroTabControl2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl2.StyleManager = null;
            this.metroTabControl2.TabIndex = 0;
            this.metroTabControl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTabControl2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl2.UseStyleColors = false;
            // 
            // 系部信息Tile
            // 
            this.系部信息Tile.ActiveControl = null;
            this.系部信息Tile.Location = new System.Drawing.Point(78, 154);
            this.系部信息Tile.Name = "系部信息Tile";
            this.系部信息Tile.Size = new System.Drawing.Size(128, 128);
            this.系部信息Tile.Style = MetroFramework.MetroColorStyle.Blue;
            this.系部信息Tile.StyleManager = this.metroStyleManager;
            this.系部信息Tile.TabIndex = 5;
            this.系部信息Tile.TabStop = false;
            this.系部信息Tile.Text = "系部信息";
            this.系部信息Tile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.系部信息Tile.TileCount = 0;
            this.系部信息Tile.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // 班级信息Tile
            // 
            this.班级信息Tile.ActiveControl = null;
            this.班级信息Tile.Location = new System.Drawing.Point(230, 154);
            this.班级信息Tile.Name = "班级信息Tile";
            this.班级信息Tile.Size = new System.Drawing.Size(128, 128);
            this.班级信息Tile.Style = MetroFramework.MetroColorStyle.Blue;
            this.班级信息Tile.StyleManager = this.metroStyleManager;
            this.班级信息Tile.TabIndex = 6;
            this.班级信息Tile.Text = "班级信息";
            this.班级信息Tile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.班级信息Tile.TileCount = 0;
            this.班级信息Tile.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // 学生信息Tile
            // 
            this.学生信息Tile.ActiveControl = null;
            this.学生信息Tile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.学生信息Tile.Location = new System.Drawing.Point(382, 154);
            this.学生信息Tile.Name = "学生信息Tile";
            this.学生信息Tile.Size = new System.Drawing.Size(128, 128);
            this.学生信息Tile.Style = MetroFramework.MetroColorStyle.Blue;
            this.学生信息Tile.StyleManager = this.metroStyleManager;
            this.学生信息Tile.TabIndex = 7;
            this.学生信息Tile.Text = "学生信息";
            this.学生信息Tile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.学生信息Tile.TileCount = 0;
            this.学生信息Tile.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // 课程信息Tile
            // 
            this.课程信息Tile.ActiveControl = null;
            this.课程信息Tile.Location = new System.Drawing.Point(542, 154);
            this.课程信息Tile.Name = "课程信息Tile";
            this.课程信息Tile.Size = new System.Drawing.Size(128, 128);
            this.课程信息Tile.Style = MetroFramework.MetroColorStyle.Blue;
            this.课程信息Tile.StyleManager = this.metroStyleManager;
            this.课程信息Tile.TabIndex = 8;
            this.课程信息Tile.Text = "课程信息";
            this.课程信息Tile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.课程信息Tile.TileCount = 0;
            this.课程信息Tile.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // 学生选课表Tile
            // 
            this.学生选课表Tile.ActiveControl = null;
            this.学生选课表Tile.Location = new System.Drawing.Point(78, 304);
            this.学生选课表Tile.Name = "学生选课表Tile";
            this.学生选课表Tile.Size = new System.Drawing.Size(128, 128);
            this.学生选课表Tile.Style = MetroFramework.MetroColorStyle.Blue;
            this.学生选课表Tile.StyleManager = this.metroStyleManager;
            this.学生选课表Tile.TabIndex = 9;
            this.学生选课表Tile.Text = "学生选课表";
            this.学生选课表Tile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.学生选课表Tile.TileCount = 0;
            this.学生选课表Tile.Click += new System.EventHandler(this.学生选课表Tile_Click);
            // 
            // LINQTile
            // 
            this.LINQTile.ActiveControl = null;
            this.LINQTile.Location = new System.Drawing.Point(230, 304);
            this.LINQTile.Name = "LINQTile";
            this.LINQTile.Size = new System.Drawing.Size(128, 128);
            this.LINQTile.Style = MetroFramework.MetroColorStyle.Blue;
            this.LINQTile.StyleManager = this.metroStyleManager;
            this.LINQTile.TabIndex = 10;
            this.LINQTile.Text = "查询信息";
            this.LINQTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LINQTile.TileCount = 0;
            this.LINQTile.Click += new System.EventHandler(this.LINQTile_Click);
            // 
            // 关于Tile
            // 
            this.关于Tile.ActiveControl = null;
            this.关于Tile.Location = new System.Drawing.Point(382, 457);
            this.关于Tile.Name = "关于Tile";
            this.关于Tile.Size = new System.Drawing.Size(128, 128);
            this.关于Tile.Style = MetroFramework.MetroColorStyle.Blue;
            this.关于Tile.StyleManager = this.metroStyleManager;
            this.关于Tile.TabIndex = 11;
            this.关于Tile.Text = "关于";
            this.关于Tile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.关于Tile.TileCount = 0;
            this.关于Tile.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // 退出Tile
            // 
            this.退出Tile.ActiveControl = null;
            this.退出Tile.Location = new System.Drawing.Point(542, 457);
            this.退出Tile.Name = "退出Tile";
            this.退出Tile.Size = new System.Drawing.Size(128, 128);
            this.退出Tile.Style = MetroFramework.MetroColorStyle.Blue;
            this.退出Tile.StyleManager = this.metroStyleManager;
            this.退出Tile.TabIndex = 12;
            this.退出Tile.Text = "退出";
            this.退出Tile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.退出Tile.TileCount = 0;
            this.退出Tile.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(78, 457);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(128, 128);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.StyleManager = this.metroStyleManager;
            this.metroTile1.TabIndex = 13;
            this.metroTile1.Text = "界面主题";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileCount = 0;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(542, 304);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(128, 128);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.StyleManager = this.metroStyleManager;
            this.metroTile2.TabIndex = 14;
            this.metroTile2.Text = "界面风格";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile2.TileCount = 0;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 681);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.退出Tile);
            this.Controls.Add(this.关于Tile);
            this.Controls.Add(this.LINQTile);
            this.Controls.Add(this.学生选课表Tile);
            this.Controls.Add(this.课程信息Tile);
            this.Controls.Add(this.学生信息Tile);
            this.Controls.Add(this.班级信息Tile);
            this.Controls.Add(this.系部信息Tile);
            this.Controls.Add(metroLink1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMain";
            this.Opacity = 0.8D;
            this.StyleManager = this.metroStyleManager;
            this.Text = "学生学籍管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frnMain_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        //private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTile 系部信息Tile;
        private MetroFramework.Controls.MetroTile 班级信息Tile;
        private MetroFramework.Controls.MetroTile 学生信息Tile;
        private MetroFramework.Controls.MetroTile 课程信息Tile;
        private MetroFramework.Controls.MetroTile 学生选课表Tile;
        private MetroFramework.Controls.MetroTile LINQTile;
        private MetroFramework.Controls.MetroTile 关于Tile;
        private MetroFramework.Controls.MetroTile 退出Tile;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}

