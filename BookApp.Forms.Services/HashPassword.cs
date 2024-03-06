using System.Security.Cryptography;
using System.Text;

namespace BookApp.Forms.Services
{
	public class HashPassword
	{
		public static string SetPassword(string password)
		{
			byte[] hashedBytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
			return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
		}

		public static bool VerifyPassword(string password, string hashedPassword)
		{
			string providedPasswordHash = SetPassword(password);
			return hashedPassword == providedPasswordHash;
		}
	}
}
