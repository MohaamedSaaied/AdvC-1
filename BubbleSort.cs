using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_1
{
    internal class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            int size = arr.Length;
            bool swapped;

            for (int i = 0; i < size - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        swapped = true;
                    }
                }

                
                if (!swapped)
                    break;
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
