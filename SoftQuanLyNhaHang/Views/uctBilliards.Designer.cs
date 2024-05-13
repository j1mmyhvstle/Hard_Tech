namespace SoftQuanLyNhaHang.Views
{
    partial class uctBilliards
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctBilliards));
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnEditDetail = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvMenus = new System.Windows.Forms.DataGridView();
            this.MenuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDetailid = new System.Windows.Forms.TextBox();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.did = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dquantum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvDesk = new System.Windows.Forms.ListView();
            this.ctxtnenuTabDanhSachBan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịBànCóNgườiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịBànĐangBảoTrìToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịTấtCảBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtDeskid = new System.Windows.Forms.TextBox();
            this.txtReceiptionid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFee = new System.Windows.Forms.Label();
            this.lbDeskfee = new System.Windows.Forms.Label();
            this.lbTotalminute = new System.Windows.Forms.Label();
            this.lbTimebegin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSumdetail = new System.Windows.Forms.Label();
            this.btnDelDetail = new System.Windows.Forms.Button();
            this.txtDetailName = new System.Windows.Forms.TextBox();
            this.txtDetailUnit = new System.Windows.Forms.TextBox();
            this.txtDetailPrice = new System.Windows.Forms.TextBox();
            this.txtDetailQuantum = new System.Windows.Forms.TextBox();
            this.txtDetailTotal = new System.Windows.Forms.TextBox();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtDeskname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.ctxtnenuTabDanhSachBan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotal.ForeColor = System.Drawing.Color.Crimson;
            this.lblTotal.Location = new System.Drawing.Point(501, 304);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 25);
            this.lblTotal.TabIndex = 50;
            this.lblTotal.Text = "đ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(501, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tổng tiền thanh toán:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "bida.png");
            this.imageList.Images.SetKeyName(1, "bida-s.png");
            this.imageList.Images.SetKeyName(2, "bidafrace.png");
            this.imageList.Images.SetKeyName(3, "bidafrance-s.png");
            this.imageList.Images.SetKeyName(4, "piza-s.png");
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDetail.Location = new System.Drawing.Point(674, 519);
            this.btnEditDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(160, 40);
            this.btnEditDetail.TabIndex = 110;
            this.btnEditDetail.Text = "Cập nhật";
            this.btnEditDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditDetail.UseVisualStyleBackColor = true;
            this.btnEditDetail.Click += new System.EventHandler(this.btnEditDetail_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(670, 344);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 25);
            this.label13.TabIndex = 109;
            this.label13.Text = "Đơn vị :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvMenus
            // 
            this.dgvMenus.AllowUserToAddRows = false;
            this.dgvMenus.AllowUserToDeleteRows = false;
            this.dgvMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuId,
            this.MenuName,
            this.MenuUnit,
            this.MenuPrice,
            this.MenuDescription});
            this.dgvMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvMenus.Location = new System.Drawing.Point(0, 0);
            this.dgvMenus.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMenus.Name = "dgvMenus";
            this.dgvMenus.ReadOnly = true;
            this.dgvMenus.RowHeadersWidth = 51;
            this.dgvMenus.Size = new System.Drawing.Size(496, 333);
            this.dgvMenus.TabIndex = 107;
            this.dgvMenus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenus_CellContentClick);
            this.dgvMenus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenus_CellContentClick);
            this.dgvMenus.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenus_CellContentClick);
            this.dgvMenus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenus_CellContentClick);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(762, 463);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 25);
            this.label12.TabIndex = 106;
            this.label12.Text = "Tổng :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(672, 403);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 25);
            this.label11.TabIndex = 104;
            this.label11.Text = "Số lượng :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 403);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 102;
            this.label10.Text = "Giá bán :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(502, 344);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 25);
            this.label9.TabIndex = 100;
            this.label9.Text = "Tên :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDetailid
            // 
            this.txtDetailid.Enabled = false;
            this.txtDetailid.Location = new System.Drawing.Point(125, 23);
            this.txtDetailid.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetailid.Name = "txtDetailid";
            this.txtDetailid.ReadOnly = true;
            this.txtDetailid.Size = new System.Drawing.Size(39, 22);
            this.txtDetailid.TabIndex = 99;
            this.txtDetailid.TabStop = false;
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDetail.Location = new System.Drawing.Point(507, 519);
            this.btnAddDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(160, 90);
            this.btnAddDetail.TabIndex = 54;
            this.btnAddDetail.Text = "Thêm";
            this.btnAddDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetails.ColumnHeadersHeight = 29;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.did,
            this.dname,
            this.dprice,
            this.dunit,
            this.dquantum,
            this.dtotal});
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.Size = new System.Drawing.Size(408, 136);
            this.dgvDetails.TabIndex = 40;
            this.dgvDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellContentClick);
            this.dgvDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellContentClick);
            this.dgvDetails.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellContentClick);
            this.dgvDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellContentClick);
            // 
            // did
            // 
            this.did.DataPropertyName = "id";
            this.did.HeaderText = "Mã";
            this.did.MinimumWidth = 6;
            this.did.Name = "did";
            this.did.ReadOnly = true;
            // 
            // dname
            // 
            this.dname.DataPropertyName = "name";
            this.dname.HeaderText = "Tên";
            this.dname.MinimumWidth = 6;
            this.dname.Name = "dname";
            this.dname.ReadOnly = true;
            // 
            // dprice
            // 
            this.dprice.DataPropertyName = "price";
            this.dprice.HeaderText = "Giá";
            this.dprice.MinimumWidth = 6;
            this.dprice.Name = "dprice";
            this.dprice.ReadOnly = true;
            // 
            // dunit
            // 
            this.dunit.DataPropertyName = "unit";
            this.dunit.HeaderText = "Đ.vị";
            this.dunit.MinimumWidth = 6;
            this.dunit.Name = "dunit";
            this.dunit.ReadOnly = true;
            // 
            // dquantum
            // 
            this.dquantum.DataPropertyName = "quantum";
            this.dquantum.HeaderText = "S.lượng";
            this.dquantum.MinimumWidth = 6;
            this.dquantum.Name = "dquantum";
            this.dquantum.ReadOnly = true;
            // 
            // dtotal
            // 
            this.dtotal.DataPropertyName = "total";
            this.dtotal.HeaderText = "Tổng";
            this.dtotal.MinimumWidth = 6;
            this.dtotal.Name = "dtotal";
            this.dtotal.ReadOnly = true;
            // 
            // lvDesk
            // 
            this.lvDesk.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lvDesk.ContextMenuStrip = this.ctxtnenuTabDanhSachBan;
            this.lvDesk.HideSelection = false;
            this.lvDesk.LargeImageList = this.imageList;
            this.lvDesk.Location = new System.Drawing.Point(4, 4);
            this.lvDesk.Margin = new System.Windows.Forms.Padding(4);
            this.lvDesk.Name = "lvDesk";
            this.lvDesk.Size = new System.Drawing.Size(1246, 200);
            this.lvDesk.TabIndex = 47;
            this.lvDesk.UseCompatibleStateImageBehavior = false;
            this.lvDesk.SelectedIndexChanged += new System.EventHandler(this.lvBillard_SelectedIndexChanged);
            this.lvDesk.Click += new System.EventHandler(this.lvBillard_Click);
            // 
            // ctxtnenuTabDanhSachBan
            // 
            this.ctxtnenuTabDanhSachBan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtnenuTabDanhSachBan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem,
            this.hiểnThịBànCóNgườiToolStripMenuItem,
            this.hiểnThịBànĐangBảoTrìToolStripMenuItem,
            this.hiểnThịTấtCảBànToolStripMenuItem});
            this.ctxtnenuTabDanhSachBan.Name = "ctxtnenuTabDanhSachBan";
            this.ctxtnenuTabDanhSachBan.Size = new System.Drawing.Size(259, 100);
            // 
            // hiểnThịBànChưaCóNgườiToolStripMenuItem
            // 
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem.Name = "hiểnThịBànChưaCóNgườiToolStripMenuItem";
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem.Text = "Hiển thị bàn chưa có người";
            this.hiểnThịBànChưaCóNgườiToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịBànChưaCóNgườiToolStripMenuItem_Click);
            // 
            // hiểnThịBànCóNgườiToolStripMenuItem
            // 
            this.hiểnThịBànCóNgườiToolStripMenuItem.Name = "hiểnThịBànCóNgườiToolStripMenuItem";
            this.hiểnThịBànCóNgườiToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.hiểnThịBànCóNgườiToolStripMenuItem.Text = "Hiển thị bàn có người";
            this.hiểnThịBànCóNgườiToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịBànCóNgườiToolStripMenuItem_Click);
            // 
            // hiểnThịBànĐangBảoTrìToolStripMenuItem
            // 
            this.hiểnThịBànĐangBảoTrìToolStripMenuItem.Name = "hiểnThịBànĐangBảoTrìToolStripMenuItem";
            this.hiểnThịBànĐangBảoTrìToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.hiểnThịBànĐangBảoTrìToolStripMenuItem.Text = "Hiển thị bàn đang bảo trì";
            this.hiểnThịBànĐangBảoTrìToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịBànĐangBảoTrìToolStripMenuItem_Click);
            // 
            // hiểnThịTấtCảBànToolStripMenuItem
            // 
            this.hiểnThịTấtCảBànToolStripMenuItem.Name = "hiểnThịTấtCảBànToolStripMenuItem";
            this.hiểnThịTấtCảBànToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.hiểnThịTấtCảBànToolStripMenuItem.Text = "Hiển thị tất cả bàn";
            this.hiểnThịTấtCảBànToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịTấtCảBànToolStripMenuItem_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1090, 212);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(160, 60);
            this.btnPrint.TabIndex = 50;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.ImageKey = "catering (1).png";
            this.btnStart.Location = new System.Drawing.Point(4, 212);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 60);
            this.btnStart.TabIndex = 51;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinish.ImageKey = "21216-200.png";
            this.btnFinish.Location = new System.Drawing.Point(922, 212);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(160, 60);
            this.btnFinish.TabIndex = 52;
            this.btnFinish.Text = "Tính tiền";
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtDeskid
            // 
            this.txtDeskid.Enabled = false;
            this.txtDeskid.Location = new System.Drawing.Point(14, 23);
            this.txtDeskid.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeskid.Name = "txtDeskid";
            this.txtDeskid.ReadOnly = true;
            this.txtDeskid.Size = new System.Drawing.Size(52, 22);
            this.txtDeskid.TabIndex = 95;
            this.txtDeskid.TabStop = false;
            // 
            // txtReceiptionid
            // 
            this.txtReceiptionid.Enabled = false;
            this.txtReceiptionid.Location = new System.Drawing.Point(74, 23);
            this.txtReceiptionid.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceiptionid.Name = "txtReceiptionid";
            this.txtReceiptionid.ReadOnly = true;
            this.txtReceiptionid.Size = new System.Drawing.Size(43, 22);
            this.txtReceiptionid.TabIndex = 97;
            this.txtReceiptionid.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 98;
            this.label4.Text = "Giờ bắt đầu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 100;
            this.label5.Text = "Thời gian chơi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 102;
            this.label7.Text = "Tiền giờ :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dgvMenus);
            this.panel1.Location = new System.Drawing.Point(5, 278);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 333);
            this.panel1.TabIndex = 111;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dgvDetails);
            this.panel2.Controls.Add(this.txtDetailid);
            this.panel2.Controls.Add(this.txtReceiptionid);
            this.panel2.Controls.Add(this.txtDeskid);
            this.panel2.Location = new System.Drawing.Point(842, 475);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 136);
            this.panel2.TabIndex = 113;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbFee);
            this.panel3.Controls.Add(this.lbDeskfee);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lbTotalminute);
            this.panel3.Controls.Add(this.lbTimebegin);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(842, 278);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 169);
            this.panel3.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(10, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 123;
            this.label3.Text = "Thành tiền :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFee
            // 
            this.lbFee.AutoSize = true;
            this.lbFee.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFee.ForeColor = System.Drawing.Color.LightCoral;
            this.lbFee.Location = new System.Drawing.Point(173, 132);
            this.lbFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFee.Name = "lbFee";
            this.lbFee.Size = new System.Drawing.Size(22, 24);
            this.lbFee.TabIndex = 118;
            this.lbFee.Text = "đ";
            // 
            // lbDeskfee
            // 
            this.lbDeskfee.AutoSize = true;
            this.lbDeskfee.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeskfee.Location = new System.Drawing.Point(173, 17);
            this.lbDeskfee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDeskfee.Name = "lbDeskfee";
            this.lbDeskfee.Size = new System.Drawing.Size(22, 24);
            this.lbDeskfee.TabIndex = 117;
            this.lbDeskfee.Text = "đ";
            // 
            // lbTotalminute
            // 
            this.lbTotalminute.AutoSize = true;
            this.lbTotalminute.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalminute.Location = new System.Drawing.Point(173, 93);
            this.lbTotalminute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalminute.Name = "lbTotalminute";
            this.lbTotalminute.Size = new System.Drawing.Size(53, 24);
            this.lbTotalminute.TabIndex = 116;
            this.lbTotalminute.Text = "phút";
            // 
            // lbTimebegin
            // 
            this.lbTimebegin.AutoSize = true;
            this.lbTimebegin.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimebegin.Location = new System.Drawing.Point(173, 53);
            this.lbTimebegin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimebegin.Name = "lbTimebegin";
            this.lbTimebegin.Size = new System.Drawing.Size(41, 24);
            this.lbTimebegin.TabIndex = 115;
            this.lbTimebegin.Text = "giờ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(852, 449);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 122;
            this.label6.Text = "Phụ thu :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSumdetail
            // 
            this.lbSumdetail.AutoSize = true;
            this.lbSumdetail.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumdetail.ForeColor = System.Drawing.Color.LightCoral;
            this.lbSumdetail.Location = new System.Drawing.Point(1015, 449);
            this.lbSumdetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSumdetail.Name = "lbSumdetail";
            this.lbSumdetail.Size = new System.Drawing.Size(22, 24);
            this.lbSumdetail.TabIndex = 121;
            this.lbSumdetail.Text = "đ";
            // 
            // btnDelDetail
            // 
            this.btnDelDetail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelDetail.Location = new System.Drawing.Point(674, 567);
            this.btnDelDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(160, 40);
            this.btnDelDetail.TabIndex = 115;
            this.btnDelDetail.Text = "Xóa";
            this.btnDelDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelDetail.UseVisualStyleBackColor = true;
            this.btnDelDetail.Click += new System.EventHandler(this.btnDelDetail_Click);
            // 
            // txtDetailName
            // 
            this.txtDetailName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetailName.Location = new System.Drawing.Point(507, 371);
            this.txtDetailName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailName.Name = "txtDetailName";
            this.txtDetailName.Size = new System.Drawing.Size(160, 26);
            this.txtDetailName.TabIndex = 116;
            // 
            // txtDetailUnit
            // 
            this.txtDetailUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetailUnit.Location = new System.Drawing.Point(675, 371);
            this.txtDetailUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailUnit.Name = "txtDetailUnit";
            this.txtDetailUnit.Size = new System.Drawing.Size(162, 26);
            this.txtDetailUnit.TabIndex = 117;
            // 
            // txtDetailPrice
            // 
            this.txtDetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetailPrice.Location = new System.Drawing.Point(508, 430);
            this.txtDetailPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailPrice.Name = "txtDetailPrice";
            this.txtDetailPrice.Size = new System.Drawing.Size(160, 26);
            this.txtDetailPrice.TabIndex = 118;
            this.txtDetailPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDetailPrice.TextChanged += new System.EventHandler(this.txtDetailPrice_TextChanged);
            this.txtDetailPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDetailPrice_KeyPress);
            // 
            // txtDetailQuantum
            // 
            this.txtDetailQuantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetailQuantum.Location = new System.Drawing.Point(676, 430);
            this.txtDetailQuantum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailQuantum.Name = "txtDetailQuantum";
            this.txtDetailQuantum.Size = new System.Drawing.Size(160, 26);
            this.txtDetailQuantum.TabIndex = 119;
            this.txtDetailQuantum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDetailQuantum.TextChanged += new System.EventHandler(this.txtDetailQuantum_TextChanged);
            this.txtDetailQuantum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDetailQuantum_KeyPress);
            // 
            // txtDetailTotal
            // 
            this.txtDetailTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetailTotal.ForeColor = System.Drawing.Color.Firebrick;
            this.txtDetailTotal.Location = new System.Drawing.Point(508, 490);
            this.txtDetailTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailTotal.Name = "txtDetailTotal";
            this.txtDetailTotal.ReadOnly = true;
            this.txtDetailTotal.Size = new System.Drawing.Size(328, 26);
            this.txtDetailTotal.TabIndex = 120;
            this.txtDetailTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDestroy
            // 
            this.btnDestroy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestroy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDestroy.ImageKey = "catering (1).png";
            this.btnDestroy.Location = new System.Drawing.Point(172, 212);
            this.btnDestroy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(160, 60);
            this.btnDestroy.TabIndex = 123;
            this.btnDestroy.Text = "Hủy bỏ";
            this.btnDestroy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.ImageKey = "21216-200.png";
            this.btnTransfer.Location = new System.Drawing.Point(340, 212);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(160, 60);
            this.btnTransfer.TabIndex = 124;
            this.btnTransfer.Text = "Chuyển bàn";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtDeskname
            // 
            this.txtDeskname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDeskname.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeskname.ForeColor = System.Drawing.Color.Black;
            this.txtDeskname.Location = new System.Drawing.Point(506, 214);
            this.txtDeskname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeskname.Multiline = true;
            this.txtDeskname.Name = "txtDeskname";
            this.txtDeskname.ReadOnly = true;
            this.txtDeskname.Size = new System.Drawing.Size(408, 58);
            this.txtDeskname.TabIndex = 126;
            this.txtDeskname.Text = "Bàn Số";
            this.txtDeskname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uctBilliards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtDeskname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbSumdetail);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.txtDetailTotal);
            this.Controls.Add(this.txtDetailQuantum);
            this.Controls.Add(this.txtDetailPrice);
            this.Controls.Add(this.txtDetailUnit);
            this.Controls.Add(this.txtDetailName);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDelDetail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEditDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvDesk);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnFinish);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uctBilliards";
            this.Size = new System.Drawing.Size(1254, 613);
            this.Load += new System.EventHandler(this.uctPlayZone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ctxtnenuTabDanhSachBan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView lvDesk;
        private System.Windows.Forms.ContextMenuStrip ctxtnenuTabDanhSachBan;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịBànChưaCóNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịBànCóNgườiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịTấtCảBànToolStripMenuItem;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtDeskid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReceiptionid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịBànĐangBảoTrìToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDetailid;
        private System.Windows.Forms.DataGridView dgvMenus;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuDescription;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEditDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbFee;
        private System.Windows.Forms.Label lbDeskfee;
        private System.Windows.Forms.Label lbTotalminute;
        private System.Windows.Forms.Label lbTimebegin;
        private System.Windows.Forms.Button btnDelDetail;
        private System.Windows.Forms.TextBox txtDetailName;
        private System.Windows.Forms.TextBox txtDetailUnit;
        private System.Windows.Forms.TextBox txtDetailPrice;
        private System.Windows.Forms.TextBox txtDetailQuantum;
        private System.Windows.Forms.TextBox txtDetailTotal;
        private System.Windows.Forms.Label lbSumdetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtDeskname;
        private System.Windows.Forms.DataGridViewTextBoxColumn did;
        private System.Windows.Forms.DataGridViewTextBoxColumn dname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dquantum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtotal;
    }
}
