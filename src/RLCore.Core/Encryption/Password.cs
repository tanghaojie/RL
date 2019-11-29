using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RLCore.Encryption
{
    public class Password
    {
        public static string MD5(string password)
        {
            if (string.IsNullOrWhiteSpace(password)) { throw new ArgumentNullException(); }
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                var m = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(m);
            }
        }
    }
}
