using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sismio.io.sismio.utente
{
    /// <summary>
    /// Classe utilizzata per fornire i metodi di base per hash SHA256 e random salt
    /// </summary>
    class HashUtil
    {
        private static int DimensioneSalt = 64;

        /// <summary>
        /// Genera l'hash SHA256 della stringa passata come parametro.
        /// </summary>
        /// <param name="str">Stringa di partenza</param>
        /// <returns>L'hash SHA256 della stringa passata come parametro</returns>
        public static string GeneraSHA256(string str)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(str));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        public static string GeneraSalt()
        {
            char[] chars = new char[62];
            chars =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[DimensioneSalt];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(DimensioneSalt);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
    }
}
