namespace ApplicationCore.Common
{
    public static class EncryptionHelper
    {
        private static string secretKey;
        public static void Initialize(string key) => secretKey = key;
        public static string Encrypt(string plain) => plain; // dummy
        public static string Decrypt(string cipher) => cipher; // dummy
    }
}
