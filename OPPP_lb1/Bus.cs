using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPP_lb1
{
    /// <summary>
    /// Наследуемый класс -> Автобус
    /// </summary>
    class Bus : Field
    {
        public int capacity_people { get; private set; }

        public Bus(int id, string type, int power, string country, int capacity_fuel, int Capacity_people) 
            : base(id, type, power, country, capacity_fuel)
        {
            capacity_people = Capacity_people;
        }

        /// <summary>
        /// Функция для отображения.
        /// </summary>
        /// /// <param name="id"></param>
        public override void Show(int id)
        {
            Console.WriteLine(
                    "id: " + id + " " +
                    "Type_Name: " + type + " " +
                    "Power: " + power + " " +
                    "Country: " + country + " " +
                    "Capacity people: " + capacity_people + " " +
                    "Capacity fuel: " + capacity_fuel + " ");
        }
    }
}
