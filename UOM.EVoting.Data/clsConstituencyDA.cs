using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace UOM.EVoting.Data
{
    public class clsConstituencyDA
    {
        public Common.clsConstituency Read(int ConstituencyId)
        {
            Common.clsConstituency objConstituency = new Common.clsConstituency();

            try
            {
                string QueryString = @"select Id, 
                                              Name 
                                       from   Constituencies
                                       where  Id=@id";

                using (SqlConnection Connection = new SqlConnection(clsConnectionDA.ConnectionString))
                {

                    using (SqlCommand Command = Connection.CreateCommand())
                    {
                        // Load Query
                        Command.CommandText = QueryString;

                        // Pass Parameters
                        Command.Parameters.Add(new SqlParameter("@id", ConstituencyId));

                        // Open Connection
                        Connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                objConstituency.Id = (int)reader["Id"];
                                objConstituency.Name = (string)reader["Name"];
                            }
                        }

                        // Close Connection
                        Connection.Close();
                    }

                }
            }
            catch (Exception)
            {

            }

            return objConstituency;
        }

        // Read all constituencies
        public List<Common.clsConstituency> Read()
        {
            List<Common.clsConstituency> lstConstituencies = new List<Common.clsConstituency>();

            try
            {
                string QueryString = @"select * 
                                       from   Constituencies";

                using (SqlConnection Connection = new SqlConnection(clsConnectionDA.ConnectionString))
                {
                    using (SqlCommand Command = Connection.CreateCommand())
                    {
                        // Load Query
                        Command.CommandText = QueryString;

                        // Open Connection
                        Connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            // Loop Through All Records
                            while (reader.Read())
                            {
                                Common.clsConstituency objConstituency = new Common.clsConstituency();
                                objConstituency.Id = (int)reader["Id"];
                                objConstituency.Name = (string)reader["Name"];
                                lstConstituencies.Add(objConstituency);
                            }
                        }

                        // Close Connection
                        Connection.Close();
                    }
                }
            }
            catch (Exception)
            {

            }

            return lstConstituencies;
        }

    }
}
