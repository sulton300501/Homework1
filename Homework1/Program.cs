using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 6, 1, 2, 3 };

        BubbleSort(numbers);
        DisplayResult(1, numbers);

     
        Array.Reverse(numbers);
        DisplayResult(2, numbers);

        
        string[] stringNumbers = Array.ConvertAll(numbers, x => x.ToString());
        BubbleSort(stringNumbers, String.Compare);
        DisplayResult(3, stringNumbers);
    }

  
    static void BubbleSort<T>(T[] array, Comparison<T> comparison = null)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (comparison == null ? Comparer<T>.Default.Compare(array[j], array[j + 1]) > 0 : comparison(array[j], array[j + 1]) > 0)
                {
                   
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    
    static void DisplayResult<T>(int order, T[] result)
    {
        Console.WriteLine($"{order} {"{" + string.Join(",", result)}");
    }
}
