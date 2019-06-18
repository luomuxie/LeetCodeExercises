using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
namespace LeetCodeExercises
{
    public class GroupAnagrams
    {
        //方法一:
        public IList<IList<string>> GroupAnagrams01(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();        
            foreach(var s in strs){            
                char[] tempArray = s.ToCharArray();
                Array.Sort(tempArray); 
                var key = new string(tempArray);//这里已经排好，所以每个key都是唯一的                
                if(!dict.ContainsKey(key)){
                    dict[key] = new List<string>();
                }
                dict[key].Add(s);
            }        
            return dict.Values.ToList();
        }
        //解法二：以数字记算个数，区分，方法好像比一要慢那么一点
        public IList<IList<string>> GroupAnagrams02(string[] strs)
        {
            if (strs.Length == 0) return new List<List<String>>() as IList<IList<string>> ;
            Dictionary<String, IList<string>> ans = new Dictionary<string, IList<string>>();
            int[] count = new int[26];
           foreach (string s in strs)
           {                               
                Array.Fill(count, 0);
                foreach (char c in s.ToCharArray()) count[c - 'a']++;
                StringBuilder sb = new StringBuilder("");               
                for (int i = 0; i < 26; i++) {
                    sb.Append('#');
                    sb.Append(count[i]);
                }
                String key = sb.ToString();
                if (!ans.ContainsKey(key)) ans.Add(key, new  List<string>());
                ans[key].Add(s);
            }
            return ans.Values.ToList();
        }
    }
}