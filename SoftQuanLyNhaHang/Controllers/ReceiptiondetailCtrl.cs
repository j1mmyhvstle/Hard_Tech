using System.Data;
using SoftQuanLyNhaHang.Models;

namespace SoftQuanLyNhaHang.Controllers
{
    class ReceiptiondetailCtrl
    {
        public static long generalid()
        {
            ReceiptiondetailMod Receiptiondetail = new ReceiptiondetailMod();
                return Receiptiondetail.generalid();

        }

        // Method Add
        public static int insert(long id, long receiptionid, string name, string unit, float price, int quantum, float total)
        {
            ReceiptiondetailMod Receiptiondetail = new ReceiptiondetailMod(id, receiptionid, name, unit, price, quantum, total);
                return Receiptiondetail.insert();

        }
        // Method Update
        public static int update(long id, string name, string unit, float price, int quantum, float total)
        {
            ReceiptiondetailMod Receiptiondetail = new ReceiptiondetailMod();
                return Receiptiondetail.update(id, name, unit, price, quantum, total);

        }
        // Method Delete
        public static int delete(long id)
        {
            ReceiptiondetailMod Receiptiondetail = new ReceiptiondetailMod(id);
                return Receiptiondetail.delete();

        }
        // Method find by styleid
        public static DataSet findByreceiptionid(long receiptionid)
        {
            ReceiptiondetailMod Receiptiondetail = new ReceiptiondetailMod();
                return Receiptiondetail.findByreceiptionid(receiptionid);

        }

    }
}
