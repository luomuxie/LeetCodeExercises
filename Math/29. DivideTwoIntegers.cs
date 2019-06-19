/* 
* @Author: XIEXIAN  
* @Date: 2019-06-19 15:37:59  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-19 17:10:15
*/
using System;
namespace LeetCodeExercises
{
    //该题即为需求：不用乘除摩运算，求商(int)值
    public class DivideTwoIntegers
    {   
        //解法一：使用二进制位运算求解     
       //可参考博客： https://www.cnblogs.com/AlvinZH/p/8643676.html
       //leetdoce:https://leetcode.com/problems/divide-two-integers/discuss/13407/C%2B%2B-bit-manipulations
         public int Divide01(int dividend, int divisor) {
            bool isNegative = (dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0) ? true : false;
            long absDividend = Math.Abs((long) dividend);
            long absDivisor = Math.Abs((long) divisor);
            long result = 0;
            while(absDividend >= absDivisor){
                long tmp = absDivisor, count = 1;
                while(tmp <= absDividend){
                    tmp <<= 1;
                    count <<= 1;
                }
                result += count >> 1;
                absDividend -= tmp >> 1;
            }
            return  isNegative ? (int) ~result + 1 : result > int.MaxValue ? int.MinValue : (int) result;
        }

        //解法二：使用纯减法递归方式求解()
        //相应leetcode地址：https://leetcode.com/problems/divide-two-integers/discuss/13520/Easy-divide-and-conquer-solution
        public int Divide(int dividend, int divisor) {
            if (divisor==0) { return int.MaxValue; }
            if (divisor==1) { return dividend; }
            if (divisor==-1) { return dividend==int.MinValue?int.MaxValue:-dividend; }
            bool isNeg = dividend<0 && divisor>0 || dividend>0 && divisor<0;
            long dd = Math.Abs((long)dividend);
            long dr = Math.Abs((long)divisor);
            long res = div(dd, dr);
            return isNeg?-(int)res:(int)res;
        }
    
        private long div(long dd, long dr){  // all positive
            if (dd<dr) { return 0; }
            long res = 1, pre = dr;
            while(dd-dr>=dr){
                dr += dr;
                res += res;
            }
            long final = div(dd-dr, pre) + res;
            return final;
        }
    }
}