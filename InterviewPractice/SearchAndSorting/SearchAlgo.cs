using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice.SearchAndSorting
{
    public class SearchAlgo
    {

        /*
         *  [3,4,5,7,8,9,33,56]
         *  [8]
         * return --> 4
         */
        public static int BinarySearch(int[] data, int element)
        {
            if (data == null || data.Length <= 0) return -1;
            int start = 0;
            int end = data.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (data[mid] == element) return mid;

                if (data[mid] < element)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return -1;
        }
    }
}
