using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SoftQuanLyNhaHang.Views
{
    public partial class uctMenu : UserControl
    {
        public uctMenu()
        {
            InitializeComponent();
        }
        public static uctMenu uctBL = new uctMenu();
        int flag = 0;

        #region function
        private void uctMenu_Load(object sender, EventArgs e)
        {
            getListMenu();
            binding();
            dis_en(false);
        }
        void binding()
        {
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("Text", dgvMenus.DataSource, "id");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dgvMenus.DataSource, "name");
            txtUnit.DataBindings.Clear();
            txtUnit.DataBindings.Add("Text", dgvMenus.DataSource, "unit");
            txtPrice.DataBindings.Clear();
            txtPrice.DataBindings.Add("Text", dgvMenus.DataSource, "price");
            txtDescription.DataBindings.Clear();
            txtDescription.DataBindings.Add("Text", dgvMenus.DataSource, "description");

        }
        void clearData()
        {
            txtId.Text = Models.connection.ExcuteScalar(String.Format(Models.constant.createid_Menu));
            txtName.Text = "";
            txtUnit.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
        }
        void dis_en(bool e)
        {
            txtName.Enabled = e;
            txtUnit.Enabled = e;
            txtPrice.Enabled = e;
            txtDescription.Enabled = e;
            btnSave.Enabled = e;
            btnCancel.Enabled = e;
            btnAdd.Enabled = !e;
            btnDelete.Enabled = !e;
            btnEdit.Enabled = !e;
        }
        public void getListMenu()
        {
            dgvMenus.DataSource = Controllers.MenuCtrl.findView().Tables[0];
            dgvMenus.Dock = DockStyle.Fill;
            dgvMenus.RowHeadersVisible = false;
            dgvMenus.BorderStyle = BorderStyle.Fixed3D;
        }
        #endregion

        #region form action
        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_en(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearData();
            uctMenu_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            long id = 0;
            if (txtId.Text != "")
                id = long.Parse(txtId.Text);
            if (id > 0)
            {
                string name = "";
                try
                {
                    name = txtName.Text;
                }
                catch { }
                //
                string unit = "";
                try
                {
                    unit = txtUnit.Text;
                }
                catch { }
                //
                float price = 0f;
                try
                {
                    price = float.Parse(txtPrice.Text.Replace(",", ""));
                }
                catch { }
                //
                string description = "";
                try
                {
                    description = txtDescription.Text;
                }
                catch { }
                //
                if (flag == 0)
                {
                    if (name == "")
                        MessageBox.Show("Hãy nhập Tên thực đơn");
                    else
                    {
                        int i = 0;
                        i = Controllers.MenuCtrl.insert(id, name, unit, price, description);
                        if (i > 0)
                        {
                            MessageBox.Show("Thêm mới thành công");
                        }
                        else
                            MessageBox.Show("Thêm mới không thành công");
                    }
                }
                else
                {
                    int i = 0;
                    i = Controllers.MenuCtrl.update(id, name, unit, price, description);
                    if (i > 0)
                    {
                        MessageBox.Show(" Sửa thành công");
                    }
                    else
                        MessageBox.Show("Sửa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Lỗi! Không thể tạo mã thực đơn");
            }            
            uctMenu_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            long id = 0;
            if (txtId.Text != "")
                id = long.Parse(txtId.Text);
            if (id > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int i = 0;
                    i = Controllers.MenuCtrl.delete(id);
                    if (i > 0)
                    {
                        MessageBox.Show(" Xóa thành công");
                        uctMenu_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Xóa không thành công");
                }
                else
                    return;
            }
            else
            {
                MessageBox.Show("Lỗi! Không tìm thấy mã thực đơn cần xóa");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            string txt = txtPrice.Text.Replace(",", "");
            if (txt != "")
            {
                txtPrice.Text = string.Format("{0:0,0}", decimal.Parse(txt));
                txtPrice.SelectionStart = txtPrice.Text.Length;
                if (txt == "00")
                {
                    txtPrice.Text = "";
                }
            }
        }
        #endregion
    }
}
