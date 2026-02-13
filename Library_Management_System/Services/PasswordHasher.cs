using System;
using System.Security.Cryptography;

namespace Library_Management_System.Services
{
    public static class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 100000;
        private const string Prefix = "PBKDF2";

        public static string Hash(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be empty.", nameof(password));

            byte[] salt = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            byte[] hash;
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                hash = pbkdf2.GetBytes(HashSize);
            }

            return $"{Prefix}${Iterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
        }

        public static bool Verify(string password, string storedValue)
        {
            if (string.IsNullOrEmpty(storedValue))
                return false;

            if (!storedValue.StartsWith(Prefix + "$"))
            {
                return string.Equals(password, storedValue, StringComparison.Ordinal);
            }

            string[] parts = storedValue.Split('$');
            if (parts.Length != 4)
                return false;

            if (!int.TryParse(parts[1], out int iterations))
                return false;

            byte[] salt = Convert.FromBase64String(parts[2]);
            byte[] expectedHash = Convert.FromBase64String(parts[3]);

            byte[] actualHash;
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                actualHash = pbkdf2.GetBytes(expectedHash.Length);
            }

            return FixedTimeEquals(actualHash, expectedHash);
        }

        public static bool IsHashed(string storedValue)
        {
            return !string.IsNullOrEmpty(storedValue) && storedValue.StartsWith(Prefix + "$", StringComparison.Ordinal);
        }

        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;

            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }

            return diff == 0;
        }
    }
}
