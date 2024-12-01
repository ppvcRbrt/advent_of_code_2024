using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_HistorianHysteria
{
    public static class ListHelper
    {

        public static int GetTotalDistance(int[] list1, int[] list2)
        {
            int totalDistance = 0;
            if (list1.Length != list2.Length)
            {
                return -1;
            }

            for(int i = 0; i < list1.Length; i++)
            {
                totalDistance += Math.Abs(list1[i] - list2[i]);
            }

            return totalDistance;
        }
        public static (List<int> leftList, List<int> rightList) GetListsFromInput(string inputPath)
        {
            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();

            foreach (var line in File.ReadLines(inputPath))
            {
                var parts = line.Split("   ");
                leftList.Add(int.Parse(parts[0]));
                rightList.Add(int.Parse(parts[1]));
            }
            return (leftList, rightList);
        }
        public static void BubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
        }

    }
}
