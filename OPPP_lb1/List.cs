using System;
using NLog;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OPPP_lb1
{
    /// <summary>
    /// Класс реализующий односвязный список
    /// </summary>
    class List
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private Node head;
        private Node tail;
        public int count { get; private set; }

        /// <summary>
        /// Функция добавления в односвязный список
        /// </summary>
        /// <param name="value"></param>
        public void Add(Field value)
        {
            if (value == null){
                count--;

                logger.Error("The field has a null value!");
                return;
            }

            if (head == null){
                head = new Node(value);
                tail = head;
                head.next = tail;
            }
            else{
                Node newNode = new Node(value);
                tail.next = newNode;
                tail = newNode;
                tail.next = head;
            }
            count++;
        }

        /// <summary>
        /// Функция для отображения листа
        /// </summary>
        public void Show()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Count of elements: {count}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---------------------------------------");

            Node tempHead = head;

            int temp = count;
            while (temp > 0){
                tempHead.field.Show(tempHead.field.id);
                tempHead = tempHead.next;
                temp--;
            }
            Console.WriteLine("---------------------------------------");
        }

        /// <summary>
        /// Функция чтения данных из файла и парсинга в массив.
        /// </summary>
        /// <param name="path"></param>
        public void addDataFromFile(string path)
        {
            var array = JArray.Parse(File.ReadAllText(path));

            foreach (var item in array){

                Field field = Jsonfield.jsonfield(item);
                Add(field);
            }
        }

        /// <summary>
        /// Функция для сортировки.
        /// </summary>
        public void Sort()
        {
            for (int i = 0; i < count; i++)
            {
                for(int j = 0; j < count; j++)
                {
                    Node previous = getPosition(i);
                    Node next = getPosition(j);

                    int previousNum = previous.field.GetId();
                    int nextNum = next.field.GetId();
                    if (previousNum < nextNum)
                    {
                        if (previous != null && next != null)
                            (previous.field, next.field) = (next.field, previous.field);
                    }
                }
            }
        }

        /// <summary>
        /// Функция для получения позиции элемента в списке.
        /// </summary>
        public Node getPosition(int i)
        {
            if (i < count && i >= 0)
            {
                Node tempHead = head;
                for (int j = 0; j < i; j++)
                    tempHead = tempHead.next;
                return tempHead;
            }
            else return null;
        }

        /// <summary>
        /// Функция удаление объектов по типу.
        /// </summary>
        public void Remove(string type)
        {
            Node tempHead = head;
            for (int i = 0; i < count; i++)
            {
                if (tempHead.field.GetType().Name == type)
                {
                    if (i == 0)
                    {
                        Node tmp_head = head.next;
                        head = tmp_head;
                        tempHead = tempHead.next;
                    }
                    else
                    {
                        Node prev = getPosition(i - 1);
                        prev.next = tempHead.next;
                        tempHead = prev.next;
                    }
                    count--;
                    i--;
                    continue;
                }
                tempHead = tempHead.next;
            }
        }
    }
}
