/* 
* @Author: XIEXIAN  
* @Date: 2019-06-13 10:56:38  
* @Last Modified by:   XIEXIAN  
* @Last Modified time: 2019-06-13 10:56:38  
*/
using System.Collections.Generic;
using System;
namespace LeetCodeExercises
{    
    public class RomantoInteger
    {
        /*
        Symbol       Value
        I             1
        V             5
        X             10
        L             50
        C             100
        D             500
        M             1000
        */
        //解法一：还行，就是慢咯/(ㄒoㄒ)/~~，我找找别人快的看看
        public int RomanToInt01(string s)
        {
            Dictionary<char,int> dic = new Dictionary<char, int>();
            dic.Add('0',0);           
            dic.Add('I',1);            
            dic.Add('V',5);                      
            dic.Add('X',10);
            dic.Add('L',50);
            dic.Add('C',100);
            dic.Add('D',500);
            dic.Add('M',1000);
            int len = s.Length;
            int result = 0;
            //MCMXCIV1994
            int i = 0;
            while(i<len)
            {
                char curCh = s[i];
                char nextCh = i+1<len?s[i+1]:'0';                
                if(dic[curCh]>=dic[nextCh])
                {
                    result+= dic[curCh];
                    i++;
                }
                else
                {
                    result+= dic[nextCh]-dic[curCh];
                    i+=2;
                }
            }
            return result;            
        }

        //switch好像比字典快，因为：只用几个判断，而字典要到里面去拿，有个查找过程\(^o^)/
        public int RomanToInt02(string s)
        {
            int result = 0;
            int i = 0;
            int len = s.Length;
            while(i<len)
            {
                char curCh = s[i];
                char nextCh = i+1<len?s[i+1]:'0';                
                if(toInt(curCh)>=toInt(nextCh))
                {
                    result+= toInt(curCh);
                    i++;
                }
                else
                {
                    result+= toInt(nextCh)-toInt(curCh);
                    i+=2;
                }
            }
            return result;
        }

        public int toInt(char item) {
            switch(item) {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            }
            return 0;
        }
    }
}