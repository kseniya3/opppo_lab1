﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPP_lb1
{
    class Train: Field
    {
        public string capacity_people { get; private set; }

        public Train(int id, string type, string power, string country, string capacity_fuel, string Capacity_people) 
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