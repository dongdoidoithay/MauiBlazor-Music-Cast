
using System.Security.Cryptography;
using System.Text;
namespace MusicCast.Shared.Utils;

public static class CommonUtils
{
    public static string StringToMD5(string data)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(data);

            // mã hóa input bytes thành MD5 hash 
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Chuyển hash thành chuỗi hex 
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
