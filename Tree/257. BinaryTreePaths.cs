/* * @Author: XIEXIAN  
* @Date: 2019-07-08 21:31:06  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-07-10 11:52:43
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
        
        //while迭代
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

        //dfs解法
        //https://leetcode.com/problems/binary-tree-paths/discuss/68272/Python-solutions-(dfs%2Bstack-bfs%2Bqueue-dfs-recursively).
        public IList<string> BinaryTreePaths02(TreeNode root) {            
            IList<string> res = new List<string>();
            if(root == null) return res;
            Stack<pathVO> stack = new Stack<pathVO>();
            pathVO vo = new pathVO(root,"");
            stack.Push(vo);
            while(stack.Count != 0)
            {
                pathVO subVo = stack.Pop();
                TreeNode node = subVo.node;
                string path = subVo.path;
                if(node.left == null && node.right == null)
                {
                    res.Add(path + node.val.ToString());
                }
                if(node.left != null) stack.Push(new pathVO(node.left,path + node.val.ToString()+"->"));
                if(node.right != null) stack.Push(new pathVO(node.right,path + node.val.ToString()+"->"));
            }
            return res;
        }
    }

    public class pathVO{
        public TreeNode node;
        public string path;
        public pathVO(TreeNode node,string path)
        {
            this.node = node;
            this.path = path;
        }
    }
    
}