namespace ConsoleApp16;

class Program
{
    static void Main(string[] args)
    {
        int[] intArray = { 5, 3, 1, 9, 7 };
        string[] stringArray = { "яблоко", "груша", "банан", "арбуз", "дыня" };
        
        GenericArrayHelper<int>.SortArray(intArray);
        Console.WriteLine("Отсортированный массив:");
        Console.WriteLine(string.Join(", ", intArray));
        
        GenericArrayHelper<int>.ReverseArray(intArray);
        Console.WriteLine("Развёрнутый массив:");
        Console.WriteLine(string.Join(", ", intArray));
        
        
        
        GenericArrayHelper<string>.SortArray(stringArray);
        Console.WriteLine("Отсортированный массив:");
        Console.WriteLine(string.Join(", ", stringArray));
        
        GenericArrayHelper<string>.ReverseArray(stringArray);
        Console.WriteLine("Развёрнутый массив:");
        Console.WriteLine(string.Join(", ", stringArray));
        
    }
}