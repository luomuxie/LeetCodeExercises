/* * 
@Author: XIEXIAN  * 
@Date: 2019-05-28 16:17:12  * 
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-05-29 14:44:54
*/

namespace LeetCodeExercises
{    
    using System; 
    using System.Collections.Generic;
    public class TrappingRainWater
    {
  
         //解法一：Brute force，暴力求解
         //求出每一柱当前的值，（当前柱的值，等于柱左右两边的最大值中，从两个值选取最小值）- 当前值的高度                   
        public int Trap01(int[] height) {               
            int res = 0;
            int len = height.Length;
            for (int i = 1; i < len - 1; i++) {
                int max_left = 0, max_right = 0;
                for (int j = i; j >= 0; j--) { //Search the left part for max bar size
                    max_left = Math.Max(max_left, height[j]);
                }
                for (int j = i; j < len; j++) { //Search the right part for max bar size
                    max_right = Math.Max(max_right, height[j]);
                }
                res += Math.Min(max_left, max_right) - height[i];
            }
            return res;
        }

         /*解法二： */   
        //动态规划求解：Dynamic Programming
        //优化解法一中的每次遍历求最大值
        public int Trap02(int[] height) {          
            int len = height.Length;
            if(len == 0) return 0; 
            int res = 0;
            int[] left_max = new int[len];
            int[] right_max = new int[len];           
            left_max[0] = height[0];
            for (int i = 1; i < len; i++) {
                left_max[i] = Math.Max(height[i], left_max[i - 1]);
            }
            right_max[len - 1] = height[len - 1];
            for (int i = len - 2; i >= 0; i--) {
                right_max[i] = Math.Max(height[i], right_max[i + 1]);
            }
            for (int i = 1; i < len - 1; i++) {
                res +=  Math.Min(left_max[i], right_max[i]) - height[i];
            }
            return res;              
        }

        //通过stacks求解：
        public int Trap03(int[] height)
        {
            int len = height.Length;
            int ans = 0;            
            Stack<int> st = new Stack<int>();
            for (int i = 0; i < len; i++)
            {
                while (st.Count!=0 && height[i] > height[st.Peek()]) {
                    int top = st.Pop();                
                    if (st.Count!=0)
                        break;
                    int distance = i - st.Peek() - 1;
                    int bounded_height = Math.Min(height[i], height[st.Peek()]) - height[top];
                    ans += distance * bounded_height;
                }
                st.Push(i);
            }
            return ans;
        }



        //双指针求解
        public int Trap04(int[] height)
        {
            int len = height.Length;
            if(len == 0) return 0; 
            int res = 0;
            return res;
        }


    }
}