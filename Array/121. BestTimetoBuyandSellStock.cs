/* 
* @Author: XIEXIAN  * @Date: 2019-05-15 15:17:00  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-05-15 17:16:11
*/
namespace LeetCodeExercises{
    using System;
    using System.Linq;
    public class BestTime2BuyAndSellStock{
        //[7,1,5,3,6,4]
        public int MaxProfit01(int[] prices) {
            int sellDay = 0;
            int buyDay = 0;
            int maxProfit = 0;   
            int len = prices.Length;
            for (int i = 0; i < len; i++)
            {    
                if(prices[sellDay]<prices[i])
                {
                    sellDay = i;
                    int newProfit = prices[i] - prices[buyDay];
                    maxProfit = Math.Max(newProfit,maxProfit);
                }
                else if(prices[i]<prices[buyDay])
                {
                    buyDay  = i;
                    if(i>sellDay) sellDay = i;
                }
            }
            return maxProfit;
        }

        //解法二：DP(动态规划)解,其实与解一差不多
        public int maxProfit02(int[] prices)
        {
            
            return 0;
        }
                
        //解法三：Max subArrary(最大子数组数)方法解
        public int maxProfit03(int[] prices)
        {
            int len = prices.Length;
            if(len<=1) return 0;
            int[] maxProfitArr = new int[len-1];
            for (int i = 1; i < len; i++)
            {
                maxProfitArr[i-1] = prices[i] - prices[i-1];
            }            
            //以后使用最大字数组求和
            for (int i = 0; i < len-1; i++)
            {
                if(maxProfitArr[i-1]>0)
                {
                    maxProfitArr[i] += maxProfitArr[i-1];
                }
            }
            return maxProfitArr.Max();
        }
        
    }
}