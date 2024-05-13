using System.Data;
using SoftQuanLyNhaHang.Models;

namespace SoftQuanLyNhaHang.Controllers
{
    class DeskCtrl
    {
        public static long generalid()
        {
            DeskMod Desk = new DeskMod();
            return Desk.generalid();
        }
        // Method Add
        public static int insert(long id, string name, int style, string description, int status, float fee)
        {
            DeskMod Desk = new DeskMod(id, name, style, description, status, fee);
            return Desk.insert();
        }
        // Method Update
        public static int update(long id, string name, int style, string description, int status, float fee)
        {
            DeskMod Desk = new DeskMod(id, name, style, description, status, fee);
            return Desk.update();
        }
        // Method Delete
        public static int delete(long id)
        {
            DeskMod Desk = new DeskMod(id);
            return Desk.delete();
        }

        // Method find view
        public static DataSet findView()
        {
            DeskMod Desk = new DeskMod();
            return Desk.findView();
        }
        public static DataSet findAll()
        {
            DeskMod Desk = new DeskMod();
            return Desk.findAll();
        }
        public static DataSet findByStatus(int status)
        {
           DeskMod Desk = new DeskMod();
           return Desk.findByStatus(status);
        }
        public static int updateStatus(long id, int status)
        {
            DeskMod Desk = new DeskMod();
            return Desk.updateStatus(id, status);
        }
        public static DataSet findById(long id)
        {
            DeskMod Desk = new DeskMod();
            return Desk.findById(id);
        }
    }
}
