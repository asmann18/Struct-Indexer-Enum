namespace Struct_Nullable_Indexer_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt listInt = new ListInt();
            listInt.Add(1);
            listInt.Add(2);
            listInt.Add(3);
            listInt.AddRange(3, 4, 6);
            listInt.Remove(6);
            listInt.RemoveRange(2, 3, 5);
            Console.WriteLine(listInt[1]);
            listInt[1] = 999;

            Console.WriteLine(listInt);
        }
    }
}