using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 12, 12, 5, 7, 4, 47, 8, 54 };
            int left;
            int right;
            bool hasChanged;

            for (int sorted = arr.Length - 1; sorted >= 1; sorted--)
            {
                hasChanged = false;
                for (int i = 0; i < sorted; i++)
                {
                    left = arr[i];
                    right = arr[i + 1];
                    if (left > right)
                    {
                        arr[i + 1] = left;
                        arr[i] = right;
                        hasChanged = true;
                    }
                }

                if (!hasChanged)
                {
                    break;
                }
            }

            if (IsSorted(arr))
            {
                Console.WriteLine("The array is sorted");
            }
            else
            {
                Console.WriteLine(" =============================== ERROR =============================== ");
            }

        }

        private static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] <= arr[i + 1])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
