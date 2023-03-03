using System.Numerics;
using System.Text;

namespace ConsoleApp1
{

    class Program
    {
        public static int count = 0;
        public static int[] QuickSort(int[] array, int start, int end)
        {
            if(start >= end)
            {
                return array;
            }
            int pivot = Partition(array, start, end);
            QuickSort(array, start, pivot - 1);
            QuickSort(array, pivot + 1, end);
            return array;
        }

        public static int Partition(int[] targetArray, int start, int end)
        {
            count = count + end - start;
            int middleIndex = start + (end - start) / 2;
            int pivotIndex = FindPivotIndex(targetArray, start, end, middleIndex);
            int pivot = targetArray[pivotIndex];
            Console.WriteLine("Pivot: " + pivot);
            int temp = targetArray[start];
            targetArray[start] = pivot;
            targetArray[pivotIndex] = temp;
            int i = start + 1;

            for (int j = start+1; j<end+1; j++)
            {
                if (targetArray[j] < pivot)
                {
                   
                        int temp2 = targetArray[j];
                        targetArray[j] = targetArray[i];
                        targetArray[i] = temp2;
                    i++;
                       
                }
                
            }
            targetArray[start] = targetArray[i-1];
            targetArray[i-1] = pivot;
            return i-1;
        }

        public static int FindPivotIndex(int[] array, int start, int end, int midle)
        {
            if (array[start] > array[midle] && array[midle] > array[end])
            {
                return midle;
            };
            if (array[start] < array[midle] && array[midle] < array[end])
            {
                return midle;
            };
            if (array[midle] > array[start] && array[start] > array[end])
            {
                return start;
            };
            if (array[midle] < array[start] && array[start] < array[end])
            {
                return start;
            };

            return end;
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\lapppa\source\repos\Comparisons\Comparision\IntArray.txt");
            text = text.Replace("\r\n", " ");
            string[] subs = text.Split(' ');
            int[] nums = new int[subs.Length];
            int[] nums2 = { 6, 5 };
            int[] nums3 = { 8, 2, 4, 5, 7, 1 };
            int[] nums7 = { 4, 5, 6, 7 };
            int[] nums8 = { 7, 1, 3, 6, 2, 5, 4, 9, 8 };
            int[] nums4 = { 2, 20, 1, 15, 3, 11, 13, 6, 16, 10, 19, 5, 4, 9, 8, 14, 18, 17, 7, 12 };
            int[] nums5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int i = 0; i < subs.Length; i++)
            {
                nums[i] = int.Parse(subs[i]);
            }

            int [] sortingArr = QuickSort(nums, 0, nums.Length-1);
            for (int i = 0; i < sortingArr.Length; i++)
            {
                Console.WriteLine(sortingArr[i]);
            }
            Console.WriteLine(count);
        }
    }
}


