using System.Data;
using SoftQuanLyNhaHang.Models;

namespace SoftQuanLyNhaHang.Controllers
{
    class MenuCtrl
    {
        public static long generalid()
        {
            MenuMod menu = new MenuMod();
            return menu.generalid();
        }
        // Method Add
        public static int insert(long id, string name, string unit, float price, string description)
        {
            MenuMod menu = new MenuMod(id, name, unit, price, description);
                return menu.insert();
        }
        // Method Update
        public static int update(long id, string name, string unit, float price, string description)
        {
            MenuMod menu = new MenuMod(id, name, unit, price, description);
                return menu.update();
        }
        // Method Delete
        public static int delete(long id)
        {
            MenuMod menu = new MenuMod(id);
                return menu.delete();
        }
        public static DataSet findView()
        {
            MenuMod menu = new MenuMod();
            return menu.findView();
        }
    }
}
