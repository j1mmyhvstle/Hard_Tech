using System.Data;
using System.Text;
using System.Security.Cryptography;

namespace SoftQuanLyNhaHang.Models
{
    class UserLoginMod
    {
        protected string username { get; set; } //100
        protected string password { get; set; } //250
        protected string screenname { get; set; }   //250
        protected int status { get; set; }  //int

        public UserLoginMod()
        {
        }
        public UserLoginMod(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string encodeSHA256(string password)
        {
            SHA256Managed crypt = new SHA256Managed();
            string hash = "";
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte bit in crypto)
            {
                hash += bit.ToString("x2");
            }
            return hash;
        }
        public string checkLogin()
        {
            string[] paras = new string[2] { "@username", "@password" };
            object[] values = new object[2] { username, password };
            return connection.ExcuteScalar(constant.check_Userlogin, CommandType.StoredProcedure, paras, values);
        }
        public int updateLogin()
        {
            string[] paras = new string[2] { "@username", "@password" };
            object[] values = new object[2] { username, password };
            return connection.Excute_Sql(constant.update_Userlogin, CommandType.StoredProcedure, paras, values);
        }
    }
}
