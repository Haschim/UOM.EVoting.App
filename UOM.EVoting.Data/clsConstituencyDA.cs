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

                        // Pass parameters
                        Command.Parameters.Add(new SqlParameter("@id", ConstituencyId));

                        Connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                objConstituency.Id = (int)reader["Id"];
                                objConstituency.Name = (string)reader["Name"];
                            }
                        }

                        // Close connection
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
            return null;
        }

    }
}
