using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPP_lb1
{
    class Program
    {
        static void Main(string[] args)
        {

            List _list = new List();

            //TODO: Нужно аргументом args принимать файл(путь) и с ним работать
            _list.addDataFromFile("C:/Users/Kozlo/source/repos/OPPP_lb1/OPPP_lb1/Object.json");

            _list.Show();


            Console.WriteLine("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF");

            //_list.Sort();
            //_list.Show();

            Console.WriteLine("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF");
            _list.Remove("Truck");
            _list.Show();

            Console.WriteLine("To EXIT -> click Enter");
            Console.ReadLine();
        }
    }
}
