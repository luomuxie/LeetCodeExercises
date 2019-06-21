/* 
* @Author: XIEXIAN  
* @Date: 2019-06-20 15:31:51  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-20 16:36:50
*/
using System;
namespace LeetCodeExercises
{
    public class Sqrt
    {
        //呃，我不明白这题的意义何在。。。，可能，也许，不能用math.Sqrt吧，应该
        public int MySqrt01(int x) {
            return (int)Math.Sqrt(x);
        }

        //解法二：不使用math.Sqrt求解，使用二分法查找
        public int MySqrt02(int x) {
            if(x == 0 || x == 1) return x;
            int start = 2,end = x/2;
            while (start<= end)
            {
                int mid = start+(end-start) /2;
                if(mid == x/mid) return mid;
                else if(mid<x/mid) start = mid;
                else end = mid;
            }            
            return end;
        }

        //解法三：使用Integer Newton, Every Language
        //解法地址如下：https://leetcode.com/problems/sqrtx/discuss/25057/3-4-short-lines-Integer-Newton-Every-Language
        public int MySqrt03(int x )
        {
            long r = x;
            while (r*r > x)
                r = (r + x/r) / 2;
            return (int) r;
        }
    }
}