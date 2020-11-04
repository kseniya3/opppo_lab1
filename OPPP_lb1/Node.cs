using System;

namespace OPPP_lb1
{
    /// <summary>
    /// Класс элемента односвязного списка
    /// </summary>
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
