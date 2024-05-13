namespace SoftQuanLyNhaHang.Views
{
    partial class uctMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grDanhSachBan = new System.Windows.Forms.GroupBox();
            this.dgvMenus = new System.Windows.Forms.DataGridView();
            this.MenuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grThongTinBan = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grDanhSachBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).BeginInit();
            this.grThongTinBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(716, 408);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 123;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1148, 408);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 100);
            this.btnCancel.TabIndex = 127;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1040, 408);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 100);
            this.btnSave.TabIndex = 126;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(932, 408);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 100);
            this.btnDelete.TabIndex = 125;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grDanhSachBan
            // 
            this.grDanhSachBan.Controls.Add(this.dgvMenus);
            this.grDanhSachBan.Location = new System.Drawing.Point(6, 76);
            this.grDanhSachBan.Margin = new System.Windows.Forms.Padding(4);
            this.grDanhSachBan.Name = "grDanhSachBan";
            this.grDanhSachBan.Padding = new System.Windows.Forms.Padding(4);
            this.grDanhSachBan.Size = new System.Drawing.Size(706, 533);
            this.grDanhSachBan.TabIndex = 121;
            this.grDanhSachBan.TabStop = false;
            // 
            // dgvMenus
            // 
            this.dgvMenus.AllowUserToAddRows = false;
            this.dgvMenus.AllowUserToDeleteRows = false;
            this.dgvMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenus.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuId,
            this.MenuName,
            this.MenuUnit,
            this.MenuPrice,
            this.MenuDescription});
            this.dgvMenus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMenus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvMenus.Location = new System.Drawing.Point(4, 23);
            this.dgvMenus.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMenus.Name = "dgvMenus";
            this.dgvMenus.ReadOnly = true;
            this.dgvMenus.RowHeadersWidth = 51;
            this.dgvMenus.Size = new System.Drawing.Size(698, 506);
            this.dgvMenus.TabIndex = 88;
            // 
            // MenuId
            // 
            this.MenuId.DataPropertyName = "id";
            this.MenuId.HeaderText = "Mã thực đơn";
            this.MenuId.MinimumWidth = 6;
            this.MenuId.Name = "MenuId";
            this.MenuId.ReadOnly = true;
            // 
            // MenuName
            // 
            this.MenuName.DataPropertyName = "name";
            this.MenuName.HeaderText = "Tên thực đơn";
            this.MenuName.MinimumWidth = 6;
            this.MenuName.Name = "MenuName";
            this.MenuName.ReadOnly = true;
            // 
            // MenuUnit
            // 
            this.MenuUnit.DataPropertyName = "unit";
            this.MenuUnit.HeaderText = "Đơn vị tính";
            this.MenuUnit.MinimumWidth = 6;
            this.MenuUnit.Name = "MenuUnit";
            this.MenuUnit.ReadOnly = true;
            // 
            // MenuPrice
            // 
            this.MenuPrice.DataPropertyName = "price";
            this.MenuPrice.HeaderText = "Giá tiền (đ)";
            this.MenuPrice.MinimumWidth = 6;
            this.MenuPrice.Name = "MenuPrice";
            this.MenuPrice.ReadOnly = true;
            // 
            // MenuDescription
            // 
            this.MenuDescription.DataPropertyName = "description";
            this.MenuDescription.HeaderText = "Ghi chú";
            this.MenuDescription.MinimumWidth = 6;
            this.MenuDescription.Name = "MenuDescription";
            this.MenuDescription.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 100;
            this.label7.Text = "vnđ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(181, 290);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(296, 26);
            this.txtPrice.TabIndex = 98;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 99;
            this.label5.Text = "Giá Tiền:";
            // 
            // grThongTinBan
            // 
            this.grThongTinBan.Controls.Add(this.txtName);
            this.grThongTinBan.Controls.Add(this.label3);
            this.grThongTinBan.Controls.Add(this.label7);
            this.grThongTinBan.Controls.Add(this.txtPrice);
            this.grThongTinBan.Controls.Add(this.label5);
            this.grThongTinBan.Controls.Add(this.txtDescription);
            this.grThongTinBan.Controls.Add(this.label8);
            this.grThongTinBan.Controls.Add(this.txtUnit);
            this.grThongTinBan.Controls.Add(this.label2);
            this.grThongTinBan.Controls.Add(this.txtId);
            this.grThongTinBan.Controls.Add(this.label6);
            this.grThongTinBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinBan.Location = new System.Drawing.Point(720, 76);
            this.grThongTinBan.Margin = new System.Windows.Forms.Padding(4);
            this.grThongTinBan.Name = "grThongTinBan";
            this.grThongTinBan.Padding = new System.Windows.Forms.Padding(4);
            this.grThongTinBan.Size = new System.Drawing.Size(528, 324);
            this.grThongTinBan.TabIndex = 122;
            this.grThongTinBan.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 26);
            this.txtName.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 102;
            this.label3.Text = "Tên Thực Đơn:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(181, 125);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(296, 123);
            this.txtDescription.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 95;
            this.label8.Text = "Ghi Chú :";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(181, 91);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(296, 26);
            this.txtUnit.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 91;
            this.label2.Text = "Đơn vị Tính:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(181, 23);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(296, 26);
            this.txtId.TabIndex = 93;
            this.txtId.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 92;
            this.label6.Text = "Mã Thực Đơn:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(824, 408);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 100);
            this.btnEdit.TabIndex = 124;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 45);
            this.label1.TabIndex = 120;
            this.label1.Text = "DANH SÁCH THỰC ĐƠN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(712, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 45);
            this.label4.TabIndex = 119;
            this.label4.Text = "THÔNG TIN THỰC ĐƠN";
            // 
            // uctMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grDanhSachBan);
            this.Controls.Add(this.grThongTinBan);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "uctMenu";
            this.Size = new System.Drawing.Size(1254, 613);
            this.Load += new System.EventHandler(this.uctMenu_Load);
            this.grDanhSachBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).EndInit();
            this.grThongTinBan.ResumeLayout(false);
            this.grThongTinBan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grDanhSachBan;
        private System.Windows.Forms.DataGridView dgvMenus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grThongTinBan;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuDescription;
    }
}
