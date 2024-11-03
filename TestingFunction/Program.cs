/*Given 2 link list find the intersection point*/

public class Node
{
    public int value;
    public Node next;

    public Node(int value = 0, Node next = null)
    {
        this.value = value;
        this.next = next;
    }
}

class Test
{

    public static void FindIntersection(Node listA, Node listB)
    {
        Node headA = listA;
        Node headB = listB;

        if(headA == null || headB == null)
        {
            Console.WriteLine("No Intersection");
            return;
        }

        while(headA.value != headB.value)
        {
            headA = headA.next;
            headB = headB.next;
        }

        Console.WriteLine(headB.value);
    }

    public static void Main(string[] args)
    {
        Node listA = new Node(1, new Node(3, new Node(5, new Node(7))));
        Node listB = new Node(9, new Node(7, new Node(6, new Node(3))));

        FindIntersection(listA, listB);
    }
}
