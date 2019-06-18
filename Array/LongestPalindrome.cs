namespace LeetCodeExercises
{
    using System;
    public class LongestPalindrome
    {
        public string GetLongestPalindrome(string s)
        {
            if(s.Length == 1 ) return s;
            int len = s.Length;
            string preStr = "";
            string curStr = "";                       
            for (int i = 0; i < len; i++)
            {                 
                string doubleStr = getLongest(s,i-1,i,"");
                string simgleStr = getLongest(s,i-1,i+1,s[i]+"");
                curStr  = doubleStr.Length>simgleStr.Length?doubleStr:simgleStr;
                preStr =  curStr.Length>preStr.Length?curStr:preStr;
            }          
            return  curStr.Length>preStr.Length?curStr:preStr;
        }

        public string getLongest(string s,int lastIndex,int preIndex,string curStr)
        {
            int len = s.Length;
            while(lastIndex>-1 && preIndex <len && s[lastIndex] == s[preIndex])
            {
                curStr = s[lastIndex]+curStr;
                curStr = curStr + s[preIndex];
                lastIndex--;
                preIndex ++;                    
            }   
            return curStr;
        }        
    }
}