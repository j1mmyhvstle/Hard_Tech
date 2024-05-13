using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SoftQuanLyNhaHang.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();
        public void ThemTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            // Kiểm tra tồn tại trang này chưa
            for (int i = 0; i < TabHienThi.TabPages.Count; i++)
            {
                if (TabHienThi.TabPages[i].Contains(uct) == true)
                {
                    TabHienThi.SelectedTab = TabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = TabHienThi.Size;
            tab.Text = tenTab;
            TabHienThi.TabPages.Add(tab);
            TabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();

        }
        public void DongTabHienTai()
        {
            TabHienThi.TabPages.Remove(TabHienThi.SelectedTab);
        }
        public void DongAllTab()
        {
            while (TabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            bILLIARDToolStripMenuItem_Click(sender, e);
        }
        
        private void menuItemDongTrang_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void menuItemDongTrangAll_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Restart();
                //Application.Exit();
            }
            else
                return;
        }
        
        private void billardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(uctDesk.uctdesk, 4, "DS Bàn Bida ");
        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(uctMenu.uctBL, 4, "DS Thực đơn ");
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUpdateUserlogin frm = new frmUpdateUserlogin();
            frm.ShowDialog();
        }

        private void bILLIARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(uctBilliards.uctBL, 4, "Khu vực CLB ");
        }
    }
}
