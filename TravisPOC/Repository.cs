using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace TravisPOC
{
    public class Repository
    {
        public bool FetchUserByName(string name)
        {
            const string connectionString = "Server=localhost;Database=travisPoc;Uid=root;";
            using (var connection = new MySqlConnection(connectionString))
            {
                var command = new MySqlCommand(String.Format("Select * from Users where Name = {0}", name), connection);
                connection.Open();

                var ds = new DataSet("set");
                var da = new MySqlDataAdapter(command);

                da.Fill(ds);
                if (ds.Tables[0] != null && ds.Tables[0].Rows.Count == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
