/* * @Author: XIEXIAN  
* @Date: 2019-07-08 21:31:06  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-07-09 14:55:15
*/
using System.Collections.Generic;
using System.Text;
using System;
namespace LeetCodeExercises
{
    public class BinaryTreePaths
    {
        /*
        需求：以a->b->c方式，求根节点到叶节点路径
        //待更进一步总结
         */
        public IList<string> BinaryTreePaths01(TreeNode root) {
            IList<string> res = new List<string>();                    
            StringBuilder sb = new StringBuilder();
            helper(res, root, sb);        
            return res;            
        }

        private void helper(IList<string> res, TreeNode root, StringBuilder sb) {
            if(root == null) {
                return;
            }
            int len = sb.Length;
            sb.Append(root.val);
            if(root.left == null && root.right == null) {
                Console.WriteLine(sb.ToString());
                res.Add(sb.ToString());
            } else {
                sb.Append("->");
                helper(res, root.left, sb);
                helper(res, root.right, sb);
            }
            sb.Length = len;
        }
    }
}