namespace MergeTwoSortedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
       public static ListNode mergtwolist(ListNode list1, ListNode list2)
        {
         
            ListNode dummy = new ListNode();
            ListNode current = dummy;

           
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

    
            current.next = list1 ?? list2;

          
            return dummy.next;
        }
           
    }
    public class ListNode
    {
        public int val;
        public ListNode next;


        public ListNode(int v = 0,ListNode next =null)
        {
            this.val = v;
            this.next = next;
        }
    }
}
