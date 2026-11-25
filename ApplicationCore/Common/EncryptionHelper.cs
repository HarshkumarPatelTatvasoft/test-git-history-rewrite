namespace ApplicationCore.Common
{
    public static class EncryptionHelper
    {
        private static string secretKey = "***REMOVED***";
        // IsPasswordChanged flag
        public static string Encrypt(string plain) => plain; // dummy
        public static string Decrypt(string cipher) => cipher; // dummy
    }
}
