using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeVeriYapıları
{
    public class Stack
    {
     StackLinkedList top;

        public Stack()
        {
            top = null;

        }
        public StackLinkedList GetNode(string data)
        {
            StackLinkedList node = new StackLinkedList(data);
            return node;
        }
        public void Push(string data)
        {
            StackLinkedList newNode = GetNode(data);
            if (top == null)
            {
                top = newNode;
                return;
            }
            newNode.next = top;
            top = newNode;

        }
        public int Peek()
        {
            if (top != null)
            {
                return Convert.ToInt32(top.data);
            }
            return -1;
        }
        public object Pop()
        {
            object peek = -1;
            if (top != null)
            {
                peek = top.data;
                top = top.next;
            }
            return peek;
        }
        public string DisplayElements()
        {
            string temp = "";
            StackLinkedList item = top;
            while (item != null)
            {
                temp += "-->" + item.data;
                item = item.next;
            }



            return temp;
        }
    }
}

