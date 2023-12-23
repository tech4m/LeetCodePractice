namespace ClassLibrary1
{
    public class Node431
    {
        public int val;
        public Node prev;
        public Node next;
        public Node child;
    }
    public class Problem431
    {
        public Node flatten(Node head)
        {
            if (head == null) return head;
            // Pointer
            Node p = head;
            Console.WriteLine(p.val);
            while (p != null)
            {
                /* CASE 1: if no child, proceed */
                if (p.child == null)
                {
                    p = p.next;
                    Console.WriteLine(p.val);
                    continue;
                }
                /* CASE 2: got child, find the tail of the child and link it to p.next */
                Node temp = p.child;
                // Find the tail of the child
                while (temp.next != null)
                {
                    temp = temp.next;
                    Console.WriteLine(p.val);
                }
                // Connect tail with p.next, if it is not null
                temp.next = p.next;
                if (p.next != null)
                {
                    p.next.prev = temp;
                }
                // Connect p with p.child, and remove p.child
                p.next = p.child;
                p.child.prev = p;
                p.child = null;
                Console.WriteLine(p.val);
            }
            return head;
        }
    }
}
