using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BaseConnectionLibrary.ConnectionClasses;

namespace MoveBetweenListBoxes.Classes
{
    public class SqlServerOperations : SqlServerConnection
    {
        public SqlServerOperations()
        {
            DefaultCatalog = "CustomerDatabase";
            DatabaseServer = ".\\SQLEXPRESS";
        }

        public async Task<List<Customer>> CustomersList()
        {
            var list = new List<Customer>();

            using (var cn = new SqlConnection {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand {Connection = cn})
                {
                    cmd.CommandText =
                        "SELECT Identifier, CompanyName, ContactName, ContactTypeIdentifier, GenderIdentifier " + 
                        "FROM dbo.Customer;";

                    await cn.OpenAsync();

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new Customer() { Identifier = reader.GetInt32(0), CompanyName = reader.GetString(1)});
                    }
                }
            }

            return list;
        }
    }
}
