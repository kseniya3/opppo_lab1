using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPP_lb1
{
    class Node
    {
        public Node next { get; set; }
        public Field field { get; set; }

        public Node(Field Field)
        {
            field = Field;
            next = null;
        }
    }
}
