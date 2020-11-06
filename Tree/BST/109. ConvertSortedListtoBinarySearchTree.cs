
namespace LeetCodeExercises{
   public class ConvertSortedListtoBinarySearchTree{
        public TreeNode sortedListToBST(ListNode head) {

            if (head == null) return null;                           
            ListNode mid = this.findMiddleElement(head);          
            TreeNode node = new TreeNode(mid.val);           
            if (head == mid) return node;            
            node.left = sortedListToBST(head);
            node.right = sortedListToBST(mid.next);
            return node;
        }

        private ListNode findMiddleElement(ListNode head) {            
            ListNode prevPtr = null;
            ListNode slowPtr = head;
            ListNode fastPtr = head;
            
            while (fastPtr != null && fastPtr.next != null) {
                prevPtr = slowPtr;
                slowPtr = slowPtr.next;
                fastPtr = fastPtr.next.next;
            }
            
            if (prevPtr != null) {
                prevPtr.next = null;
            }

            return slowPtr;
        }
    }    
}



  

