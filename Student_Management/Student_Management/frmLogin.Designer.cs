namespace Student_Management
{
    partial class frmLogin
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.cbIsManager = new System.Windows.Forms.CheckBox();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtPwd = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(89, 79);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(112, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "请输入用户名：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(104, 122);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(97, 15);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "请输入密码：";
            // 
            // cbIsManager
            // 
            this.cbIsManager.AutoSize = true;
            this.cbIsManager.Location = new System.Drawing.Point(193, 177);
            this.cbIsManager.Margin = new System.Windows.Forms.Padding(4);
            this.cbIsManager.Name = "cbIsManager";
            this.cbIsManager.Size = new System.Drawing.Size(74, 19);
            this.cbIsManager.TabIndex = 7;
            this.cbIsManager.Text = "管理员";
            this.cbIsManager.UseVisualStyleBackColor = true;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.CustomBackground = false;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(23, 91);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(51, 53);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroProgressSpinner1.StyleManager = null;
            this.metroProgressSpinner1.TabIndex = 8;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProgressSpinner1.Value = 50;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.FontSize = MetroFramework.MetroProgressBarSize.Medium;
            this.metroProgressBar1.FontWeight = MetroFramework.MetroProgressBarWeight.Light;
            this.metroProgressBar1.HideProgressText = true;
            this.metroProgressBar1.Location = new System.Drawing.Point(-1, 248);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(459, 5);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroProgressBar1.StyleManager = null;
            this.metroProgressBar1.TabIndex = 9;
            this.metroProgressBar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProgressBar1.Value = 30;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(56, 201);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(109, 30);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "登录";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(285, 201);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(107, 30);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "退出";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txtID
            // 
            this.txtID.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtID.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtID.Location = new System.Drawing.Point(220, 79);
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(155, 25);
            this.txtID.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.StyleManager = null;
            this.txtID.TabIndex = 12;
            this.txtID.Text = "2017302430";
            this.txtID.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.UseStyleColors = true;
            // 
            // txtPwd
            // 
            this.txtPwd.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtPwd.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtPwd.Location = new System.Drawing.Point(220, 121);
            this.txtPwd.Multiline = false;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.SelectedText = "";
            this.txtPwd.Size = new System.Drawing.Size(155, 25);
            this.txtPwd.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPwd.StyleManager = null;
            this.txtPwd.TabIndex = 13;
            this.txtPwd.Text = "990130";
            this.txtPwd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPwd.UseStyleColors = true;
            this.txtPwd.Click += new System.EventHandler(this.txtPwd_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 286);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.cbIsManager);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblID);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Opacity = 0.8D;
            this.Text = "登录系统";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.CheckBox cbIsManager;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        public MetroFramework.Controls.MetroTextBox txtPwd;
        public MetroFramework.Controls.MetroTextBox txtID;
    }
}