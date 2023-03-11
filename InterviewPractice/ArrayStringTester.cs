using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPractice
{
    public class ArrayStringTester
    {
        public ArrayStringTester()
        {

        }

        public bool PalindromePermutation(string data)
        {
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();
            bool allowedSingle = data.Length % 2 != 0 ? true : false;

            foreach(char c in data)
            {
                if (c != ' ') 
                if (charDictionary.ContainsKey(c))
                {
                    charDictionary[c]++;
                }
                else
                {
                    charDictionary.Add(c,1);
                }                        
            }

            foreach(var pair in charDictionary)
            {
                if(pair.Value%2 != 0 && allowedSingle)
                {
                    allowedSingle = false;
                    continue;
                }

                if (pair.Value % 2 != 0)
                    return false;
            }
            

            return !allowedSingle;
        }


        /*
         *  Input : "aabbccdf"
         *  Output : "a2b2c2d1f1"   
         */

        public string StringCompression(string data)
        {
            if (string.IsNullOrEmpty(data)) return data;
            int len = data.Length;
                       

            if (len <= 2) return data;

            StringBuilder compressedString = new StringBuilder();
            int count = 1;

            for(int i = 1; i < len; i++)
            {
                if(data[i] == data[i-1])
                {
                    count++;
                }
                else
                {
                    compressedString.Append(data[i - 1]).Append(count);
                    count = 1;
                }
            }

            return compressedString.Append(data[len-1]).Append(count).ToString();
        }


        /*
         * string permutations example ABCD will give 24 permutations
         */

        public static List<string> FindAllPermutations(string data, int startIndex)
        {
            if (string.IsNullOrEmpty(data) || startIndex >= data.Length)
                return new List<string>();

            var TempList = FindAllPermutations(data, startIndex + 1);
            var permutations = InsertChar(TempList, data[startIndex]);

            return permutations;

        }

        private static List<string> InsertChar(List<string> tempList, char c)
        {
            if (tempList.Count == 0) return new List<string>() { c.ToString() };

            List<string> returnList = new List<string>();

            foreach (var s in tempList)
            {
                for (int i = 0; i <= s.Length; i++)
                {
                    string temp = s.Insert(i, c.ToString());
                    returnList.Add(temp);
                }
            }

            return returnList;
        }
    }
}
