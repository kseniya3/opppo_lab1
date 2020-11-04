using System;
using NLog;
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
        private static Logger logger = LogManager.GetCurrentClassLogger();

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
                logger.Error("Input data is of the wrong type!");
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
                        Int32.Parse(item["power"].ToString()),
                        item["country"].ToString(),
                        Int32.Parse(item["capacity_lifting"].ToString()),
                        Int32.Parse(item["capacity_fuel"].ToString())
                        );
                }
                catch
                {
                    logger.Error("Input data Truck is off the wrong type!");
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
                        Int32.Parse(item["power"].ToString()),
                        item["country"].ToString(),
                        Int32.Parse(item["capacity_people"].ToString()),
                        Int32.Parse(item["capacity_fuel"].ToString())
                        );
                }
                catch
                {
                    logger.Error("Input data Bus is off the wrong type!");
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
                        Int32.Parse(item["power"].ToString()),
                        item["country"].ToString(),
                        Int32.Parse(item["capacity_people"].ToString()),
                        Int32.Parse(item["capacity_fuel"].ToString())
                        );
                }
                catch
                {
                    logger.Error("Input data Train is off the wrong type!");
                }
            }

            return null;
        }

    }
}
