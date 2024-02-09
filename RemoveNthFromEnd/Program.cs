﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNthFromEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
            {
                return null;
            }

            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode first = dummy;
            ListNode second = dummy;

            for (int i = 0; i <= n; i++)
            {
                second = second.next;
            }
            while (second != null)
            {
                first = first.next;
                second = second.next;
            }
            first.next = first.next.next;

            return dummy.next;
        }
    }

}
