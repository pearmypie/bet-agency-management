
using Microsoft.Data.Sqlite;
using PAW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW.Database
{
    public static partial class Database
    {
        // UPDATE
        public static void UpdateUser(int id, string cnp, string name, DateTime dob)
        {
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE users SET cnp = @cnp, name = @name, date_of_birth = @dob WHERE id = @id";
                cmd.Parameters.AddWithValue("@cnp", cnp);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                Database.LoadUsers();
            }
        }

        public static void UpdateTeam(int id, string country, string name)
        {
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE teams SET country = @country, name = @name WHERE id = @id";
                cmd.Parameters.AddWithValue("@country", country);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                Database.LoadTeams();
            }
        }

        public static void UpdateMatch(int id, string team1Id, string team2Id, DateTime date)
        {
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE matches SET team_a = @team1Id, team_b = @team2Id, date = @date WHERE id = @id";
                cmd.Parameters.AddWithValue("@team1Id", team1Id);
                cmd.Parameters.AddWithValue("@team2Id", team2Id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                Database.LoadMatches();
            }
        }

        public static void UpdateBet(int id, int gamblerId, int matchId, double amount)
        {
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE bets SET user_id = @gamblerId, match_id = @matchId, amount = @amount WHERE id = @id";
                cmd.Parameters.AddWithValue("@gamblerId", gamblerId);
                cmd.Parameters.AddWithValue("@matchId", matchId);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                Database.LoadBets();
            }
        }

        // DELETE
        public static void DeleteUser(int id)
        {
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM users WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                Database.LoadUsers();
            }
        }

        public static void DeleteTeam(int id)
        {
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM teams WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                Database.LoadTeams();
            }
        }

        public static void DeleteMatch(int id)
        {
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM matches WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                Database.LoadMatches();
            }
        }

        public static void DeleteBet(int id)
        {
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM bets WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                Database.LoadBets();
            }
        }
    }
}
