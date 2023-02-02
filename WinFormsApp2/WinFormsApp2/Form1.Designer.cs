namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.cd_d = new MaterialSkin.Controls.MaterialCard();
            this.l_download = new MaterialSkin.Controls.MaterialLabel();
            this.btn_browse = new MaterialSkin.Controls.MaterialButton();
            this.btn_download = new MaterialSkin.Controls.MaterialButton();
            this.btn_clear = new MaterialSkin.Controls.MaterialButton();
            this.cb_name = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.pathin = new MaterialSkin.Controls.MaterialTextBox();
            this.namein = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_copy = new MaterialSkin.Controls.MaterialButton();
            this.desout = new MaterialSkin.Controls.MaterialTextBox();
            this.srcout = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_get = new MaterialSkin.Controls.MaterialButton();
            this.Idxin = new MaterialSkin.Controls.MaterialTextBox();
            this.Pagein = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.output = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cd_d.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(788, 377);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Controls.Add(this.cd_d);
            this.tabPage1.Controls.Add(this.btn_browse);
            this.tabPage1.Controls.Add(this.btn_download);
            this.tabPage1.Controls.Add(this.btn_clear);
            this.tabPage1.Controls.Add(this.cb_name);
            this.tabPage1.Controls.Add(this.materialLabel10);
            this.tabPage1.Controls.Add(this.pathin);
            this.tabPage1.Controls.Add(this.namein);
            this.tabPage1.Controls.Add(this.materialLabel9);
            this.tabPage1.Controls.Add(this.materialLabel8);
            this.tabPage1.Controls.Add(this.materialLabel7);
            this.tabPage1.Controls.Add(this.btn_copy);
            this.tabPage1.Controls.Add(this.desout);
            this.tabPage1.Controls.Add(this.srcout);
            this.tabPage1.Controls.Add(this.btn_get);
            this.tabPage1.Controls.Add(this.Idxin);
            this.tabPage1.Controls.Add(this.Pagein);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.ImageKey = "事项.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "功能";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.ImageKey = "(无)";
            this.materialButton1.Location = new System.Drawing.Point(466, 17);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(176, 36);
            this.materialButton1.TabIndex = 23;
            this.materialButton1.Text = "快速获取今日图片";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // cd_d
            // 
            this.cd_d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cd_d.Controls.Add(this.l_download);
            this.cd_d.Depth = 0;
            this.cd_d.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cd_d.Location = new System.Drawing.Point(498, 192);
            this.cd_d.Margin = new System.Windows.Forms.Padding(14);
            this.cd_d.MouseState = MaterialSkin.MouseState.HOVER;
            this.cd_d.Name = "cd_d";
            this.cd_d.Padding = new System.Windows.Forms.Padding(14);
            this.cd_d.Size = new System.Drawing.Size(268, 49);
            this.cd_d.TabIndex = 22;
            // 
            // l_download
            // 
            this.l_download.AutoSize = true;
            this.l_download.Depth = 0;
            this.l_download.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.l_download.Location = new System.Drawing.Point(17, 14);
            this.l_download.MouseState = MaterialSkin.MouseState.HOVER;
            this.l_download.Name = "l_download";
            this.l_download.Size = new System.Drawing.Size(65, 19);
            this.l_download.TabIndex = 0;
            this.l_download.Text = "等待获取";
            // 
            // btn_browse
            // 
            this.btn_browse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_browse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_browse.Depth = 0;
            this.btn_browse.HighEmphasis = true;
            this.btn_browse.Icon = ((System.Drawing.Image)(resources.GetObject("btn_browse.Icon")));
            this.btn_browse.Location = new System.Drawing.Point(584, 261);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_browse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_browse.Size = new System.Drawing.Size(81, 36);
            this.btn_browse.TabIndex = 21;
            this.btn_browse.Text = "浏览";
            this.btn_browse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_browse.UseAccentColor = false;
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_download
            // 
            this.btn_download.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_download.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_download.Depth = 0;
            this.btn_download.Enabled = false;
            this.btn_download.HighEmphasis = true;
            this.btn_download.Icon = ((System.Drawing.Image)(resources.GetObject("btn_download.Icon")));
            this.btn_download.Location = new System.Drawing.Point(220, 306);
            this.btn_download.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_download.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_download.Name = "btn_download";
            this.btn_download.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_download.Size = new System.Drawing.Size(81, 36);
            this.btn_download.TabIndex = 20;
            this.btn_download.Text = "下载";
            this.btn_download.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_download.UseAccentColor = false;
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_clear.Depth = 0;
            this.btn_clear.Enabled = false;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.HighEmphasis = true;
            this.btn_clear.Icon = ((System.Drawing.Image)(resources.GetObject("btn_clear.Icon")));
            this.btn_clear.Location = new System.Drawing.Point(650, 17);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_clear.Size = new System.Drawing.Size(81, 36);
            this.btn_clear.TabIndex = 19;
            this.btn_clear.Text = "清空";
            this.btn_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_clear.UseAccentColor = true;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cb_name
            // 
            this.cb_name.AutoSize = true;
            this.cb_name.Checked = true;
            this.cb_name.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_name.Depth = 0;
            this.cb_name.Location = new System.Drawing.Point(369, 221);
            this.cb_name.Margin = new System.Windows.Forms.Padding(0);
            this.cb_name.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cb_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_name.Name = "cb_name";
            this.cb_name.ReadOnly = false;
            this.cb_name.Ripple = true;
            this.cb_name.Size = new System.Drawing.Size(115, 37);
            this.cb_name.TabIndex = 18;
            this.cb_name.Text = "自动命名：";
            this.cb_name.UseVisualStyleBackColor = true;
            this.cb_name.CheckedChanged += new System.EventHandler(this.cb_name_CheckedChanged);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(317, 234);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(27, 19);
            this.materialLabel10.TabIndex = 17;
            this.materialLabel10.Text = ".jpg";
            // 
            // pathin
            // 
            this.pathin.AnimateReadOnly = false;
            this.pathin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathin.Depth = 0;
            this.pathin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathin.Hint = "保存路径";
            this.pathin.LeadingIcon = null;
            this.pathin.Location = new System.Drawing.Point(220, 261);
            this.pathin.MaxLength = 50;
            this.pathin.MouseState = MaterialSkin.MouseState.OUT;
            this.pathin.Multiline = false;
            this.pathin.Name = "pathin";
            this.pathin.Size = new System.Drawing.Size(348, 36);
            this.pathin.TabIndex = 16;
            this.pathin.Text = "./";
            this.pathin.TrailingIcon = null;
            this.pathin.UseTallSize = false;
            // 
            // namein
            // 
            this.namein.AnimateReadOnly = false;
            this.namein.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namein.Depth = 0;
            this.namein.Enabled = false;
            this.namein.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.namein.Hint = "文件名";
            this.namein.LeadingIcon = null;
            this.namein.Location = new System.Drawing.Point(220, 217);
            this.namein.MaxLength = 50;
            this.namein.MouseState = MaterialSkin.MouseState.OUT;
            this.namein.Multiline = false;
            this.namein.Name = "namein";
            this.namein.Size = new System.Drawing.Size(91, 36);
            this.namein.TabIndex = 15;
            this.namein.Text = "";
            this.namein.TrailingIcon = null;
            this.namein.UseTallSize = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(110, 278);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(81, 19);
            this.materialLabel9.TabIndex = 14;
            this.materialLabel9.Text = "文件路径：";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(110, 234);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(65, 19);
            this.materialLabel8.TabIndex = 13;
            this.materialLabel8.Text = "文件名：";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(66, 201);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(49, 19);
            this.materialLabel7.TabIndex = 12;
            this.materialLabel7.Text = "下载：";
            // 
            // btn_copy
            // 
            this.btn_copy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_copy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_copy.Depth = 0;
            this.btn_copy.Enabled = false;
            this.btn_copy.HighEmphasis = true;
            this.btn_copy.Icon = null;
            this.btn_copy.Location = new System.Drawing.Point(641, 90);
            this.btn_copy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_copy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_copy.Size = new System.Drawing.Size(64, 36);
            this.btn_copy.TabIndex = 11;
            this.btn_copy.Text = "复制";
            this.btn_copy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_copy.UseAccentColor = false;
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // desout
            // 
            this.desout.AnimateReadOnly = false;
            this.desout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.desout.Depth = 0;
            this.desout.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.desout.Hint = "图片描述";
            this.desout.LeadingIcon = null;
            this.desout.Location = new System.Drawing.Point(165, 143);
            this.desout.MaxLength = 50;
            this.desout.MouseState = MaterialSkin.MouseState.OUT;
            this.desout.Multiline = false;
            this.desout.Name = "desout";
            this.desout.ReadOnly = true;
            this.desout.Size = new System.Drawing.Size(469, 36);
            this.desout.TabIndex = 10;
            this.desout.Text = "";
            this.desout.TrailingIcon = null;
            this.desout.UseTallSize = false;
            // 
            // srcout
            // 
            this.srcout.AnimateReadOnly = false;
            this.srcout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.srcout.Depth = 0;
            this.srcout.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.srcout.Hint = "图片链接";
            this.srcout.LeadingIcon = null;
            this.srcout.Location = new System.Drawing.Point(165, 90);
            this.srcout.MaxLength = 50;
            this.srcout.MouseState = MaterialSkin.MouseState.OUT;
            this.srcout.Multiline = false;
            this.srcout.Name = "srcout";
            this.srcout.ReadOnly = true;
            this.srcout.Size = new System.Drawing.Size(469, 36);
            this.srcout.TabIndex = 9;
            this.srcout.Text = "";
            this.srcout.TrailingIcon = null;
            this.srcout.UseTallSize = false;
            // 
            // btn_get
            // 
            this.btn_get.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_get.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_get.Depth = 0;
            this.btn_get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_get.HighEmphasis = true;
            this.btn_get.Icon = ((System.Drawing.Image)(resources.GetObject("btn_get.Icon")));
            this.btn_get.ImageKey = "(无)";
            this.btn_get.Location = new System.Drawing.Point(369, 17);
            this.btn_get.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_get.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_get.Name = "btn_get";
            this.btn_get.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_get.Size = new System.Drawing.Size(81, 36);
            this.btn_get.TabIndex = 8;
            this.btn_get.Text = "获取";
            this.btn_get.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_get.UseAccentColor = false;
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // Idxin
            // 
            this.Idxin.AnimateReadOnly = false;
            this.Idxin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Idxin.Depth = 0;
            this.Idxin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Idxin.Hint = "图片索引";
            this.Idxin.LeadingIcon = null;
            this.Idxin.Location = new System.Drawing.Point(294, 17);
            this.Idxin.MaxLength = 50;
            this.Idxin.MouseState = MaterialSkin.MouseState.OUT;
            this.Idxin.Multiline = false;
            this.Idxin.Name = "Idxin";
            this.Idxin.Size = new System.Drawing.Size(68, 36);
            this.Idxin.TabIndex = 7;
            this.Idxin.Text = "";
            this.Idxin.TrailingIcon = null;
            this.Idxin.UseTallSize = false;
            // 
            // Pagein
            // 
            this.Pagein.AnimateReadOnly = false;
            this.Pagein.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pagein.Depth = 0;
            this.Pagein.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Pagein.Hint = "网站页码";
            this.Pagein.LeadingIcon = null;
            this.Pagein.Location = new System.Drawing.Point(165, 17);
            this.Pagein.MaxLength = 50;
            this.Pagein.MouseState = MaterialSkin.MouseState.OUT;
            this.Pagein.Multiline = false;
            this.Pagein.Name = "Pagein";
            this.Pagein.Size = new System.Drawing.Size(68, 36);
            this.Pagein.TabIndex = 6;
            this.Pagein.Text = "";
            this.Pagein.TrailingIcon = null;
            this.Pagein.UseTallSize = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(110, 160);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(49, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "描述：";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(110, 107);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(49, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "链接：";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(66, 74);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(49, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "输出：";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(239, 34);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(49, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "索引：";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(110, 34);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "页码：";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(66, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "输入：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialLabel11);
            this.tabPage2.Controls.Add(this.output);
            this.tabPage2.ImageKey = "工作台.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "日志";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(65, 12);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(49, 19);
            this.materialLabel11.TabIndex = 1;
            this.materialLabel11.Text = "日志：";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Depth = 0;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.output.Location = new System.Drawing.Point(65, 44);
            this.output.MouseState = MaterialSkin.MouseState.HOVER;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(709, 292);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "系统设置.png");
            this.imageList1.Images.SetKeyName(1, "工作台.png");
            this.imageList1.Images.SetKeyName(2, "事项.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "跳过.png");
            this.imageList2.Images.SetKeyName(1, "下载.png");
            this.imageList2.Images.SetKeyName(2, "删除.png");
            this.imageList2.Images.SetKeyName(3, "日志.png");
            this.imageList2.Images.SetKeyName(4, "下一步.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerWidth = 150;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.cd_d.ResumeLayout(false);
            this.cd_d.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialCheckbox cb_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox pathin;
        private MaterialSkin.Controls.MaterialTextBox namein;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton btn_copy;
        private MaterialSkin.Controls.MaterialTextBox desout;
        private MaterialSkin.Controls.MaterialTextBox srcout;
        private MaterialSkin.Controls.MaterialButton btn_get;
        private MaterialSkin.Controls.MaterialTextBox Idxin;
        private MaterialSkin.Controls.MaterialTextBox Pagein;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btn_clear;
        private ImageList imageList2;
        private MaterialSkin.Controls.MaterialButton btn_download;
        private MaterialSkin.Controls.MaterialButton btn_browse;
        private MaterialSkin.Controls.MaterialCard cd_d;
        private MaterialSkin.Controls.MaterialLabel l_download;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialMultiLineTextBox output;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}