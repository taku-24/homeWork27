namespace ex3;

public class Program
{
    public static void Main()
    {
        Stack<string> stack = new Stack<string>();
        
        stack.Push("Bob");
        stack.Push("Alice");
        stack.Push("Sam");
        stack.Push("Kate");
        
        stack.ShowData();
        
        stack.Push("Tom");
        stack.ShowData();
        
        Console.WriteLine("\nПоследний извлечённый элемент: " + stack.Pop());
        
        stack.ShowData();
    }
}