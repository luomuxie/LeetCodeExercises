using System.Collections.Generic;
using System;
namespace LeetCodeExercises{
    public class BinaryTreeLevelOrderTraversalII{

        //dfs解法
        public IList<IList<int>> LevelOrderBottom01(TreeNode root) {
            List<IList<int>> res = new List<IList<int>>();
            if(root == null) return res;
            Stack<TreeNodeVO> stack = new Stack<TreeNodeVO>();

            stack.Push(new TreeNodeVO(root,0));
            while(stack.Count >0)
            {                
                TreeNodeVO vo = stack.Pop(); 
                if(vo.node != null){
                    if(res.Count<vo.lv+1) res.Insert(0,new List<int>());
                    int idx = res.Count-(vo.lv+1);
                    stack.Push(new TreeNodeVO(vo.node.right,vo.lv+1));
                    stack.Push(new TreeNodeVO(vo.node.left,vo.lv+1)); 
                    res[idx].Add(vo.node.val);                   
                }
            }
            return res;
        }

        //bfs解法
        public IList<IList<int>> LevelOrderBottom02(TreeNode root) {
            List<IList<int>> res = new List<IList<int>>();
            if(root == null) return res;
            Queue<TreeNodeVO> queue = new Queue<TreeNodeVO>();
            queue.Enqueue(new TreeNodeVO(root,0));
            while(queue.Count > 0)
            {                
                int lvNum = queue.Count;
                List<int> cur =  new List<int>();
                for (int i = 0; i < lvNum; i++)
                {
                   TreeNodeVO vo = queue.Dequeue(); 
                   if(vo.node.left != null) queue.Enqueue(new TreeNodeVO(vo.node.left,vo.lv+1));
                   if(vo.node.right != null) queue.Enqueue(new TreeNodeVO(vo.node.right,vo.lv+1));
                   cur.Add(vo.node.val);
                }
                res.Insert(0,cur);
            }
            return res;
        }
    }

    public class TreeNodeVO{
        public TreeNode node;
        public int lv;
        public TreeNodeVO(TreeNode node,int lv){
            this.node = node;
            this.lv = lv;
        }
    }
}