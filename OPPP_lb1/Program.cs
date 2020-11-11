using NLog;
using System;
using System.Diagnostics;
using System.Threading;

namespace OPPP_lb1
{
    /// <summary>
    /// Main
    /// </summary>
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();

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

                _list.Remove(_list.RemovdParam("11"));
               // _list.Remove("Truck");
                _list.Show();

                stopwatch.Stop();

                Console.WriteLine("Время(миллисекунды): " + stopwatch.ElapsedMilliseconds);

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
