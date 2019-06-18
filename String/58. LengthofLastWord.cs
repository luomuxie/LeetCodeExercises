namespace LeetCodeExercises
{
    using System.Linq;
    public class LengthofLastWord
    {
        public int LengthOfLastWord01(string s) {
            return s.Trim().Split().LastOrDefault().Length;
        }
    }
}