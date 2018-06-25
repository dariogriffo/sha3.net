using System.Text;

namespace SHA3.Net.Tests
{
    public static class Utils
    {
        public static string ToHexString(this byte[] bytes)
        {
            var hex = new StringBuilder(bytes.Length * 2);
            foreach (var b in bytes)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }        
    }
}
