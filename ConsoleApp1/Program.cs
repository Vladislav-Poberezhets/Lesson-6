namespace Task1111
{
    class Program
    {

        enum SortAlgorithmType
        {
            bubbleSort,
            insertionSort,
            selectionSort
        }

        enum OrderBy
        {
            Ask,
            Desk
        }
        static void Sort(int[] arrayToSort, SortAlgorithmType type, OrderBy order)
        {
            switch (type)
            {
                case SortAlgorithmType.bubbleSort:
                    if (order == OrderBy.Ask)
                    {
                        bubbleSort(arrayToSort);
                    }


                    break;
                case SortAlgorithmType.insertionSort:
                    insertionSort(arrayToSort);
                    break;
                case SortAlgorithmType.selectionSort:
                    selectionSort(arrayToSort);
                    break;



            }
        }
        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n ; i++)
                for (int j = 0; j < n - 1; j++)
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

        }
        static void insertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;

            }

        }
        static void selectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }

        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Enter the number of array elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i + 1}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }

            bubbleSort(a);
            printArray(a);

        }
    }
}


