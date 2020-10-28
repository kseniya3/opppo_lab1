using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPP_lb1
{
    public class Field
    {
        public string capacity { get; private set; }
        public string power { get; private set; }
        public string country { get; private set; }

        public Field(string Capacity, string Power, string Country)
        {
            capacity = Capacity;
            power = Power;
            country = Country;
        }

        public virtual void Show(int idx)
        {
            
        }
    }
}
