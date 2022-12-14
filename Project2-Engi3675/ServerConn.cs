namespace AnimalData
{
    using System.Collections.Generic;
    using Npgsql;

    public static class ServerConn
    {
        /// <summary>
        /// Create in CRUD interface
        /// </summary>
        /// <param name="a">AnimalClass to be added</param>
        /// <returns>0 if everything went ok</returns>
        public static int DataNew(Animal a)
        {
            int problems = 0;

            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=LU.ENGI3675.Proj2; Integrated Security=true;");

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO public.\"animals\"(Breed,Weight,Age) VALUES (:a.AnimalBreed,:a.AnimalWeight,:a.AnimalAge);", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
            }
            catch
            {
                problems = -1;
            }
            finally
            {
                conn.Close();
            }

            return problems;
        }

        /// <summary>
        /// Read Database in CRUD interface
        /// </summary>
        /// <returns>Dictionary<int,AnimalClass></returns>
        public static Dictionary<int, Animal> DataDict()
        {
            Dictionary<int, Animal> temp2 = new Dictionary<int, Animal>();
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=LU.ENGI3675.Proj2; Integrated Security=true;");

            try
            {
                conn.Open();
                Animal temp = new Animal();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"animals\"", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                // iterate through the columns and add results to the dictionary
                while (dr.Read())
                {
                    temp.AnimalBreed = (string)dr["Breed"];
                    temp.AnimalAge = (float)dr["Age"];
                    temp.AnimalWeight = (float)dr["Weight"];
                    temp2.Add((int)dr["Serial_Number"], temp);
                }
            }
            finally
            {
                conn.Close();
            }

            return temp2;
        }

        /// <summary
        /// Update Entry in Database for CRUD interface
        /// </summary>
        /// <param name="id">int [Serial ID]</param>
        /// <param name="a">Animal[Updated Values]</param>
        /// <returns>0 if everythign went ok</returns>
        public static int DataUpdate(int id, Animal a)
        {
            int problems = 0;

            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=LU.ENGI3675.Proj2; Integrated Security=true;");

            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE public.\"animals\"(Breed,Weight,Age) VALUES (:a.AnimalBreed,:a.AnimalWeight,:a.AnimalAge) WHERE Serial_Number = :id;", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
            }
            catch
            {
                problems = -1;
            }
            finally
            {
                conn.Close();
            }

            return problems;
        }

        /// <summary>
        /// Delete Entry in Database for CRUD interface
        /// </summary>
        /// <param name="id">serial id to be deleted</param>
        /// <returns>0 if everything went ok</returns>
        public static int DataDel(int id)
        {
            int problems = 0;

            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=LU.ENGI3675.Proj2; Integrated Security=true;");

            try
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM public.\"animals\" WHERE Serial_Number = :id;", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
            }
            catch
            {
                problems = -1;
            }
            finally
            {
                conn.Close();
            }

            return problems;
        }
    }

    public class Animal
    {
        public string AnimalBreed;
        public float AnimalAge;
        public float AnimalWeight;
    }
}
