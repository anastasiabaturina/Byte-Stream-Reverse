namespace ByteStreamReverse;

public class Program()
{
    public static void Main()
    {
        int[] array = { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 };

        Console.WriteLine($"{string.Join(string.Empty, array)}");

        var finalArray = ByteConverter.Reverse(array);

        foreach (var chunk in finalArray)
        {
            Console.Write(string.Join("", chunk));
        }
    }
}