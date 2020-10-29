﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;

namespace OPPP_lb1
{
    /// <summary>
    /// Класс реализующий односвязный список
    /// </summary>
    class List
    {
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
                throw new Exception("null value");
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
        /// Функция для работы с json токеном
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        static public Field jsonfield(JToken item)
        {
            string type = "";
            try{
                type = item["type"].ToString();
            }
            catch{
                throw new Exception("wrong type");
            }

            if (type == "Truck"){

                try{
                    return new Truck(
                        item["capacity"].ToString(), 
                        item["power"].ToString(), 
                        item["country"].ToString(), 
                        Int32.Parse(item["id"].ToString())
                        );
                }
                catch{
                    throw new Exception("wrong cycle item");
                }
            }

            if (type == "Bus"){

                try{
                    return new Bus(
                        item["capacity"].ToString(),
                        item["power"].ToString(),
                        item["country"].ToString(),
                        Int32.Parse(item["id"].ToString())
                        );
                }
                catch{
                    throw new Exception("wrong cycle item");
                }
            }

            return null;
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
                //TODO: Вынести вывод информации в поле(Field)
                //TODO: Выводить имя сущности.
                Console.WriteLine(
                    "Type_Name: " +
                    "Number: " + temp + " " +
                    "Capacity: " + tempHead.field.capacity + " " +
                    "Power: " + tempHead.field.power + " " +
                    "Country: " + tempHead.field.country + " ");

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

                Field field = jsonfield(item);
                Add(field);
            }
        }
    }
}
