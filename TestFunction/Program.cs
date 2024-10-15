public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = null;
        ListNode l1CurNode = l1;
        ListNode l2CurNode = l2;

        bool isl1Tail = false, isl2Tail = false;
        int sum = 0;
        int addition = 0;

        while (!isl1Tail || !isl2Tail)
        {

            if (!isl1Tail && !isl2Tail)
            {
                if (addition > 0)
                {
                    sum = l1CurNode.val + l2CurNode.val + addition;
                }
                else
                {
                    sum = l1CurNode.val + l2CurNode.val;
                }

                if (sum >= 10)
                {
                    sum -= 10;
                    addition = 1;
                }
                else
                {
                    addition = 0;
                }
            }

            if (isl1Tail && !isl2Tail)
            {
                if (addition > 0)
                {
                    sum = l2CurNode.val + addition;
                }
                else
                {
                    sum = l2CurNode.val;
                }

                if (sum >= 10)
                {
                    sum -= 10;
                    addition = 1;
                }
                else
                {
                    addition = 0;
                }
            }

            if (!isl1Tail && isl2Tail)
            {
                if (addition > 0)
                {
                    sum = l1CurNode.val + addition;
                }
                else
                {
                    sum = l1CurNode.val;
                }

                if (sum >= 10)
                {
                    sum -= 10;
                    addition = 1;
                }
                else
                {
                    addition = 0;
                }
            }

            if (result == null)
            {
                result = new ListNode(sum);
            }
            else
            {
                ListNode newNode = new ListNode(sum, result);
                result = newNode;
            }

            if (l1CurNode.next == null)
            {
                isl1Tail = true;
            }
            else
            {
                l1CurNode = l1CurNode.next;
            }

            if (l2CurNode.next == null)
            {
                isl2Tail = true;
            }
            else
            {
                l2CurNode = l2CurNode.next;
            }

            if (isl1Tail && isl2Tail)
            {
                if (addition > 0)
                {
                    ListNode newNode = new ListNode(addition, result);
                    result = newNode;
                }
            }

        };

        return result;  
    }

    public static ListNode Reverse(ListNode l)
    {
        ListNode temp = null, prevNode = null;

        while (l != null)
        {
            temp = l.next;
            l.next = prevNode;
            prevNode = l;
            l = temp;
        }

        return prevNode;
    }

    public static void Main(string[] args)
    {
        ListNode l1 = new ListNode(4, new ListNode(7));
        ListNode l2 = new ListNode(6, new ListNode(8));

        ListNode l3 = AddTwoNumbers(l1, l2);

        ListNode l4 = Reverse(l3);

        Console.WriteLine("Oke");
    }
}


