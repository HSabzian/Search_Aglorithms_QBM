using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
        
        Console.WriteLine("Original array:");
        PrintArray(numbers);

        BubbleSort(numbers);

        Console.WriteLine("Sorted array:");
        PrintArray(numbers);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            // Track if a swap occurred
            bool swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                // Swap if the element found is greater than the next element
                if (arr[j] > arr[j + 1])
                {
                    Swap(ref arr[j], ref arr[j + 1]);
                    swapped = true;
                }
            }

            // If no swaps occurred, the array is sorted
            if (!swapped)
                break;
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

