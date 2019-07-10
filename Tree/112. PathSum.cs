using System.Collections.Generic;
namespace LeetCodeExercises
{
    /*
        需求：判断树中是否存节点相加为固定和的路径
     */
    public class PathSum
    {
        //解法一：dfs使用whill迭代
        public bool HasPathSum01(TreeNode root, int sum) {
            if(root == null ) return false;
            Stack<PathSumVo> stack = new Stack<PathSumVo>();
            stack.Push(new PathSumVo(root,root.val));
            while(stack.Count != 0)
            {
                PathSumVo vo = stack.Pop();
                if(vo.node.left == null && vo.node.right == null)
                {
                    if(vo.sum == sum) return true;
                }                
                if(vo.node.left != null) stack.Push(new PathSumVo(vo.node.left,vo.sum+vo.node.left.val));
                if(vo.node.right != null) stack.Push(new PathSumVo(vo.node.right,vo.sum+vo.node.right.val));

            }
            return false;
        }

        //解法二：递归求解
        public bool HasPathSum02(TreeNode root, int sum) {
            if(root == null) return false;
            if(root.left == null && root.right == null) return sum == root.val;     
            return HasPathSum02(root.left, sum - root.val) || HasPathSum02(root.right, sum - root.val);     
        }

        //其他类似解：
        //https://leetcode.com/problems/path-sum/discuss/36486/Python-solutions-(DFS-recursively-DFS%2Bstack-BFS%2Bqueue)

    }

    class PathSumVo
    {
        public TreeNode node;
        public int sum;
        public PathSumVo(TreeNode node,int sum)
        {
            this.node = node;
            this.sum = sum;
        }
    }
}