using System;
using System.Security.Cryptography;
using System.Text;

namespace csharp_assmnt_mono
{
	public class Security
	{
		public static string hash(string input){
			MD5 md5 = MD5.Create ();
			byte[] hashData = md5.ComputeHash (Encoding.Default.GetBytes (input));
			return Convert.ToBase64String (hashData);
		}
	}
}

