/* 
* @Author: XIEXIAN  
* @Date: 2019-06-11 14:56:54  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-06-11 15:05:32
*/
using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetCodeExercises
{
    public class RemoveDuplicateLetters
    {
        public string removeDuplicateLetters01(string s)
        {
           List<char> list = new List<char>();
           for (int i = 0; i < s.Length; i++)
           {
               if(!list.Contains(s[i])) list.Add(s[i]);
               list.Sort();
           } 
            return new string(list.ToArray());
        }

        //这个解法，说实在，还没搞懂
        public string removeDuplicateLetters02(string s)
        {
            var charAndCount = new int[256];
            foreach (var c in s) {
                charAndCount[c]++;//计算每个字符个数，存储
            }
            var isVisited = new HashSet<char>();
            var charStack = new Stack<char>();//存储结果
            foreach (var c in s) {//遍历整个s
                if(!isVisited.Contains(c))
                {
                    while (charStack.Any())
                    {
                        var preChar = charStack.Peek();
                        if (charAndCount[preChar] > 0 && preChar > c)
                        {
                            var popped = charStack.Pop();
                            isVisited.Remove(popped);
                        }
                        else break;
                    }
                    isVisited.Add(c);
                    charStack.Push(c);
                }
                charAndCount[c]--;
            }
            var result = new List<char>();
            while (charStack.Any()) {
                result.Add(charStack.Pop());
            }
            result.Reverse();
            return string.Join("", result);
        }

        //https://leetcode.com/problems/remove-duplicate-letters/discuss/76766/Easy-to-understand-iterative-Java-solution
        //以上为解解释
        //明了明了
        public String removeDuplicateLetters03(String s) {
            if (s == null || s.Length <= 1) return s;
            //存储每个letter最后出现的位置
            Dictionary<char, int> lastPosMap = new Dictionary<char, int>();
            for (int i = s.Length -1; i >= 0; i--) {
                if(!lastPosMap.ContainsKey(s[i]))
                    lastPosMap.Add(s[i], i);
            }
            char[] result = new char[lastPosMap.Count()];//存储结果
            int begin = 0, end = findMinLastPos(lastPosMap);//用于定位查找范围

            for (int i = 0; i < result.Length; i++) {
                char minChar = (char)('z' + 1);
                for (int k = begin; k <= end; k++) {
                    if (lastPosMap.ContainsKey(s[k]) && s[k] < minChar) {
                        minChar = s[k];//通过在这里的和上面if的判断拦截的排序，实现最小字典序
                        begin = k+1;
                    }
                }

                result[i] = minChar;
                if (i == result.Length-1) break;
                lastPosMap.Remove(minChar);
                if (s[end] == minChar) end = findMinLastPos(lastPosMap);
            }

            return new String(result);
        }

        private int findMinLastPos(Dictionary<char, int> lastPosMap) {
            if (lastPosMap == null || !lastPosMap.Any()) return -1;
            int minLastPos = int.MaxValue;
            foreach (int lastPos in lastPosMap.Values)
            {
                minLastPos = Math.Min(minLastPos, lastPos);
            }
            return minLastPos;
        }
    }
}