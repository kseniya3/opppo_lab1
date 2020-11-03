using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace OPPP_lb1
{
    class Jsonfield
    {
        /// <summary>
        /// Функция для работы с json токеном
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        static public Field jsonfield(JToken item)
        {
            string type = "";
            try
            {
                type = item["type"].ToString();
            }
            catch
            {
                throw new Exception("wrong type");
            }

            if (type == "Truck")
            {

                try
                {
                    return new Truck(
                        item["capacity"].ToString(),
                        item["power"].ToString(),
                        item["country"].ToString(),
                        Int32.Parse(item["id"].ToString())
                        );
                }
                catch
                {
                    throw new Exception("wrong cycle item");
                }
            }

            if (type == "Bus")
            {

                try
                {
                    return new Bus(
                        item["capacity"].ToString(),
                        item["power"].ToString(),
                        item["country"].ToString(),
                        Int32.Parse(item["id"].ToString())
                        );
                }
                catch
                {
                    throw new Exception("wrong cycle item");
                }
            }

            return null;
        }
    }
}
