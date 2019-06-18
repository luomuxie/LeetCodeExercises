using System;
using System.Linq;

namespace LeetCodeExercises
{
    public class LengthOfLongestSubstring
    {
        public int  GetLengthOfLongestSubstring(string s) {
            //"pwwkew"
            if(s=="") return 0;
            int len = s.Length;            
            string preStr = "";
            string curStr = "";
            for (int i = 0; i <len ; i++)
            {
                char curChar = s[i];
                if(curStr.IndexOf(curChar) == -1) curStr += curChar;
                else
                {                    
                    preStr = curStr.Length>preStr.Length?curStr:preStr;
                    curStr = curStr.Split(curChar)[1] +curChar;                   
                } 
            }
            return Math.Max(preStr.Length,curStr.Length);
        }
    }
}
