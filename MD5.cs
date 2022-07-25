using System.Text;
using System.Security.Cryptography;

namespace TechnicalService
{
    class MD5
    {
        public static string MD5Hashing(string pswd)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] pwd = Encoding.UTF8.GetBytes(pswd);
            pwd = md5.ComputeHash(pwd);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte i in pwd)
            {
                stringBuilder.Append(i.ToString("x2").ToLower());
            }
            return stringBuilder.ToString();
        }

        public static string MD5Hash(string md5p)
        {
            md5p = MD5Hashing(md5p);
            md5p = "yTb&" + md5p.Substring(0, 14) + "R6&2";
            md5p = MD5Hashing(md5p);
            md5p = "heJ*" + md5p.Substring(7, 21) + "jTg?";
            md5p = MD5Hashing(md5p);
            md5p = "byt#" + md5p + "lsY>";
            md5p = MD5Hashing(md5p);
            return md5p;
        }
    }
}
