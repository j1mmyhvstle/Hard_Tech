namespace SoftQuanLyNhaHang.Controllers
{
    class UserLoginCtrl
    {
        public static string encodePassword(string _password)
        {
            Models.UserLoginMod login = new Models.UserLoginMod();
            return login.encodeSHA256(_password);
        }
        public static string checkUserlogin(string _user, string _password)
        {
            Models.UserLoginMod login = new Models.UserLoginMod(_user, _password);
            return login.checkLogin();
        }
        public static int updateUserlogin(string _user, string _password)
        {
            Models.UserLoginMod login = new Models.UserLoginMod(_user, _password);
            return login.updateLogin();
        }
    }
}
