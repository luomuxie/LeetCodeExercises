using System.Collections.Generic;
namespace LeetCodeExercises
{    
    public class populatingNextRightPointerInEachNode{
        public Node Connect(Node root) {
            if(root == null) return null;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue( root);            
            while(queue.Count >0){
                int cnt = queue.Count;
                for (int i = 0; i < cnt; i++)
                {
                    Node node = queue.Dequeue();                    
                    if(i == cnt-1) node.next = null;                        
                    else node.next = queue.Peek(); 
                    if(node.left != null) queue.Enqueue(node.left);
                    if(node.right != null) queue.Enqueue(node.right);
                }
            }
            return root;
        }
    }

    public class Node {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next) {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    
}