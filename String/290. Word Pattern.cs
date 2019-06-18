namespace LeetCodeExercises
{
    using System;
    using System.Collections.Generic;
    
    public class WordPattern
    {
        //解法一：没通过，但我觉得应该差不多了呀,碰坑里面去了，人char->string哎，发现python很快
        public bool wordPattern01(string pattern, string str) {
            
            //abba", str = "dog cat cat dog"
            string[] strArr = str.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            if(strArr.Length != pattern.Length)  return false;
            Dictionary<char,string> dic = new Dictionary<char, string>();
            int len = pattern.Length;
            for (int i = 0; i < len; i++)
            {
                if(!dic.ContainsKey(pattern[i]))
                {                        
                    if(!dic.ContainsValue(strArr[i]))
                    {
                        dic.Add(pattern[i],strArr[i]);
                    }
                    else return false;
                }                                  
                else
                {
                    if(dic[pattern[i]] != strArr[i]) return false;
                }
            }

            return true;
        }


        public bool wordPattern02(string pattern, string str)
        {
            var patternAndWord = new Dictionary<char, string>();
            var wordSet = new HashSet<string>();

            var n = pattern.Length;
            var wordList = str.Split(' ');
            if (n != wordList.Length) return false;

            for (int i = 0; i < pattern.Length; i++) {
                if (patternAndWord.ContainsKey(pattern[i])) {
                    var curWord = patternAndWord[pattern[i]];
                    if (wordList[i] != curWord) {
                        return false;
                    }
                } else {
                    if (wordSet.Contains(wordList[i])) return false;
                    patternAndWord[pattern[i]] = wordList[i];
                    wordSet.Add(wordList[i]);
                }
            }
            return true;            
        }
    }
}