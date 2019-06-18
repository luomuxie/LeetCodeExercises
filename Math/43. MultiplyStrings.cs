/* 
* @Author: XIEXIAN  
* @Date: 2019-06-18 15:23:55  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-18 17:54:35
*/
using System.Text;
using System;
namespace LeetCodeExercises
{
    public class MultiplyStrings
    {
        //考查大数积
        //方法一：利用两个数的乘积位数为两个数位和或两位数和-1，解释如下：
        //https://leetcode.com/problems/multiply-strings/discuss/17605/Easiest-JAVA-Solution-with-Graph-Explanation
        public string Multiply01(string num1, string num2) {
            int n1 = num1.Length, n2 = num2.Length;
            int[] products = new int[n1 + n2];
            for (int i = n1 - 1; i >= 0; i--) {
                for (int j = n2 - 1; j >= 0; j--) {
                    int d1 = num1[i] - '0';
                    int d2 = num2[j] - '0';
                    products[i + j + 1] += d1 * d2;
                }
            }
            int carry = 0;
            for (int i = products.Length - 1; i >= 0; i--) {
                int tmp = (products[i] + carry) % 10;
                carry = (products[i] + carry) / 10;
                products[i] = tmp;
            }
            StringBuilder sb = new StringBuilder();
            foreach (int num in products) sb.Append(num);
            while (sb.Length != 0 && sb[0] == '0') sb.Remove(0,1);
            return sb.Length == 0 ? "0" : sb.ToString();
        }

        //解法二：为上面解法一的优化版
        public string Multiply02(string num1, string num2) {
            int m = num1.Length, n = num2.Length;
            int[] pos = new int[m + n];        
            for(int i = m - 1; i >= 0; i--) {
                for(int j = n - 1; j >= 0; j--) {
                    int mul = (num1[i] - '0') * (num2[j] - '0'); 
                    int p1 = i + j, p2 = i + j + 1;
                    int sum = mul + pos[p2];

                    pos[p1] += sum / 10;
                    pos[p2] = (sum) % 10;
                }
            }              
            StringBuilder sb = new StringBuilder();
            foreach(int p in pos) if(!(sb.Length == 0 && p == 0)) sb.Append(p);
            return sb.Length == 0 ? "0" : sb.ToString();
        }
    }
}