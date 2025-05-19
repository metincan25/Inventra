using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DepoProjem
{
    class HashHelper
    {
        public static class HashHelperr
        {
            public static string ComputeSha256Hash(string rawData)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                        builder.Append(b.ToString("x2")); // Hex format
                    return builder.ToString();
                }
            }
        }
    }
}
