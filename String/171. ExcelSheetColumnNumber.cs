/* 
* @Author: XIEXIAN  
* @Date: 2019-06-12 11:49:35  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-12 12:29:31
*/
using System;
namespace LeetCodeExercises
{
    public class ExcelSheetColumnNumber
    {
         //解法一：
        public int TitleToNumber01(string s)
        {
            int len = s.Length;           
            int result = 0;
            for (int i = 0; i < len; i++)
            {            
                result += (int) Math.Pow(26, len - i - 1)*(s[i] - 'A' + 1);              
            }
            return result;
        }

        //解法二：
        public int TitleToNumber02(string s)
        {
            int sum = 0;
            int len = s.Length;
            for (int i = 0; i < len - 1; i++) {

                int num = s[i] - '0' - 16;
                sum = (sum + num) * 26;
            }
            return sum + s[len-1] - '0' - 16;
        }
    }
}