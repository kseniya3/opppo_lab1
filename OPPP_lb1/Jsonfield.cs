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
                    if (Int32.Parse(item["power"].ToString()) <= 0) return null;
                    if (Int32.Parse(item["capacity_lifting"].ToString()) <= 0 || Int32.Parse(item["capacity_lifting"].ToString()) >= 1000) return null;
                    if (Int32.Parse(item["capacity_fuel"].ToString()) <= 0 || Int32.Parse(item["capacity_fuel"].ToString()) >= 300) return null;

                    return new Truck(
                        Int32.Parse(item["id"].ToString()),
                        item["type"].ToString(),
                        item["power"].ToString(),
                        item["country"].ToString(),
                        item["capacity_lifting"].ToString(),
                        item["capacity_fuel"].ToString()
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
                    if (Int32.Parse(item["power"].ToString()) <= 0) return null;
                    if (Int32.Parse(item["capacity_people"].ToString()) <= 0 || Int32.Parse(item["capacity_people"].ToString()) >= 150) return null;
                    if (Int32.Parse(item["capacity_fuel"].ToString()) <= 0 || Int32.Parse(item["capacity_fuel"].ToString()) >= 150) return null;

                    return new Bus(
                        Int32.Parse(item["id"].ToString()),
                        item["type"].ToString(),
                        item["power"].ToString(),
                        item["country"].ToString(),
                        item["capacity_people"].ToString(),
                        item["capacity_fuel"].ToString()
                        );
                }
                catch
                {
                    throw new Exception("wrong cycle item");
                }
            }

            if (type == "Train")
            {
                try
                {
                    if (Int32.Parse(item["power"].ToString()) <= 0) return null;
                    if (Int32.Parse(item["capacity_people"].ToString()) <= 0 || Int32.Parse(item["capacity_people"].ToString()) >= 1000) return null;
                    if (Int32.Parse(item["capacity_fuel"].ToString()) <= 0 || Int32.Parse(item["capacity_fuel"].ToString()) >= 1000) return null;

                    return new Train(
                        Int32.Parse(item["id"].ToString()),
                        item["type"].ToString(),
                        item["power"].ToString(),
                        item["country"].ToString(),
                        item["capacity_people"].ToString(),
                        item["capacity_fuel"].ToString()
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
