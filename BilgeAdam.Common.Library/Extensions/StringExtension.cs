﻿using System.Security.Cryptography;
using System.Text;

namespace BilgeAdam.Common.Library.Extensions
{
    public static class StringExtension
    {
        public static string ComputeHash(this string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}