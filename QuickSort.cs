using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 38, 27, 43, 3, 9, 82, 10 , 12 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        QuickSort(numbers, 0, numbers.Length - 1);

        Console.WriteLine("Sorted array:");
        PrintArray(numbers);
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // Partition the array
            int pi = Partition(arr, low, high);

            // Recursively sort elements before and after partition
            QuickSort(arr, low, pi - 1); // Before pi
            QuickSort(arr, pi + 1, high); // After pi
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        // Pivot (Element to be placed at the right position)
        int pivot = arr[high];
        int i = (low - 1); // Index of smaller element

        for (int j = low; j < high; j++)
        {
            // If current element is smaller than or equal to pivot
            if (arr[j] <= pivot)
            {
                i++; // increment index of smaller element
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, high);
        return (i + 1);
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
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
