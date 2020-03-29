﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace UOM.EVoting.Data
{
    public class clsCandidateDA
    {
        public List<Common.clsCandidate> Read(int ConstituencyId)
        {
            // Declarations
            List<Common.clsCandidate> lstCandidates = new List<Common.clsCandidate>();

            try
            {
                string QueryString = @"select Id,
                                              Name,
                                              Surname,
                                              ConstituencyId,
                                              Votes
                                       from   Candidates
                                       where  ConstituencyId = @id";

                using (SqlConnection Connection = new SqlConnection(clsConnectionDA.ConnectionString))
                {
                    using (SqlCommand Command = Connection.CreateCommand())
                    {
                        // Load Query
                        Command.CommandText = QueryString;

                        // Pass parameters
                        Command.Parameters.Add(new SqlParameter("@id", ConstituencyId));

                        // Open Connection
                        Connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lstCandidates.Add(new Common.clsCandidate()
                                {
                                    Id = (int)reader["Id"],
                                    Name = (string)reader["Name"],
                                    Surname = (string)reader["Surname"],
                                    ConstituencyId = (int)reader["ConstituencyId"],
                                    Votes = (int)reader["Votes"]
                                });
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

            return lstCandidates;
        }
    }
}
