namespace SoftQuanLyNhaHang.Views
{
    partial class uctDesk
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDesk = new System.Windows.Forms.DataGridView();
            this.BillardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillardStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillardStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillardFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillardDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grThongTinBan = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grDanhSachBan = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesk)).BeginInit();
            this.grThongTinBan.SuspendLayout();
            this.grDanhSachBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(723, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 45);
            this.label4.TabIndex = 105;
            this.label4.Text = "THÔNG TIN BÀN BIDA";
            // 
            // cmbStyle
            // 
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Location = new System.Drawing.Point(164, 61);
            this.cmbStyle.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(284, 34);
            this.cmbStyle.TabIndex = 97;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(164, 145);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(284, 34);
            this.cmbStatus.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 94;
            this.label10.Text = "Trạng Thái :";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(164, 187);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(284, 74);
            this.txtDescription.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 45);
            this.label1.TabIndex = 106;
            this.label1.Text = "DANH SÁCH BÀN BIDA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 187);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 95;
            this.label8.Text = "Ghi Chú :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(164, 103);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 34);
            this.txtName.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tên Bàn :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(164, 19);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(284, 34);
            this.txtId.TabIndex = 93;
            this.txtId.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 92;
            this.label3.Text = "Loại Bàn :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 92;
            this.label6.Text = "Mã Bàn :";
            // 
            // dgvDesk
            // 
            this.dgvDesk.AllowUserToAddRows = false;
            this.dgvDesk.AllowUserToDeleteRows = false;
            this.dgvDesk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesk.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDesk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillardId,
            this.BillardName,
            this.BillardStyle,
            this.BillardStatus,
            this.BillardFee,
            this.BillardDescription});
            this.dgvDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDesk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDesk.Location = new System.Drawing.Point(4, 19);
            this.dgvDesk.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDesk.Name = "dgvDesk";
            this.dgvDesk.ReadOnly = true;
            this.dgvDesk.RowHeadersWidth = 51;
            this.dgvDesk.Size = new System.Drawing.Size(698, 493);
            this.dgvDesk.TabIndex = 88;
            // 
            // BillardId
            // 
            this.BillardId.DataPropertyName = "id";
            this.BillardId.HeaderText = "Mã bàn";
            this.BillardId.MinimumWidth = 6;
            this.BillardId.Name = "BillardId";
            this.BillardId.ReadOnly = true;
            // 
            // BillardName
            // 
            this.BillardName.DataPropertyName = "name";
            this.BillardName.HeaderText = "Tên bàn";
            this.BillardName.MinimumWidth = 6;
            this.BillardName.Name = "BillardName";
            this.BillardName.ReadOnly = true;
            // 
            // BillardStyle
            // 
            this.BillardStyle.DataPropertyName = "style";
            this.BillardStyle.HeaderText = "Loại bàn";
            this.BillardStyle.MinimumWidth = 6;
            this.BillardStyle.Name = "BillardStyle";
            this.BillardStyle.ReadOnly = true;
            // 
            // BillardStatus
            // 
            this.BillardStatus.DataPropertyName = "status";
            this.BillardStatus.HeaderText = "Trạng thái";
            this.BillardStatus.MinimumWidth = 6;
            this.BillardStatus.Name = "BillardStatus";
            this.BillardStatus.ReadOnly = true;
            // 
            // BillardFee
            // 
            this.BillardFee.DataPropertyName = "fee";
            this.BillardFee.HeaderText = "Tiền giờ (đ)";
            this.BillardFee.MinimumWidth = 6;
            this.BillardFee.Name = "BillardFee";
            this.BillardFee.ReadOnly = true;
            // 
            // BillardDescription
            // 
            this.BillardDescription.DataPropertyName = "description";
            this.BillardDescription.HeaderText = "Ghi chú";
            this.BillardDescription.MinimumWidth = 6;
            this.BillardDescription.Name = "BillardDescription";
            this.BillardDescription.ReadOnly = true;
            // 
            // grThongTinBan
            // 
            this.grThongTinBan.Controls.Add(this.label7);
            this.grThongTinBan.Controls.Add(this.txtFee);
            this.grThongTinBan.Controls.Add(this.label5);
            this.grThongTinBan.Controls.Add(this.cmbStyle);
            this.grThongTinBan.Controls.Add(this.cmbStatus);
            this.grThongTinBan.Controls.Add(this.label10);
            this.grThongTinBan.Controls.Add(this.txtDescription);
            this.grThongTinBan.Controls.Add(this.label8);
            this.grThongTinBan.Controls.Add(this.txtName);
            this.grThongTinBan.Controls.Add(this.label2);
            this.grThongTinBan.Controls.Add(this.txtId);
            this.grThongTinBan.Controls.Add(this.label3);
            this.grThongTinBan.Controls.Add(this.label6);
            this.grThongTinBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinBan.Location = new System.Drawing.Point(718, 89);
            this.grThongTinBan.Margin = new System.Windows.Forms.Padding(4);
            this.grThongTinBan.Name = "grThongTinBan";
            this.grThongTinBan.Padding = new System.Windows.Forms.Padding(4);
            this.grThongTinBan.Size = new System.Drawing.Size(532, 318);
            this.grThongTinBan.TabIndex = 108;
            this.grThongTinBan.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 273);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 100;
            this.label7.Text = "vnđ";
            // 
            // txtFee
            // 
            this.txtFee.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(164, 269);
            this.txtFee.Margin = new System.Windows.Forms.Padding(4);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(284, 34);
            this.txtFee.TabIndex = 98;
            this.txtFee.TextChanged += new System.EventHandler(this.txtFee_TextChanged);
            this.txtFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFee_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 99;
            this.label5.Text = "Tiền mỗi giờ:";
            // 
            // grDanhSachBan
            // 
            this.grDanhSachBan.Controls.Add(this.dgvDesk);
            this.grDanhSachBan.Location = new System.Drawing.Point(4, 89);
            this.grDanhSachBan.Margin = new System.Windows.Forms.Padding(4);
            this.grDanhSachBan.Name = "grDanhSachBan";
            this.grDanhSachBan.Padding = new System.Windows.Forms.Padding(4);
            this.grDanhSachBan.Size = new System.Drawing.Size(706, 516);
            this.grDanhSachBan.TabIndex = 107;
            this.grDanhSachBan.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(718, 415);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 114;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1150, 415);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 100);
            this.btnCancel.TabIndex = 118;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1042, 415);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 100);
            this.btnSave.TabIndex = 117;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(826, 415);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 100);
            this.btnEdit.TabIndex = 115;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(934, 415);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 100);
            this.btnDelete.TabIndex = 116;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // uctDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grThongTinBan);
            this.Controls.Add(this.grDanhSachBan);
            this.Name = "uctDesk";
            this.Size = new System.Drawing.Size(1254, 613);
            this.Load += new System.EventHandler(this.uctDesk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesk)).EndInit();
            this.grThongTinBan.ResumeLayout(false);
            this.grThongTinBan.PerformLayout();
            this.grDanhSachBan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStyle;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDesk;
        private System.Windows.Forms.GroupBox grThongTinBan;
        private System.Windows.Forms.GroupBox grDanhSachBan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillardStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillardStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillardFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillardDescription;
    }
}
