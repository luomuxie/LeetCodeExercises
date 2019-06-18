/* * @Author: XIEXIAN  
* @Date: 2019-06-04 15:01:32  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-04 16:37:33
*/
namespace LeetCodeExercises
{
    using System;
    public class LongestCommonPrefix
    {
        //解法一：
        public string LongestCommonPrefix01(string[] strs) {            
            int strsLen = strs.Length;
            if(strsLen == 0) return "";
            string str = strs[0],longestVal = "";
            int len = str.Length;            
            for (int i = 0; i < len; i++)
            {
                string curVal = longestVal+str[i];                
                for (int j = 1; j <strsLen; j++)
                {
                    if(strs[j].Length<i+1 ||!strs[j][i].Equals(str[i]))
                    {
                        return longestVal;                        
                    }
                }
                longestVal = curVal;
            }
            return longestVal;
        }
    }
}