using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_FİnalProject_
{
    public class Extensions
    {
        public static void Message(string information, bool type = true)
        {
            if (type)
            {
                MessageBox.Show(information, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(information, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        public static string GetHash(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] crypt = new System.Security.Cryptography.SHA256Managed().ComputeHash(bytes);
            string HashedPassword = Encoding.Unicode.GetString(crypt);
            return HashedPassword;
        }
        public static bool ChechkHashPass(string hashedPassword , string Password)
        {
            return GetHash(Password) == hashedPassword;
        }
    }
}
