using System;
using System.Data.SqlClient;

namespace UOM.EVoting.Data
{
    public class clsVoterDA
    {
        // Read a voter
        public Common.clsVoter Read(Common.clsLoginData objLogin)
        {
            // Declarations
            Common.clsVoter objvoter = new Common.clsVoter();

            try
            {
                // Query to read a voter
                string QueryString = string.Format(@"select Id, 
                                                            Name, 
                                                            Surname,
                                                            Login,
                                                            Password,
                                                            HasVoted,
                                                            ConstituencyId
                                                     from   Voters 
                                                     where  Login = '{0}' 
                                                     and    Password = '{1}'", objLogin.Login, objLogin.Password);

                using (SqlConnection Connection = new SqlConnection(clsConnectionDA.ConnectionString))
                {
                    using (SqlCommand Command = Connection.CreateCommand())
                    {
                        // Load Query
                        Command.CommandText = QueryString;

                        // Open connection
                        Connection.Open();

                        // Execute query
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                objvoter.Id = (int)reader["Id"];
                                objvoter.Name = (string)reader["Name"];
                                objvoter.Surname = (string)reader["Surname"];
                                objvoter.Login = (string)reader["Login"];
                                objvoter.Password = (string)reader["Password"];
                                objvoter.HasVoted = (bool)reader["HasVoted"];
                                objvoter.ConstituencyId = (int)reader["ConstituencyId"];
                            }
                        }

                    }

                    // Close connection
                    Connection.Close();
                }
            }
            catch (Exception)
            {

            }

            return objvoter;
        }

        public void Update(Common.clsVoter objVoter)
        {
            try
            {
                //Query to update a voter
                string QueryString = @"update Voters
                                       set    HasVoted = 'true'
                                       where  Id = @id";


                using(SqlConnection Connection = new SqlConnection(clsConnectionDA.ConnectionString))
                {
                    using(SqlCommand Command = Connection.CreateCommand())
                    {
                        // Load Query
                        Command.CommandText = QueryString;

                        // Pass parameters
                        Command.Parameters.Add(new SqlParameter("@id", objVoter.Id));

                        // Open connection
                        Connection.Open();

                        // Execute query
                        Command.ExecuteNonQuery();

                        // Close connection
                        Connection.Close();

                    }
                }

            }
            catch (Exception)
            {

            }
        }
    }
}
