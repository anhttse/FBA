using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace FBA.Extension
{
    public static class Utilities
    {
        public static string ToSHA(this string scr)
        {
            using (var sha = SHA256.Create())
            {
                var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(scr));
                return Convert.ToBase64String(hash).ToLowerInvariant();

            }
        }

        public static string SaltGenerate(int size)
        {
            var rngc = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rngc.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
    }
}