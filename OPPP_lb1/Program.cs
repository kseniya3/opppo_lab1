using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPP_lb1
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            try
            {
                List _list = new List();

                _list.addDataFromFile("C:/Users/Kozlo/source/repos/OPPP_lb1/OPPP_lb1/Object.json");
                //_list.addDataFromFile(args[0]);
                _list.Show();

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Сортировка по id");
                Console.WriteLine("---------------------------------------");

                _list.Sort();
                _list.Show();

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Удаление всех объектов определенного типа");
                Console.WriteLine("---------------------------------------");

                _list.Remove("Truck");
                _list.Show();

                Console.WriteLine("To EXIT -> click Enter");
                Console.ReadLine();
            }
            catch (Exception exeption)
            {
                logger.Error(exeption, "Application launch error!");
            }
            LogManager.Flush();
        }
    }
}
