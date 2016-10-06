namespace zoo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lstThuMoi = new System.Windows.Forms.ListBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageKey = "save-icon.png";
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(267, 302);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu danh sách";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.Save);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thú mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách thú:";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 334);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label3";
            // 
            // lstThuMoi
            // 
            this.lstThuMoi.AllowDrop = true;
            this.lstThuMoi.FormattingEnabled = true;
            this.lstThuMoi.Location = new System.Drawing.Point(12, 79);
            this.lstThuMoi.Name = "lstThuMoi";
            this.lstThuMoi.Size = new System.Drawing.Size(136, 199);
            this.lstThuMoi.TabIndex = 4;
            this.lstThuMoi.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lstThuMoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.AllowDrop = true;
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.Location = new System.Drawing.Point(185, 79);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(148, 199);
            this.lstDanhSach.TabIndex = 5;
            this.lstDanhSach.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDanhSach_DragDrop);
            this.lstDanhSach.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save-icon.png");
            this.imageList1.Images.SetKeyName(1, "save-icon.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơToolStripMenuItem,
            this.hồSơToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoad,
            this.menuLuu,
            this.menuClose});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.hồSơToolStripMenuItem.Text = "Danh sách";
            // 
            // menuLoad
            // 
            this.menuLoad.Name = "menuLoad";
            this.menuLoad.Size = new System.Drawing.Size(152, 22);
            this.menuLoad.Text = "Tải danh sách";
            this.menuLoad.Click += new System.EventHandler(this.menuLuu_Click);
            // 
            // menuLuu
            // 
            this.menuLuu.Image = ((System.Drawing.Image)(resources.GetObject("menuLuu.Image")));
            this.menuLuu.Name = "menuLuu";
            this.menuLuu.Size = new System.Drawing.Size(152, 22);
            this.menuLuu.Text = "Lưu danh sách";
            this.menuLuu.Click += new System.EventHandler(this.menuLuu_Click);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(152, 22);
            this.menuClose.Text = "Kết thúc";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // hồSơToolStripMenuItem1
            // 
            this.hồSơToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoToolStripMenuItem,
            this.cắtToolStripMenuItem,
            this.dánToolStripMenuItem});
            this.hồSơToolStripMenuItem1.Name = "hồSơToolStripMenuItem1";
            this.hồSơToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.hồSơToolStripMenuItem1.Text = "Hồ sơ";
            // 
            // saoToolStripMenuItem
            // 
            this.saoToolStripMenuItem.Name = "saoToolStripMenuItem";
            this.saoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.saoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saoToolStripMenuItem.Text = "Sao";
            // 
            // cắtToolStripMenuItem
            // 
            this.cắtToolStripMenuItem.Name = "cắtToolStripMenuItem";
            this.cắtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cắtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cắtToolStripMenuItem.Text = "Cắt";
            // 
            // dánToolStripMenuItem
            // 
            this.dánToolStripMenuItem.Name = "dánToolStripMenuItem";
            this.dánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.dánToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dánToolStripMenuItem.Text = "Dán";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 371);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.lstThuMoi);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ListBox lstThuMoi;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLoad;
        private System.Windows.Forms.ToolStripMenuItem menuLuu;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cắtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dánToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

