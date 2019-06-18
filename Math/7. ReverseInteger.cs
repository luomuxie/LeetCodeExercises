/* 
* @Author: XIEXIAN  
* @Date: 2019-06-13 16:35:32  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-13 16:41:22
*/
using System;
using System.Linq;
namespace LeetCodeExercises
{
    public class ReverseInteger
    {
        public int Reverse01(int x) {
            if(x == 0) return 0;
            int result = 0;
            while (x != 0)
            {
                int tail = x % 10;
                int newResult = result * 10 + tail;                           
                result = newResult;
                x = x / 10;
            }
            return result;
        }
    }
}