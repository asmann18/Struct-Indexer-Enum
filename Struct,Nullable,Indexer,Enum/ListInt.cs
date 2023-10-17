using System.Text;

namespace Struct_Nullable_Indexer_Enum;

public class ListInt
{
    int[] numbers = new int[0];
    public int this[int i]
    {
        get
        {
            return numbers[i];
        }
        set
        {
            numbers[i] = value;
        }
    }
    public void Add(int num)
    {
        Array.Resize(ref numbers, numbers.Length+1);
        numbers[^1] = num;
    }
    public void AddRange(params int[] nums)
    {
        foreach (int num in nums)
        {
            Add(num);
        }
    }
    public bool Contains(int num)
    {
        foreach (int number in numbers)
        {
            if (number == num)
            {
                return true;
            }
        }
        return false;
    }

    public void Sum()
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"Sum: {sum}");
    }
    public void Remove(int num)
    {
        if (!Contains(num))
        {
            Console.WriteLine($"{num} not found");
            
        }
        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    for(int j = i; j < numbers.Length - 1; j++)
                    {
                        numbers[j] = numbers[j + 1];
                    }
                    Array.Resize(ref numbers, numbers.Length - 1);
                    Console.WriteLine("number is deleted");
                    break;
                }
            }
        }
    }
    public void RemoveRange(params int[] nums)
    {
        foreach (int num in nums)
        {
            Remove(num);
        }
    }
    public override string ToString()
    {
        StringBuilder builder= new StringBuilder();
        foreach (int num in numbers)
        {
            builder.Append(num+",");
        }
        return builder.ToString();
    }
}

