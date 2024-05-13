namespace SoftQuanLyNhaHang.Views
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.TabHienThi = new System.Windows.Forms.TabControl();
            this.ctxtmenuTabHienThi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDongTrang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDongTrangAll = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtmenuTabBan = new System.Windows.Forms.MenuStrip();
            this.bILLIARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bidaManagermentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.thựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.billardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.quảnLýHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtmenuTabHienThi.SuspendLayout();
            this.ctxtmenuTabBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabHienThi
            // 
            this.TabHienThi.ContextMenuStrip = this.ctxtmenuTabHienThi;
            this.TabHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabHienThi.Location = new System.Drawing.Point(0, 31);
            this.TabHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.TabHienThi.Name = "TabHienThi";
            this.TabHienThi.SelectedIndex = 0;
            this.TabHienThi.Size = new System.Drawing.Size(1262, 642);
            this.TabHienThi.TabIndex = 1;
            // 
            // ctxtmenuTabHienThi
            // 
            this.ctxtmenuTabHienThi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtmenuTabHienThi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDongTrang,
            this.menuItemDongTrangAll});
            this.ctxtmenuTabHienThi.Name = "ctxtmenuTabHienThi";
            this.ctxtmenuTabHienThi.Size = new System.Drawing.Size(208, 52);
            // 
            // menuItemDongTrang
            // 
            this.menuItemDongTrang.Name = "menuItemDongTrang";
            this.menuItemDongTrang.Size = new System.Drawing.Size(207, 24);
            this.menuItemDongTrang.Text = "Đóng trang hiện tại";
            this.menuItemDongTrang.Click += new System.EventHandler(this.menuItemDongTrang_Click);
            // 
            // menuItemDongTrangAll
            // 
            this.menuItemDongTrangAll.Name = "menuItemDongTrangAll";
            this.menuItemDongTrangAll.Size = new System.Drawing.Size(207, 24);
            this.menuItemDongTrangAll.Text = "Đóng tất cả";
            this.menuItemDongTrangAll.Click += new System.EventHandler(this.menuItemDongTrangAll_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(130, 27);
            this.thoátToolStripMenuItem.Text = "Đăng xuất";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // ctxtmenuTabBan
            // 
            this.ctxtmenuTabBan.BackColor = System.Drawing.Color.Lavender;
            this.ctxtmenuTabBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ctxtmenuTabBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxtmenuTabBan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtmenuTabBan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bILLIARDToolStripMenuItem,
            this.bidaManagermentToolStripMenuItem,
            this.quảnLýHệThốngToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.ctxtmenuTabBan.Location = new System.Drawing.Point(0, 0);
            this.ctxtmenuTabBan.Name = "ctxtmenuTabBan";
            this.ctxtmenuTabBan.Size = new System.Drawing.Size(1262, 31);
            this.ctxtmenuTabBan.TabIndex = 0;
            this.ctxtmenuTabBan.Text = "menuStrip1";
            // 
            // bILLIARDToolStripMenuItem
            // 
            this.bILLIARDToolStripMenuItem.Name = "bILLIARDToolStripMenuItem";
            this.bILLIARDToolStripMenuItem.Size = new System.Drawing.Size(119, 27);
            this.bILLIARDToolStripMenuItem.Text = "BILLIARD";
            this.bILLIARDToolStripMenuItem.Click += new System.EventHandler(this.bILLIARDToolStripMenuItem_Click);
            // 
            // bidaManagermentToolStripMenuItem
            // 
            this.bidaManagermentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.thựcĐơnToolStripMenuItem,
            this.toolStripSeparator5,
            this.billardToolStripMenuItem,
            this.toolStripSeparator6});
            this.bidaManagermentToolStripMenuItem.Name = "bidaManagermentToolStripMenuItem";
            this.bidaManagermentToolStripMenuItem.Size = new System.Drawing.Size(110, 27);
            this.bidaManagermentToolStripMenuItem.Text = "Danh Mục";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // thựcĐơnToolStripMenuItem
            // 
            this.thựcĐơnToolStripMenuItem.Name = "thựcĐơnToolStripMenuItem";
            this.thựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.thựcĐơnToolStripMenuItem.Text = "Thực đơn";
            this.thựcĐơnToolStripMenuItem.Click += new System.EventHandler(this.thựcĐơnToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // billardToolStripMenuItem
            // 
            this.billardToolStripMenuItem.Name = "billardToolStripMenuItem";
            this.billardToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.billardToolStripMenuItem.Text = "Bàn Bida";
            this.billardToolStripMenuItem.Click += new System.EventHandler(this.billardToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(221, 6);
            // 
            // quảnLýHệThốngToolStripMenuItem
            // 
            this.quảnLýHệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem1});
            this.quảnLýHệThốngToolStripMenuItem.Name = "quảnLýHệThốngToolStripMenuItem";
            this.quảnLýHệThốngToolStripMenuItem.Size = new System.Drawing.Size(167, 27);
            this.quảnLýHệThốngToolStripMenuItem.Text = "Quản lý hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem1
            // 
            this.đổiMậtKhẩuToolStripMenuItem1.Name = "đổiMậtKhẩuToolStripMenuItem1";
            this.đổiMậtKhẩuToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.đổiMậtKhẩuToolStripMenuItem1.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem1.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ContextMenuStrip = this.ctxtmenuTabHienThi;
            this.Controls.Add(this.TabHienThi);
            this.Controls.Add(this.ctxtmenuTabBan);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ctxtmenuTabBan;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Bida Ông Thọ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ctxtmenuTabHienThi.ResumeLayout(false);
            this.ctxtmenuTabBan.ResumeLayout(false);
            this.ctxtmenuTabBan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabHienThi;
        private System.Windows.Forms.ContextMenuStrip ctxtmenuTabHienThi;
        private System.Windows.Forms.ToolStripMenuItem menuItemDongTrang;
        private System.Windows.Forms.ToolStripMenuItem menuItemDongTrangAll;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ctxtmenuTabBan;
        private System.Windows.Forms.ToolStripMenuItem bidaManagermentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem thựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem bILLIARDToolStripMenuItem;
    }
}