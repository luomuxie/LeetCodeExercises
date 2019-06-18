namespace LeetCodeExercises
{
    using System;
    using System.Linq;
    public class ValidAnagram
    {
        //哎呀，很聪明呀
        public bool IsAnagram01(string s, string t)
        {
            if(s.Length != t.Length) return false;
            int[] array = new int[256];
            for(int i = 0; i < s.Length; i ++){
                array[s[i]] ++;
                array[t[i]] --;
            }
            for(int i = 0; i < array.Length; i ++){
                if(array[i] != 0)
                    return false;
            }
            return true;
        }
    }
}