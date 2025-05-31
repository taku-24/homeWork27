
public class GenericArrayHelper<T> where T : IComparable<T>
{
    public static void SortArray(T[] array)
    {
        if (array == null || array.Length < 2)
            return;
        
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    public static void ReverseArray(T[] array)
    {
        if (array == null || array.Length < 2)
            return;

        int left = 0;
        int right = array.Length - 1;
        while (left < right)
        {
            T temp = array[left];
            array[left] = array[right];
            array[right] = temp;
            left++;
            right--;
        }
    }
}

