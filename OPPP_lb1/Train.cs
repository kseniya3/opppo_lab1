using System;

namespace OPPP_lb1
{
    class Train: Field
    {
        public int capacity_people { get; private set; }

        public Train(int id, string type, int power, string country, int capacity_fuel, int Capacity_people) 
            : base(id, type, power, country, capacity_fuel)
        {
            capacity_people = Capacity_people;
        }
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
