using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SoftQuanLyNhaHang.Views
{
    public partial class frmTransferDesk : Form
    {
        public DialogResult dr { get; set; }
        string deskname = "";
        string deskid = "";
        string deskfee = "";
        string timebegin = "";
        string totalminute = "";
        string fee = "";
        string receiptionid = "";

        public frmTransferDesk(string deskname, string deskid, string deskfee, string timebegin, string totalminute, string fee, string receiptionid)
        {
            this.deskname = deskname;
            this.deskid = deskid;
            this.deskfee = deskfee;
            this.timebegin = timebegin;
            this.totalminute = totalminute;
            this.fee = fee;
            this.receiptionid = receiptionid;
            InitializeComponent();
        }

        private void frmTransferDesk_Load(object sender, EventArgs e)
        {
            lbDeskname.Text = deskname;
            lbDeskfee.Text = deskfee;
            lbTimebegin.Text = timebegin;
            lbTotalminute.Text = totalminute;
            lbFee.Text = fee;
            loadDeskReady();
        }
        private void loadDeskReady()
        {
            DataTable dtable = Controllers.DeskCtrl.findByStatus(Models.constant.status_ready).Tables[0];
            if (dtable.Rows.Count == 0)
            {
                cmbDesk.Text = "Không có bàn!";
                btnOk.Enabled = false;
            }
            else
            {
                List<Models.cmbSelection> lstDesk = new List<Models.cmbSelection>();
                for (int i=0; i< dtable.Rows.Count; i++)
                    lstDesk.Add(new Models.cmbSelection(long.Parse(dtable.Rows[i]["id"].ToString()), dtable.Rows[i]["name"].ToString()));

                cmbDesk.DataSource = lstDesk;
                cmbDesk.DisplayMember = "name";
                cmbDesk.ValueMember = "lid";
            }
        }
        private int transferDesk()
        {
            long idfrom = long.Parse(deskid);
            Models.cmbSelection to = cmbDesk.SelectedItem as Models.cmbSelection;
            long idto = to.lid;
            DataTable dtable = Controllers.DeskCtrl.findById(idto).Tables[0];
            if (dtable.Rows.Count > 0)
            {
                Controllers.DeskCtrl.updateStatus(idfrom, Models.constant.status_ready);
                Controllers.DeskCtrl.updateStatus(idto, Models.constant.status_busy);
                string timebegin = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                int result = Controllers.ReceiptionCtrl.updateTransfer(long.Parse(receiptionid), idto, dtable.Rows[0]["name"].ToString(), float.Parse(dtable.Rows[0]["fee"].ToString()), timebegin);
                if (result > 0)
                {
                    long detailid = Controllers.ReceiptiondetailCtrl.generalid();
                    if (detailid > 0)
                    {
                        int quantum = int.Parse(totalminute.Replace("phút", "").Replace(" ", ""));
                        float total = float.Parse(fee.Replace(",", "").Replace("đ", "").Replace(" ", ""));
                        Controllers.ReceiptiondetailCtrl.insert(detailid, long.Parse(receiptionid), deskname + " chuyển qua", "Phút", 0, quantum, total);
                    }
                }
                MessageBox.Show("Chuyển bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return 1;
            }
            else
            {
                MessageBox.Show("Chuyển bàn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return 0;
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.dr = DialogResult.No;
            this.Close();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult ok = new DialogResult();
            ok = MessageBox.Show("Bạn có chắc muốn chuyển bàn Không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.Yes && receiptionid!="")
            {
                int trs = transferDesk();
                if (trs > 0)
                {
                    this.dr = DialogResult.OK;
                    this.Close();
                }                
            }
            else
            {
                return;
            }
        }
    }
}
