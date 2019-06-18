using System;
using System.Linq;
namespace LeetCodeExercises
{
    public class PlusOne
    {
        //方法一：没跑通，/(ㄒoㄒ)/~~
        public int[] PlusOne01(int[] digits) {
            int len = digits.Length;
            if(len == 0) return digits;
            int val = int.Parse( string.Join("",digits))+1;
            int newLen = val.ToString().Length;
            int[] result = new int[newLen];
            newLen --;            
            while (val>0)
            {
                int remain = val%10;
                result[newLen] = remain;
                val/=10;
                newLen--;
            }          
            return result;
        }

        //很快了，这个方法
        public int[] PlusOne02(int[] digits) {
            int n = digits.Length;
            for(int i=n-1; i>=0; i--) {
                if(digits[i] < 9) {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            int[] newNumber = new int [n+1];
            newNumber[0] = 1;
            return newNumber;
        }

    }
}