using System;
using System.Linq;
namespace LeetCodeExercises
{
    public class GasStation    
    {
        //普通算法O(n*2)，直接便利
        public int CanCompleteCircuit01(int[] gas, int[] cost) {
            int len = gas.Length;
            for (int i = 0; i < len; i++)
            {
                int hasGas = gas[i];
                int nextCost = cost[i];
                int curIndex = i; 
                int cnt=0;               
                while(hasGas>=nextCost)
                {    
                    cnt++;
                    if(cnt >=len) return i;
                    curIndex++;
                    curIndex = curIndex%len;
                    hasGas = hasGas - nextCost +gas[curIndex];
                    nextCost = cost[curIndex];                    
                } 
            }
            return -1;
        }

        //这里有两个定义：
        // 1、gasTotal-costTotal>-1，必定有一个解
        // 2、当a-->b为负时，a-------b之间没有任何解，所以下一次判断，可以直接从b+1开始
        // 证明二：当i点为正，i+1为负，所以i+1肯定为负，可以跳过，直接到i+2，以此类推

        //该解法为双向遍历
        public int CanCompleteCircuit02(int[] gas, int[] cost) {
            Array.Sort(gas);            
            int start = gas.Length-1;
            int end = 0;
            int sum = gas[start] - cost[start];
            while (start > end) {
                if (sum >= 0) {
                    sum += gas[end] - cost[end];
                    ++end;
                }
                else {
                    --start;
                    sum += gas[start] - cost[start];
                }
            }
            return sum >= 0 ? start : -1;
        }
    }
    
}