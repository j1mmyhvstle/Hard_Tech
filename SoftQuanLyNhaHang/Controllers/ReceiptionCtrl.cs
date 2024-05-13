using System;
using System.Data;
using System.Windows.Forms;
using SoftQuanLyNhaHang.Models;

namespace SoftQuanLyNhaHang.Controllers
{
    class ReceiptionCtrl
    {
        public static long generalid()
        {
            ReceiptionMod receiption = new ReceiptionMod();
                return receiption.generalid();

        }
        // Method Add
        public static int insert(long id, long deskid, string deskname, float deskfee, string timebegin, int status)
        {
            ReceiptionMod receiption = new ReceiptionMod();
                return receiption.insert(id, deskid, deskname, deskfee, timebegin, status);

        }
        // Method Update time
        public static int updateTimebegin(long id, string timebegin)
        {
            ReceiptionMod receiption = new ReceiptionMod();
                return receiption.updateTimebegin(id, timebegin);

        }
        // Method Update finish
        public static int updatefinish(long id, string timefinish, int totalminute, float fee, float total, int status)
        {
            ReceiptionMod receiption = new ReceiptionMod();
                return receiption.updatefinish(id, timefinish, totalminute, fee, total, status);

        }

        // Method find by findBydeskid
        public static DataSet findBydeskid(long deskid)
        {
            ReceiptionMod receiption = new ReceiptionMod();
                return receiption.findBydeskid(deskid);
        }
        public static int updateTransfer(long id, long deskid, string deskname, float deskfee, string timebegin)
        {
            ReceiptionMod receiption = new ReceiptionMod();
            return receiption.updateTransfer(id, deskid, deskname, deskfee, timebegin);

        }
    }
}
