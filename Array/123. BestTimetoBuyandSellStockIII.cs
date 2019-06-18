/* *
 @Author: XIEXIAN  
* @Date: 2019-05-14 18:26:16  
*/
namespace LeetCodeExercises{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class BestTime2BuyAndSellStockIII{
        //该问题主要求每个低谷到高峰的差值总和
        //[7,1,5,3,6,4]

        //解法一：把从底谷到高峰的过程，细分为每个数组单位，并将每个单位值相加（没跑通。。。嗯）
        public int MaxProfit01(int[] prices) {            
            int len = prices.Length;
            if(len <=1) return 0;           
            int low = 0;
            int higth = 0;
            List<int> list = new List<int>();
            for (int i = 1; i < len-1; ++i)
            {
                if(prices[i]<=prices[i-1] && prices[i]<=prices[i+1])//说明此时在峰谷
                    low = i;
                if((prices[i]>=prices[i-1] && prices[i]>=prices[i+1])||(i==len-2 && prices[i]>=prices[i-1]))//说明此时在峰顶,后面那个判断是最用于最后是一个上升趋势的处理
                {
                    higth = i;                    
                    int profit = prices[higth] - prices[low];
                    list.Add(profit);
                    low = i;//该波谷在本处已经使用过了，要重置，不能再用
                }
            }
            if(prices[len-1]>prices[len-2])
            {
                if(list.Count>0 && (low != len-2 || low == higth))
                    list[list.Count-1] += (prices[len-1]-prices[len-2]);
                else 
                    list.Add(prices[len-1]-prices[len-2]);                 
            }
            int listCnt = list.Count;
            list.Sort();
            return list.Count>2?list[listCnt-1]+list[listCnt-2]:list.Sum(); 
        }

        //解法二：
       public int MaxProfit02(int[] prices )
       {
            if(prices == null || prices.Length == 0) return 0;
            int length = prices.Length;
            int[] oneProfit = new int[length];//存放最低利润

            //minimum value from 0 to i(included)
            int minSoFar = prices[0];
            for(int i = 1; i < length; i++){
                oneProfit[i] = Math.Max(oneProfit[i - 1], prices[i] - minSoFar);
                minSoFar = Math.Min(minSoFar, prices[i]);
            }
            
            int[] twoProfit = new int[length];            
            for(int i = 1; i < length; i++){
                int max = twoProfit[i - 1];
                for(int j = 0; j < i; j++){
                    max = Math.Max(max, oneProfit[j]+(prices[i] - prices[j]));//到J位置的最大值与(i位买入j买出红利)的和
                }
                twoProfit[i] = max;
            }
            return twoProfit[length - 1];
       }
    }
}