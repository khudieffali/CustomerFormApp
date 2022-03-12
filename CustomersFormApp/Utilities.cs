using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CustomersFormApp
{
   public static class Utilities
    {
        public static bool IsEmpty(string[] arr)
        {
            foreach (var ar in arr) 
            {
                if (string.IsNullOrWhiteSpace(ar))
                {
                    return false;
                }
            }
            return true;

        }
        public static string Hashed(this string pas)
        {
            byte[] newByte = new UTF8Encoding().GetBytes(pas);
            var HashedMe = new SHA256Managed().ComputeHash(newByte);
            string Password = new UTF8Encoding().GetString(HashedMe);
            return Password;
        }
        
    }
}
