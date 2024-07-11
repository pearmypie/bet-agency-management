using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW.Database
{
    public static partial class Database
    {
        public static void InsertGambler(string cnp, string name, DateTime dob)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO users (cnp, name, date_of_birth) VALUES (@cnp, @name, @dob)";
                command.Parameters.AddWithValue("@cnp", cnp);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@dob", dob);
                command.ExecuteNonQuery();

                Database.LoadUsers();
            }
        }

        public static void InsertTeam(string country, string name)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO teams (country, name) VALUES (@country, @name)";
                command.Parameters.AddWithValue("@country", country);
                command.Parameters.AddWithValue("@name", name);
                command.ExecuteNonQuery();

                Database.LoadTeams();
            }
        }

        public static void InsertMatch(string team1Id, string team2Id, DateTime date)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO matches (team_a, team_b, date) VALUES (@team1Id, @team2Id, @date)";
                command.Parameters.AddWithValue("@team1Id", team1Id);
                command.Parameters.AddWithValue("@team2Id", team2Id);
                command.Parameters.AddWithValue("@date", date);
                command.ExecuteNonQuery();

                Database.LoadMatches();
            }
        }

        public static void InsertBet(int gamblerId, int matchId, double amount)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO bets (user_id, match_id, amount) VALUES (@gamblerId, @matchId, @amount)";
                command.Parameters.AddWithValue("@gamblerId", gamblerId);
                command.Parameters.AddWithValue("@matchId", matchId);
                command.Parameters.AddWithValue("@amount", amount);
                command.ExecuteNonQuery();

                Database.LoadBets();
            }
        }
    }
}
