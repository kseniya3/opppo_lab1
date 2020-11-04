using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPP_lb1
{
    /// <summary>
    /// Наследуемый класс -> Транспорт
    /// </summary>
    class Truck : Field
    {
        public string capacity_lifting { get; private set; }

        public Truck(int id, string type, string power, string country, string capacity_fuel, string Capacity_lifting) 
            : base(id, type, power, country, capacity_fuel)
        {
            capacity_lifting = Capacity_lifting;
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
                    "Capacity lifting: " + capacity_lifting + " " +
                    "Capacity fuel: " + capacity_fuel + " ");
        }
    }
}
