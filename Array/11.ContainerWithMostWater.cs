/* 
* @Author: XIEXIAN  
* @Date: 2019-05-16 11:29:33 
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-04 14:30:24
*/
namespace LeetCodeExercises
{
    using System;    
    public class ContainerWithMostWater
    {
        //解法一：(Brute Force)暴力求解,循环遍历迭代，算出每个最大值,但复杂度达到了N(O2)
        public int MaxArea01(int[] height)
        {
            int len = height.Length;
            int maxArea = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = i+1; j < len; j++)
                {
                    maxArea = Math.Max(maxArea,(j-i)*Math.Min(height[i],height[j]));
                }
            }
            return maxArea;
        }

        //解法二：(双指针解法)
        public int MaxArea02(int[] height)
        {
            int maxArea = 0;
            int i = 0;
            int j = height.Length -1;            
            while(j>i)
            {
                maxArea = Math.Max(maxArea,(j-i)*Math.Min(height[i],height[j]));
                if(height[j]>=height[i])
                    i++;
                else
                    j--;
            }         
            return maxArea;
        }
    }    
}