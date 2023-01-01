using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Maraton_Taha_Kayapinar_HS6.Helper
{
    public class UIHelper
    {
        public const string appName = "ALBUM";
        public static DialogResult ErrorMessage(string message)
        {
            return MessageBox.Show(message, appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        public static string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }


    }
}
