﻿using System;
using System.Security.Cryptography;

namespace PasswordHashGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var passord = "";

            var hashedPassword = GetPasswordHash(passord);

            Console.WriteLine($"PasswordHash:\n{hashedPassword}");
        }

        private static string GetPasswordHash(string password)
        {
            byte[] salt;
            byte[] buffer2;

            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }
    }
}
