using System;
using System.Linq;
namespace LeetCodeExercises
{
    public class BullsandCows
    {              
        public string GetHint01(string secret, string guess) {
           
            /*
            该方法，是通过一条对应该Index的数组通过正负来记录出显过的数字
            如：secret里面出显的为+，guess出显的为负，如果对应上，刚好+-相加，刚好相消                        
             */
            int cowCnt = 0;
            int BullCnt = 0;            
            int len = secret.Length;
            int[] numsArr = new int[10];                        
            for (int i = 0; i < len; i++)
            {
                int g =  int.Parse(guess[i]+"");
                int s = int.Parse(secret[i]+"");
                if(s == g) BullCnt++;
                else
                {
                    if(numsArr[s]<0) cowCnt++;
                    if(numsArr[g]>0) cowCnt++;
                    numsArr[s] ++;
                    numsArr[g]--;

                }                
            }
            return BullCnt+"A"+cowCnt+"B";
        }

        public string GetHint02(string secret, string guess) {
             /*
                该方法分两步，先找出位置相同，且相等的，然后设个符号替换
                第二步：在第一步中已经排除了1中的干扰，所以该步可以IndexOf中直接筛选出来，然设个符号替换标记掉
              */         
            int bulls = 0;
            int cows =0;            
            for(int i = 0; i< guess.Length; i++){ 
                for(int y = secret.IndexOf(guess[i]); y > -1;  y = secret.IndexOf(guess[i], y + 1)) {
                if(y == i){                   
                    guess = guess.Remove(i, 1);
                    guess = guess.Insert(i,"x");
                    secret = secret.Remove(y, 1);
                    secret = secret.Insert(y,"x");
                    bulls++;
                    break;
                    }
                }
            }
            for(int i = 0; i< guess.Length; i++){
                int index = secret.IndexOf(guess[i]);
                if(index >= 0 && guess[i]!='x' ) {  
                    secret = secret.Remove(index, 1);
                    secret = secret.Insert(index,"x");
                    cows++;
                }
            }
            return $"{bulls}A{cows}B";
        }
    }
}