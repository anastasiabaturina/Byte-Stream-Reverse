using System.Text;

namespace ByteStreamReverse;

public class ByteConverter
{
    public static string Reverse(int[] bytes)
    {
        var result = new StringBuilder();

        for (int i = bytes.Length - 8; i >= 0; i -= 8)
        {
            for (int j = 0; j < 8; j++)
            {
                result.Append(bytes[i + j]);
            }
        }

        return result.ToString();
    }
}
