using System;
using System.Collections.Generic;
using System.IO;
using Globals.classes;
using Globals.Interfaces;
using Newtonsoft.Json;

namespace Data
{
    public class dataLayer : IData
    {
        public dataLayer()
        {

        }



        public List<Bet> getBets()
        {
            List<Bet> list = new List<Bet>();
            try
            {
                using (StreamReader file = File.OpenText(@"../../Data/bets.json"))
                {

                    JsonSerializer serializer = new JsonSerializer();
                    list = (List<Bet>)serializer.Deserialize(file, typeof(List<Bet>));

                }
            } catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
            return list;
        }

        public List<Game> getGames()
        {
            List<Game> list = new List<Game>();

            try
            {
                using (StreamReader file = File.OpenText(@"../../Data/games.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    list = (List<Game>)serializer.Deserialize(file, typeof(List<Game>));

                }
            } catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return list;
        }

        public List<Person> getPersons()
        {

            List<Person> list = new List<Person>();
            try { 
                using (StreamReader file = File.OpenText(@"../../Data/persons.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    list = (List<Person>)serializer.Deserialize(file, typeof(List<Person>));

                }
            } catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            return list;
        }

        public List<Ploeg> getPloegen()
        {
            List<Ploeg> list = new List<Ploeg>();
            try
            {
                using (StreamReader file = File.OpenText(@"../../Data/ploegen.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    list = (List<Ploeg>)serializer.Deserialize(file, typeof(List<Ploeg>));

                }
            } catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            return list;
        }

        public void saveBets(List<Bet> b)
        {
            using (StreamWriter file = File.CreateText(@"../../Data/bets.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, b);
            }
        }

        public void saveGames(List<Game> g)
        {
            using (StreamWriter file = File.CreateText(@"../../Data/games.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, g);
            }
        }

        public void savePersons(List<Person> p)
        {
            using (StreamWriter file = File.CreateText(@"../../Data/persons.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, p);
            }
        }

        public void savePloegen(List<Ploeg> p)
        {
            using (StreamWriter file = File.CreateText(@"../../Data/ploegen.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, p);
            }
        }
    }
}
