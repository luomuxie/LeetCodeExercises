/* 
* @Author: XIEXIAN  
* @Date: 2019-06-10 14:42:30  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-10 17:01:32
*/
using System.Collections.Generic;
using System;
using System.Text;
namespace LeetCodeExercises
{
    /*
    1.     1
    2.     11
    3.     21
    4.     1211
    5.     111221
    6.     312211
    */
    public class CountAndSay
    {
        //该方法解出不，头疼（过，下次再看）
        public string CountAndSay01(int n) {
            int i = 2;
            string res = "21";                                    
            while(i<=n)
            {                
                int cnt = 1;
                string newStr = "";               
                for (int j = 1; j < res.Length; j++)
                {                    
                    if(res[j] != res[j-1])//总结上一个的，准备下一个的
                    {
                        newStr += cnt +res[j-1];
                        cnt = 1;                       
                    }
                    else
                        cnt ++;
                }                
                i++;
                res = newStr;
            }
            return res;
        }

        public string CountAndSay02(int n)
        {
            if(n == 1) return "1"; 
            String prev = CountAndSay02(n - 1); 
            StringBuilder str = new StringBuilder();
            int i = 0;
            while(i < prev.Length ){
                char curr = prev[i];
                int j = 0;
                while(i+j < prev.Length && prev[i+j] == curr) j++;
                str.Append(j);
                str.Append(curr);
                i += j;
            }
            return str.ToString(); 
        }

        //解法三
        public string CountAndSay03(int n)
        {
            var result = "1";
            for(int i = 2; i <= n; i++) {
                result = GetCountAndSay(result);
            }
            
            return result;    
        }

        private string GetCountAndSay(string prev) {
            var count = 1;
            var result = new StringBuilder();
            for(int i = 1; i <= prev.Length; i++) {
                if((i) < prev.Length && prev[i] == prev[i - 1]) {
                    count++;
                } else {
                    result.Append(count).Append(prev[i - 1]);
                    count = 1;
                }
            }
            return result.ToString();
        }

    }
}