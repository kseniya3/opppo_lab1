using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPP_lb1
{
    /// <summary>
    /// Обобщающий класс. Класс содержимого элемента односвязного списка
    /// </summary>
    public class Field
    {
        public int id { get; private set; }
        public string type { get; private set; }
        public string power { get; private set; }
        public string country { get; private set; }
        public string capacity_fuel { get; private set; }

        public Field(int _id, string Type, string Power, string Country, string Capacity_fuel)
        {
            id = _id;
            type = Type;
            power = Power;
            country = Country;
            capacity_fuel = Capacity_fuel;
        }

        /// <summary>
        /// Функция для отображения.
        /// </summary>
        public virtual void Show(int id)
        {

        }
        /// <summary>
        /// Функция для получения id.
        /// </summary>
        public virtual int GetId()
        {
            return id;
        }
    }
}
