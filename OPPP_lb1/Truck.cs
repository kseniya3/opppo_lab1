using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPP_lb1
{
    class Truck : Field
    {
        public int num { get; private set; }

        public Truck(string capacity, string power, string country, int Num) : base(capacity, power, country)
        {
            num = Num;
        }
        public override void Show(int id)
        {
           
        }
    }
}
