using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeVeriYapıları
{
    public class StackLinkedList
    {
        public string data;
        public StackLinkedList next;
        public StackLinkedList(string data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
