using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBRIGHT_ASSIGNMENT_6_1
{
    internal class Node
    {
        public House Data { get; set; }
        public Node Next { get; set; }

        public Node(House data)
        {
            Data = data;
            Next = null;
        }
    }
}
