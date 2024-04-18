using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GitHubCopilot
{
    public class UtilityFunction
    {

        // convert string to byte array
        public static byte[] StringToByteArray(string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }
        // write to find if array has duplicate values
        public static bool HasDuplicateValues(int[] arr)
        {
            HashSet<int> hashSet = new HashSet<int>();
            foreach (int i in arr)
            {
                if (!hashSet.Add(i))
                {
                    return true;
                }
            }
            return false;
        }

        // wap to find if number is palindrome or not 
        public static bool IsPalindrome(int num)
        {
            int reversedNum = 0;
            int originalNum = num;
            while (num > 0)
            {
                int remainder = num % 10;
                reversedNum = reversedNum * 10 + remainder;
                num = num / 10;
            }
            return originalNum == reversedNum;
        }


    }

}
