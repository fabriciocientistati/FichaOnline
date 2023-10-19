using System.Security.Cryptography;
using System.Text;

namespace FichaOnline.Helper
{
    public static class SenhaHasher
    {
        public static string GerarHash(this string senha)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));

            var senhaHash = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                senhaHash.Append(bytes[i].ToString("x2"));
            }
            return senhaHash.ToString();
        }
    }
}
