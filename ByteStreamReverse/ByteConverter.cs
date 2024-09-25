namespace ByteStreamReverse;

public class ByteConverter
{
    public static IEnumerable<int[]> Reverse(int[] bytes)
    {
        var result = bytes.Chunk(8).Reverse();

        return result;
    }
}