/* 
* @Author: XIEXIAN  
* @Date: 2019-06-05 15:37:13  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-05 15:48:10
*/
namespace LeetCodeExercises
{
    using System;
    public class ReverseString
    {
        //解法一：慢得一BB，shit
        public void ReverseString01(char[] s) 
        {
            Array.Reverse(s); 
        }

        //解法二：自己写个交换看看，会不会快一丢丢
        //结论：是快了一丢丢，但真只是一丢丢
        public void ReverseString02(char[] s) 
        {
            int len = s.Length;
            for (int i = 0; i < len/2; i++)
            {
                char temp = s[i];
                s[i] = s[len-i-1];
                s[len-i-1] = temp;
            }
        }

        //解法三：使用双指针，和二根本没什么不同，垃圾，不理了
        public void ReverseString03(char[] s) 
        {
            int start = 0;
            int end = s.Length - 1;
            char temp;
            
            while(start < end)
            {
                temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                start++;
                end--;
            }
        }


    }
}