namespace ex3;

public class Stack<T> : IDataVisualizer<T>
{
    private List<T> _items = new List<T>();
    
    public void Push(T element)
    {
        _items.Add(element);
    }
    
    public T Pop()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("Стек пуст — невозможно вызвать Pop().");
        }
        
        T result = _items[_items.Count - 1];
        _items.RemoveAt(_items.Count - 1);
        return result;
    }
    
    public void ShowData()
    {
        Console.WriteLine("\nТекущее состояние стека:");
        
        for (int i = _items.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(_items[i]);
        }
    }
}