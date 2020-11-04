using System;

namespace OPPP_lb1
{
    /// <summary>
    /// Обобщающий класс. Класс содержимого элемента односвязного списка
    /// </summary>
    public class Field
    {
        public int id { get; private set; }
        public string type { get; private set; }
        public int power { get; private set; }
        public string country { get; private set; }
        public int capacity_fuel { get; private set; }

        public Field(int _id, string Type, int Power, string Country, int Capacity_fuel)
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
