using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET 
{
    public class QueriesMethods
    {
        //Problem 1
        public static void GetVillainNames(SqlConnection connection)
        {
            var command = new SqlCommand(Queries.getVillainNames, connection);
            var result = command.ExecuteReader();
            while (result.Read())
            {
                Console.WriteLine($"{result[0]} - {result[1]}");
            }
        }

        //Problem 2
        public static void GetMinionNamesAndVillain(SqlConnection connection)
        {
            var villainId = int.Parse(Console.ReadLine());

            var villainCommand = new SqlCommand(Queries.getVillainNameById, connection);
            villainCommand.Parameters.AddWithValue("@Id", villainId);
            var villainName = villainCommand.ExecuteScalar();

            if (villainName == null)
            {
                Console.WriteLine($"No villain with ID {villainId} exists in the database.");
                return;
            }

            var minionsCommand = new SqlCommand(Queries.findVillainsMinions, connection);
            minionsCommand.Parameters.AddWithValue("@Id", villainId);
            var minionsResult = minionsCommand.ExecuteReader();

            Console.WriteLine($"Villain: {villainName}");
            if (minionsResult == null)
            {
                Console.WriteLine("(no minions)");
            }
            else
            {
                while (minionsResult.Read())
                {
                    Console.WriteLine($"{minionsResult["RowNum"]}. {minionsResult["Name"]} {minionsResult["Age"]}");
                }

            }
        }

        //Problem 3
        public static void AddMinion(SqlConnection connection)
        {
            var minionInfo = Console.ReadLine();
            var villainName = Console.ReadLine();

            var minionName = minionInfo.Split(" ")[0];
            var minionAge = minionInfo.Split(" ")[1];
            var minionTown = minionInfo.Split(" ")[2];

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = Queries.getTownIdByName;
            command.Parameters.AddWithValue("@townName", minionTown);
            var ifTownExists = command.ExecuteScalar();

            if (ifTownExists == null)
            {
                command.Parameters.Clear();
                command.CommandText = Queries.addTown;
                command.Parameters.AddWithValue("@townName", minionTown);

                try
                {
                    var rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"Town {minionTown} was added to the database.");
                }
                catch (Exception er)
                {
                    Console.WriteLine(er.Message);
                }
            }

            command.Parameters.Clear();
            command.CommandText = Queries.getVillainIdByName;
            command.Parameters.AddWithValue("@Name", villainName);
            var ifVillainExists = command.ExecuteScalar();

            if (ifVillainExists == null)
            {
                command.CommandText = Queries.addVillain;
                command.Parameters.AddWithValue("@villainName", villainName);

                try
                {
                    var rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"Villain {villainName} was added to the database.");
                }
                catch (Exception er)
                {
                    Console.WriteLine(er.Message);
                }
            }

            command.Parameters.Clear();
            command.CommandText = Queries.getMinionByName;
            command.Parameters.AddWithValue("@Name", minionName);
            var minionId = command.ExecuteScalar();

            command.Parameters.Clear();
            command.CommandText = Queries.addMinionsToTheVillain;
            command.Parameters.AddWithValue("@villainId", (int)ifVillainExists);
            command.Parameters.AddWithValue("@minionId", minionId);

            try
            {
                var rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
        }

        //Problem 5
        public static void ChangeTownNamesCasing(SqlConnection connection)
        {
            string country = Console.ReadLine();
            var updateCommand = new SqlCommand(Queries.setTownsNameToUppercase, connection);

            var selectCommand = new SqlCommand(Queries.selectTownByCountryName, connection);

            updateCommand.Parameters.AddWithValue("@countryName", country);
            selectCommand.Parameters.AddWithValue("@countryName", country);

            var result = updateCommand.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine($"{result} town names were affected.");
                var townsResult = selectCommand.ExecuteReader();
                List<string> townNames = new List<string>();

                while (townsResult.Read())
                {
                    townNames.Add((string)townsResult["Name"]);
                }

                var joined = String.Join(", ", townNames);
                Console.WriteLine($"[{joined}]");
            }
            else
            {
                Console.WriteLine("No town names were affected.");
            }

        }

        //Problem 6
        public static void RemoveVillain(SqlConnection connection)
        {
            int villainId = int.Parse(Console.ReadLine());
            string deleteMinionsVillain = Queries.deleteMinionsVillains;
            string searchVillain = Queries.selectVillainById;
            string deleteVillain = Queries.deleteVillainById;

            SqlCommand searchVillainCommand = new SqlCommand(searchVillain, connection);
            SqlCommand deleteFromMinions = new SqlCommand(deleteMinionsVillain, connection);
            SqlCommand deleteVillainCommand = new SqlCommand(deleteVillain, connection);

            searchVillainCommand.Parameters.AddWithValue("@villainId", villainId);
            deleteFromMinions.Parameters.AddWithValue("@villainId", villainId);
            deleteVillainCommand.Parameters.AddWithValue("@villainId", villainId);

            var ifVillainExists = searchVillainCommand.ExecuteScalar();

            if (ifVillainExists == null)
            {
                Console.WriteLine("No such villain was found.");
            }
            else
            {
                int minionsDeleted = deleteFromMinions.ExecuteNonQuery();
                deleteVillainCommand.ExecuteNonQuery();
                Console.WriteLine($"{(string)ifVillainExists} was deleted.");
                Console.WriteLine($"{minionsDeleted} minions were released.");
            }
        }

        //Problem 7
        public static void PrintAllMinionNames(SqlConnection connection)
        {
            string searchQuery = Queries.selectMinionByName;
            SqlCommand searchMinionsCommand = new SqlCommand(searchQuery, connection);

            var result = searchMinionsCommand.ExecuteReader();
            List<string> minionsNames = new List<string>();

            while (result.Read())
            {
                minionsNames.Add((string)result[0]);
            }

            var leftList = minionsNames.Take(minionsNames.Count / 2).ToList();
            var rightList = (minionsNames.Skip(leftList.Count)).Reverse().ToList();

            List<string> newList = new List<string>();
            int biggerCount = Math.Max(leftList.Count, rightList.Count);

            for (int i = 0; i < biggerCount; i++)
            {
                if (i >= leftList.Count)
                {
                    newList.Add(rightList[i]);
                }
                else if (i >= rightList.Count)
                {
                    newList.Add(leftList[i]);
                }
                else
                {
                    newList.Add(leftList[i]);
                    newList.Add(rightList[i]);
                }
            }
            Console.WriteLine(String.Join(", ", minionsNames));
            Console.WriteLine(String.Join(", ", leftList));
            Console.WriteLine(String.Join(", ", rightList));
            Console.WriteLine(String.Join(", ", newList));
        }

        //Problem 8
        public static void IncreaseMinionAge(SqlConnection connection)
        {
            int[] minionIds = Console.ReadLine().Split(" ", StringSplitOptions.TrimEntries).Select(x => int.Parse(x)).ToArray();
            string updateQuery = Queries.updateMinionsById;
            string searchQuery = @"SELECT Name, Age FROM Minions";

            foreach (var id in minionIds)
            {
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }

            SqlCommand searchCommand = new SqlCommand(searchQuery, connection);
            var result = searchCommand.ExecuteReader();

            while (result.Read())
            {
                Console.WriteLine($"{result["Name"]} {result["Age"]}");
            }
        }
        //Problem 9
        public static void IncreaseAgeStoredProc(SqlConnection connection)
        {
            int minionId = int.Parse(Console.ReadLine());
            string procedQuery = $"EXEC usp_GetOlder {minionId}";
            string searchQuery = $"SELECT Name, Age FROM Minions WHERE Id = @Id";

            SqlCommand updateCommand = new SqlCommand(procedQuery, connection);
            SqlCommand searchCommand = new SqlCommand(searchQuery, connection);
            searchCommand.Parameters.AddWithValue("@Id", minionId);

            updateCommand.ExecuteNonQuery();
            var result = searchCommand.ExecuteReader();

            while (result.Read())
            {
                Console.WriteLine($"{result["Name"]} - {result["Age"]} years old");
            }
        }
    }
}

