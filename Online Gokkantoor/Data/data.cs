using System;
using System.Collections.Generic;
using System.IO;
using Globals.classes;
using Globals.Interfaces;
using Newtonsoft.Json;

namespace Data
{
    public class dataLayer
    {
        public dataLayer()
        {

        }

        public db getDb()
        {
            try
            {
                using (StreamReader file = File.OpenText(@"../../Data/db.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (db)serializer.Deserialize(file, typeof(db));
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void saveDb(db d)
        {
            using (StreamWriter file = File.CreateText(@"../../Data/db.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, d);
            }
        }


    }
}
