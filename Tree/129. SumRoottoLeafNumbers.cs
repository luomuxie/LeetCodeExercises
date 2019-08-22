using System.Collections.Generic;
using System;
namespace LeetCodeExercises{
    public class SumRoottoLeafNumbers
    {
        //解法一：
        public int SumNumbers01(TreeNode root) {
            int sum = 0;
            if(root == null) return sum;
            Stack<sumVo> stack = new Stack<sumVo>();
            stack.Push(new sumVo(root,root.val+""));
            while(stack.Count >0)
            {
                sumVo vo = stack.Pop();              
                if(vo.node.left == null && vo.node.right == null){                
                    sum += int.Parse(vo.str);
                }
                if(vo.node.left != null){                   
                    stack.Push(new sumVo(vo.node.left,vo.str+""+ vo.node.left.val));                   
                }
                if(vo.node.right != null){                   
                    stack.Push(new sumVo(vo.node.right,vo.str+""+ vo.node.right.val));                                 
                }
            }
            return sum;
        }

        //解法二：递归
        public int SumNumbers02(TreeNode root) {
            return sum(root,0);
        }
        public int sum(TreeNode n, int s){
            if(n == null) return 0;
            if(n.left == null && n.right == null ) return s*10+n.val;
            return sum(n.left, s*10 + n.val) + sum(n.right, s*10 + n.val);
        }
    }

    public class sumVo{
        public string str;
        public TreeNode node;
        public sumVo(TreeNode node,string str)
        {
            this.node = node;
            this.str = str;
        }
    }
}