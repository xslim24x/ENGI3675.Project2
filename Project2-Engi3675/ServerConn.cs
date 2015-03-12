using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;

namespace AnimalData
{
    public class Animal
    {
        public string AnimalBreed;
        public double AnimalAge;
        public double AnimalWeight;

    }
    public static class ServerConn
    {
             public static Dictionary<int, Animal> DataDict()
             {
             //Lists to hold the values in the DB
             //List<int> Serial_Number = new List<int>();
             //List<string> Breed = new List<string>();
             //List<double> Weight = new List<double>();
             //List<double> Age = new List<double>();

            // create the dictionary accoring to values in the database
            Dictionary<int, Animal> items = new Dictionary<int, Animal>();

            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=ENGI3675.Proj2; Integrated Security=true;");

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"Animals\"", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                Animal temp = new Animal();
                Dictionary<int, Animal> temp2 = new Dictionary<int, Animal>();
                // iterate through the columns and add results to the dictionary
                while (dr.Read())
                {
                    
                    temp.AnimalBreed =  (string)dr["Breed"];
                    temp.AnimalAge = (double) dr["Age"];
                    temp.AnimalWeight = (double) dr["Weight"];
                    temp2.Add((int) dr["Serial_Number"], temp);
                    
                }
            }
            finally
            {
                conn.Close();
            }

            return items;
        }
    }


}
 