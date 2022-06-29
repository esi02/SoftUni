using Microsoft.Data.SqlClient;
using System;

namespace ADONET
{
    internal class Program : QueriesMethods
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(Queries.connectionString))
            {
                connection.Open();
                IncreaseAgeStoredProc(connection);
            }
        }


    }
}
