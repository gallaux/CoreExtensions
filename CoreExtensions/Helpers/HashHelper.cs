using System;
using System.IO;
using System.Security.Cryptography;

namespace CoreExtensions.Helpers
{
    /// <summary>
    /// Helper class to calculate hashes
    /// </summary>
    public class HashHelper
    {
        /// <summary>
        /// Get file SHA-1 hash (40 chars)
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="filePath"></param>
        /// <returns>Returns null if file path is invalid</returns>
        public static string GetSha1Hash(string filePath)
        {
            string hash = null;
            try
            {
                using (FileStream fs = File.OpenRead(filePath))
                {
                    SHA1 sha = new SHA1Managed();
                    hash = BitConverter.ToString(sha.ComputeHash(fs)).Replace("-", "");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return hash;
        }

        /// <summary>
        /// Get file SHA-1 hash (40 chars)
        /// </summary>
        /// <param name="stream"></param>
        /// <returns>Returns null if stream is invalid</returns>
        public static string GetSha1Hash(Stream stream)
        {
            string hash = null;
            try
            {
                SHA1 sha = new SHA1Managed();
                hash = BitConverter.ToString(sha.ComputeHash(stream)).Replace("-", "");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return hash;
        }
    }
}