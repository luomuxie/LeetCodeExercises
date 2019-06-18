using System;
using System.Linq;
namespace LeetCodeExercises{
    public class HIndex{
        //问题：找出数组内arr[i]>=len-i中（len-i）最大时成立的arr[i](即数组内大于某数，的最大个数)
        //解法一：
        public int getHIndex01(int[] citations)
        {
            Array.Sort(citations);  
            int len =citations.Length;
            for(int i=0;i<len;i++){
                if(citations[i]>=(len-i)){                    
                    return (len-i);
                }
            }
            return 0;
        }

        //使用桶排序
        public int getHIndex02(int[] citations)
        {
            int len = citations.Length;
            int[] bucket = new int[len+1];
            for (int i = 0; i < len; i++)
            {
                bucket[Math.Min(len,bucket[i])]++;
            }            
            int cnt = 0;
            for (int i = len -1; i>0; i--)
            {
               cnt +=bucket[i];
               if(cnt>=i) return i; 
            }
            return 0;
        }

        //解法三：使用二分查找法
        public int getHIndex03(int[] citations)
        {            
            Array.Reverse(citations);
            int len = citations.Length;
            if(len == 0) return 0;                  
            int start = 0;
            int end = len -1;
            while(end-1> start)
            {
                int mid = (end + start)/2;
                if(mid+1>citations[mid])
                    end = mid;
                else if(mid+1 == citations[mid])
                    return mid+1;
                else
                    start = mid;
                Console.WriteLine(mid);               
            }
            if(end +1<= citations[end])
                return end+1;
            else if(start+1 >citations[start])
                return 0;
            return start+1;
        }

    } 
}