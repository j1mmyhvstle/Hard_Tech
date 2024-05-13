﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SoftQuanLyNhaHang.Views
{
    public partial class uctDesk : UserControl
    {
        #region declare
        public uctDesk()
        {
            InitializeComponent();
        }
        public static uctDesk uctdesk = new uctDesk();
        int flag = 0;
        #endregion

        #region function
        private void uctDesk_Load(object sender, EventArgs e)
        {
            getListDesk();
            loadCombobox();
            binding();
            dis_en(false);
        }

        public void getListDesk()
        {
            dgvDesk.DataSource = Controllers.DeskCtrl.findView().Tables[0];
            dgvDesk.Dock = DockStyle.Fill;
            dgvDesk.RowHeadersVisible = false;
            dgvDesk.BorderStyle = BorderStyle.Fixed3D;
        }

        void loadCombobox()
        {
            List<Models.cmbSelection> lstStatus = new List<Models.cmbSelection>();
            lstStatus.Add(new Models.cmbSelection(Models.constant.status_ready, "Chưa sử dụng"));
            lstStatus.Add(new Models.cmbSelection(Models.constant.status_busy, "Đang sử dụng"));
            lstStatus.Add(new Models.cmbSelection(Models.constant.status_upgrade, "Đang nâng cấp"));

            cmbStatus.DataSource = lstStatus;
            cmbStatus.DisplayMember = "name";
            cmbStatus.ValueMember = "id";

            List<Models.cmbSelection> lstStyle = new List<Models.cmbSelection>();
            lstStyle.Add(new Models.cmbSelection(Models.constant.style_ball, "Bida lỗ"));
            lstStyle.Add(new Models.cmbSelection(Models.constant.style_france, "Bida france"));

            cmbStyle.DataSource = lstStyle;
            cmbStyle.DisplayMember = "name";
            cmbStyle.ValueMember = "id";

        }

        void binding()
        {
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("Text", dgvDesk.DataSource, "id");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dgvDesk.DataSource, "name");
            cmbStyle.DataBindings.Clear();
            cmbStyle.DataBindings.Add("Text", dgvDesk.DataSource, "style");
            cmbStatus.DataBindings.Clear();
            cmbStatus.DataBindings.Add("Text", dgvDesk.DataSource, "status");
            txtFee.DataBindings.Clear();
            txtFee.DataBindings.Add("Text", dgvDesk.DataSource, "fee");
            txtDescription.DataBindings.Clear();
            txtDescription.DataBindings.Add("Text", dgvDesk.DataSource, "description");

        }

        void clearData()
        {
            txtId.Text = Controllers.DeskCtrl.generalid().ToString();
            txtName.Text = "";
            txtDescription.Text = "";
            txtFee.Text = "0";
        }

        void dis_en(bool e)
        {
            txtName.Enabled = e;
            cmbStyle.Enabled = e;
            txtDescription.Enabled = e;
            cmbStatus.Enabled = e;
            txtFee.Enabled = e;
            btnSave.Enabled = e;
            btnCancel.Enabled = e;
            btnAdd.Enabled = !e;
            btnDelete.Enabled = !e;
            btnEdit.Enabled = !e;
        }
        #endregion

        #region action
        private void btnAdd_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_en(true);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearData();
            uctDesk_Load(sender, e);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            long id = 0;
            if (txtId.Text != "")
                id = long.Parse(txtId.Text);
            if (id > 0)
            {
                Models.cmbSelection st = cmbStyle.SelectedItem as Models.cmbSelection;
                int style = st.id;
                string name = txtName.Text;
                string description = txtDescription.Text;
                Models.cmbSelection stt = cmbStatus.SelectedItem as Models.cmbSelection;
                int status = stt.id;
                float fee = float.Parse(txtFee.Text.Replace(",", ""));
                if (flag == 0)
                {
                    if (name == "")
                        MessageBox.Show("Hãy nhập tên bàn");
                    else
                    {
                        int i = 0;
                        i = Controllers.DeskCtrl.insert(id, name, style, description, status, fee);
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
                    i = Controllers.DeskCtrl.update(id, name, style, description, status, fee);
                    if (i > 0)
                    {
                        MessageBox.Show(" Sửa thành công");
                    }
                    else
                        MessageBox.Show("Sửa không thành công");
                }
            }
            else
                MessageBox.Show("Lỗi! Không tạo được mã bàn!");
            uctDesk_Load(sender, e);
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
                    i = Controllers.DeskCtrl.delete(id);
                    if (i > 0)
                    {
                        MessageBox.Show(" Xóa thành công");
                        uctDesk_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Xóa không thành công");
                }
                else
                    return;
            }
            else
            {
                MessageBox.Show("Lỗi! Không tìm thấy mã bàn đơn cần xóa");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }
        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtFee_TextChanged(object sender, EventArgs e)
        {
            string txt = txtFee.Text.Replace(",", "");
            if (txt != "")
            {
                txtFee.Text = string.Format("{0:0,0}", decimal.Parse(txt));
                txtFee.SelectionStart = txtFee.Text.Length;
                if (txt == "00")
                {
                    txtFee.Text = "";
                }
            }
        }
    #endregion
    }
}
