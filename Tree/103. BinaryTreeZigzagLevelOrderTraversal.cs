using System;
using System.Collections.Generic;
namespace LeetCodeExercises{
    public class BinaryTreeZigzagLevelOrderTraversal
    {

        //解法一：queque+bfs
        public IList<IList<int>> ZigzagLevelOrdero01(TreeNode root) {
            List<IList<int>> res = new List<IList<int>>();
            if(root == null) return res;
            Queue<pathZVO> queue = new Queue<pathZVO>();
            queue.Enqueue(new pathZVO(root,'l'));
            while(queue.Count>0){                
                int lvCnt = queue.Count;
                List<int> cur = new List<int>();
                for (int i = 0; i < lvCnt; i++)
                {
                    pathZVO vo = queue.Dequeue();
                    char dic = 'l';
                    
                    if(vo.dic == 'l'){
                        dic = 'r';
                        cur.Insert(0,vo.node.val);
                        
                    }else{
                        cur.Add(vo.node.val);                        
                    }
                    if(vo.node.right != null) queue.Enqueue(new pathZVO(vo.node.right,dic));
                    if(vo.node.left != null) queue.Enqueue(new pathZVO(vo.node.left,dic));
                }
                res.Add(cur);                
            }
            return res;
        }        
    }

    public  class pathZVO{
        public TreeNode node;
        public char dic;
        public pathZVO(TreeNode node,char dic){
            this.node = node;
            this.dic = dic;
        }
    }
}