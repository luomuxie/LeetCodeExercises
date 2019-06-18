/* 
* @Author: XIEXIAN  
* @Date: 2019-06-04 20:43:49  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-04 21:32:48
*/
namespace LeetCodeExercises
{
    using System.Collections.Generic;
    public class FirstUniqueCharacterinString
    {
        //方法一：没有通过，时间超时，应该是在remove和contains查找这里超了
        public int FirstUniqChar01(string s)
        {
            //loveleetcode",
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                char ch = s[i];
                if(!s.Remove(i,1).Contains(ch))return i;
            }
            return -1;
        }

        public int FirstUniqChar02(string s)
        {
           
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int n = s.Length;           
            for (int i = 0; i < n; i++) {
                char c = s[i];                
                if(dic.ContainsKey(c))dic[c] = dic[c]+1;
                else dic.Add(c,1);                
            }
            
            foreach (var item in dic)
            {
                if(item.Value == 1)
                return s.IndexOf(item.Key);
            }
            return -1;
        }
    }
}