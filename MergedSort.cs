using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 38, 27, 43, 3, 9, 82, 10, 14, 17, 10, 11, 83 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        MergeSort(numbers, 0, numbers.Length - 1);

        Console.WriteLine("Sorted array:");
        PrintArray(numbers);
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            // Find the middle point
            int middle = left + (right - left) / 2;

            // Recursively sort the first half
            MergeSort(arr, left, middle);

            // Recursively sort the second half
            MergeSort(arr, middle + 1, right);

            // Merge the sorted halves
            Merge(arr, left, middle, right);
        }
    }

    static void Merge(int[] arr, int left, int middle, int right)
    {
        // Find sizes of two subarrays to be merged
        int n1 = middle - left + 1;
        int n2 = right - middle;

        // Create temporary arrays
        int[] L = new int[n1];
        int[] R = new int[n2];

        // Copy data to temporary arrays
        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            R[j] = arr[middle + 1 + j];

        // Merge the temporary arrays

        // Initial indexes of first and second subarrays
        int k = left;
        int i = 0; // Initial index of first subarray
        int j = 0; // Initial index of second subarray

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements of L[] if any
        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        // Copy remaining elements of R[] if any
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
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
