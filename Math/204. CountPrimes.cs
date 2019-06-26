/* 
* @Author: XIEXIAN  
* @Date: 2019-06-25 16:23:56  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-26 14:50:22
*/
using System;
namespace LeetCodeExercises
{
    public class CountPrimes
    {
        //计算n内的素数
        //方法一:
        public int CountPrimes01(int n) {
            int cnt = 0;
            for (int i = 2; i < n; i++)
            {
                var sqt = Math.Sqrt(Convert.ToDouble(i));
                bool isPre = true;
                for (int j = 2; j <= sqt; j++)
                {
                    if(i%j==0)
                    {
                        isPre = false;
                        break;
                    }                                         
                }
                if(isPre == true ) cnt ++;
            }
            return cnt;
        }

        //解法二：解法
         public int CountPrimes02(int n) {
            if (n < 3) return 0;                                
            bool[] f = new bool[n];            
            int count = n / 2;
            for (int i = 3; i * i < n; i += 2) {
                if (f[i])  continue;
                for (int j = i * i; j < n; j += 2 * i) {
                    if (!f[j]) {
                        --count;
                        f[j] = true;
                    }
                }
            }
            return count;
        }
    }
}