using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Encryption
    {
        public string hash;
        private string salt;
        private string password;

        const string saltPrefix = "salted_";
        const string hashPrefix = "hashed_";

        const string sha1_default = "40bd001563085fc35165329ea1ff5c5ecbdbbeef";
        const string sha256_default = "6dcd4ce23d88e2ee9568ba546c007c63a0b3f1b5f7e9f8c5a1b2f3c4e5d6e7f8";
        const string md5_default = "d41d8cd98f00b204e9800998ecf8427e";

        public Encryption(string password)
        {
            this.password = SHA1Hash(password);
        }

        public override string ToString()
        {
            return password;
        }

        private static string ConvertBytesToHex(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var b in bytes)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        public static string MD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return ConvertBytesToHex(hashBytes);

            }
        }

        public static string SHA1Hash(string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                return ConvertBytesToHex(hashBytes);
            }
        }

        public static string SHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                return ConvertBytesToHex(hashBytes);
            }
        }

        public static string SHA512Hash(string input)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha512.ComputeHash(inputBytes);

                return ConvertBytesToHex(hashBytes);
            }
        }
    }
}
