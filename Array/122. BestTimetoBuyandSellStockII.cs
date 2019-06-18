/*
 * @Author:xiexian
 * @Date: 2019-05-14 14:36:55 
 */
namespace LeetCodeExercises{
    using System;
    public class BestTime2BuyAndSellStockII{
        //该问题主要求每个低谷到高峰的差值总和
        //[7,1,5,3,6,4]

        //解法一：把从底谷到高峰的过程，细分为每个数组单位，并将每个单位值相加
        public int MaxProfit01(int[] prices) {            
            int profit = 0;
            int len = prices.Length;
            for (int i = 1; i < len; ++i) {
                if (prices[i] > prices[i - 1]) {
                    profit += prices[i] - prices[i - 1];
                }
            }
            return profit; 
        }

        //解法二：（还没跑通。。。。。），跑通了，哈哈哈哈
        //找由每个波峰与波谷的差，所在差的总和为所求
        public int MaxProfit02(int[] prices) {                        
            int len = prices.Length;
            if(len <=0) return 0;            
            int profit = 0;
            int low = 0;
            int higth = 0;
            for (int i = 1; i < len -1; i++)
            {
                if(prices[i]<=prices[i-1] && prices[i]<=prices[i+1])//说明此时在峰谷
                    low = i;
                if((prices[i]>=prices[i-1] && prices[i]>=prices[i+1])||(i==len-2 && prices[i]>=prices[i-1]))//说明此时在峰顶,后面那个判断是最用于最后是一个上升趋势的处理
                {
                    higth = i;                    
                    profit+=prices[higth] - prices[low];
                    low = i;//该波谷在本处已经使用过了，要重置，不能再用
                }
            }                     
            if(prices[len-1]>prices[len-2]) profit+= prices[len-1]-prices[len-2];
            return profit;
        }   
    }
}