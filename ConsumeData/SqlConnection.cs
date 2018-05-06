using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsumeData
{
    public class SqlConnectionBuilder
    {
        public void ConnectionStringBuilder()
        {
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = @"(localdb)\v11.0";
            sqlConnectionStringBuilder.InitialCatalog = "ProgrammingInCSharp";
            string connectionString = sqlConnectionStringBuilder.ToString();
        }

        public async Task SelectDataFromTable()
        {
            string connectionString = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE People SET FirstName =’John’",
                connection);
                await connection.OpenAsync();
                int numberOfUpdatedRows = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Updated { 0}rows", numberOfUpdatedRows);
            }
        }

        public void Transaction()
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(""))
                {
                    connection.Open();
                    SqlCommand command1 = new SqlCommand("INSERT INTO People([FirstName], [LastName], [MiddleInitial]) VALUES('John', ‘Doe’, null)",connection);
                    SqlCommand command2 = new SqlCommand("INSERT INTO People([FirstName], [LastName], [MiddleInitial]) VALUES(‘Jane’, ‘Doe’, null)",connection);
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                }
                transactionScope.Complete();
            }
        }
    }

}
