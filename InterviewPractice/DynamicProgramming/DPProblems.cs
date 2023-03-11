using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice.DynamicProgramming
{
    public class DPProblems
    {

        /*
         *  you can walk 1,2,3 steps at a time, find number of ways to do N steps on stairs         *  
         */
        public static int StairStepsPermutationsBottomUp(int numberOfSteps)
        {
            int waysOne = 1;
            int waysTwo = 2;
            int waysThree = 4;

            int start = 4;
            int countWaysN = 0;
            while (start <= numberOfSteps)
            {
                countWaysN= waysOne + waysTwo + waysThree;
                waysOne = waysTwo;
                waysTwo = waysThree;
                waysThree = countWaysN;

                start++;

            }

            return countWaysN;

        }

        public static int StairStepsPermutationsTopDownMemoization(int numberOfSteps, Dictionary<int, int> stepsCountDictionary)
        {
            stepsCountDictionary ??= new Dictionary<int, int>
            {
                {0, 1},
                {1, 1},
                {2, 2},
                {3, 4}
            };

            if (numberOfSteps < 0) return 0;

            if (stepsCountDictionary.ContainsKey(numberOfSteps)) return stepsCountDictionary[numberOfSteps];

            return StairStepsPermutationsTopDownMemoization(numberOfSteps - 1, stepsCountDictionary) +
                   StairStepsPermutationsTopDownMemoization(numberOfSteps - 2, stepsCountDictionary) +
                   StairStepsPermutationsTopDownMemoization(numberOfSteps - 3, stepsCountDictionary);

        }

        public static int StairStepsPermutationsBottomUpMemoizationGeneric(int numberOfSteps, int[] stepsAllowed)
        {
            if (numberOfSteps == 0) return 1;

            int[] memoizationArray = new int[numberOfSteps + 1];
            memoizationArray[0] = 1;

            for (int i = 1; i <= numberOfSteps; i++)
            {
                int total = 0;
                for (int j = 0; j < stepsAllowed.Length; j++)
                {
                    if (i - stepsAllowed[j] >= 0)
                        total += memoizationArray[i - stepsAllowed[j]];
                }

                memoizationArray[i] = total;
            }

            return memoizationArray[numberOfSteps];
        }


        /*
         *  Find path of Robot top left to bottom right with obstacles
         */

        public static HashSet<Point> GetRobotPath(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0) return null;

            HashSet<Point> path = new HashSet<Point>();
            HashSet<Point> pathCovered = new HashSet<Point>();

            if (GetRobotPath(matrix, matrix.Length - 1, matrix[0].Length - 1, path, pathCovered))
            {
                return path;
            }

            return path;

        }

        private static bool GetRobotPath(int[][] matrix, int row, int column, ISet<Point> path, HashSet<Point> pathCovered)
        {
            Console.WriteLine($"Path, {row},{column}");

            Point point = new Point() { Row = row, Column = column };

            if (row == 0 && column == 0)
            {
                path.Add(point);
                return true;
            }


            if (pathCovered.Contains(point))
                return false;

            if (row < 0 || column < 0 || matrix[row][column] != 1)
            {
                pathCovered.Add(point);
                return false;
            }

            if (GetRobotPath(matrix, row - 1, column, path, pathCovered) ||
                GetRobotPath(matrix, row, column - 1, path, pathCovered))
            {
                path.Add(point);
                return true;
            }

            pathCovered.Add(point);
            return false;
        }
    }
}
