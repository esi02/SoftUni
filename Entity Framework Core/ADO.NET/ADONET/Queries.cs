using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET
{
    public class Queries
    {
        public const string connectionString = "Server=.\\SQLEXPRESS;Database=MinionsDB;Integrated Security=true;TrustServerCertificate=true;";
        public const string getVillainNames = @"SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount  
    FROM Villains AS v 
    JOIN MinionsVillains AS mv ON v.Id = mv.VillainId 
GROUP BY v.Id, v.Name 
  HAVING COUNT(mv.VillainId) > 3 
ORDER BY COUNT(mv.VillainId)";

        public const string getVillainNameById = @"SELECT Name FROM Villains WHERE Id = @Id";

        public const string findVillainsMinions = @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) as RowNum,
                                         m.Name, 
                                         m.Age
                                    FROM MinionsVillains AS mv
                                    JOIN Minions As m ON mv.MinionId = m.Id
                                   WHERE mv.VillainId = @Id
                                ORDER BY m.Name";

        public const string getTownIdByName = "SELECT Id FROM Towns WHERE Name = @townName";

        public const string addTown = "INSERT INTO Towns (Name) VALUES (@townName)";

        public const string getVillainIdByName = "SELECT Id FROM Villains WHERE Name = @Name";

        public const string addVillain = "INSERT INTO Villains(Name, EvilnessFactorId)  VALUES(@villainName, 4)";

        public const string selectMinionByName = "SELECT Name FROM Minions";

        public const string getMinionByName = "SELECT Id FROM Minions WHERE Name = @Name";

        public const string selectVillainById = @"SELECT Name FROM Villains WHERE Id = @villainId";

        public const string updateMinionsById = @"UPDATE Minions
   SET Name = UPPER(LEFT(Name, 1)) + SUBSTRING(Name, 2, LEN(Name)), Age += 1
 WHERE Id = @Id";

        public const string deleteVillainById = @"
DELETE FROM Villains
      WHERE Id = @villainId";

        public const string deleteMinionsVillains = @"DELETE FROM MinionsVillains 
      WHERE VillainId = @villainId";

        public const string selectTownByCountryName = @"
 SELECT t.Name 
   FROM Towns as t
   JOIN Countries AS c ON c.Id = t.CountryCode
  WHERE c.Name = @countryName";

        public const string addMinionsToTheVillain = "INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)";

        public const string setTownsNameToUppercase = @"UPDATE Towns
   SET Name = UPPER(Name)
 WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName)";
    }
}
