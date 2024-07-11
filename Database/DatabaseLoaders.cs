using Microsoft.Data.Sqlite;
using PAW.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW.Database
{
    public static partial class Database
    {
        public static void LoadUsers()
        {
            Database.Users = new BindingList<Gambler>();
            const string query = "SELECT * FROM users";

            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // mind the order
                            var user = new Gambler(reader.GetInt32(0), reader.GetString(2), reader.GetString(1), reader.GetDateTime(3));
                            Users.Add(user);
                        }
                    }
                }

                conn.Close();
            }
        }

        public static void LoadTeams()
        {
            Database.Teams = new BindingList<Team>();
            const string query = "SELECT * FROM teams";

            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // mind the order
                            var team = new Team(reader.GetInt32(0), reader.GetString(2), reader.GetString(1));
                            Teams.Add(team);
                        }
                    }
                }

                conn.Close();
            }
        }

        public static void LoadMatches()
        {
            Database.Matches = new BindingList<Match>();
            var query = "SELECT * FROM matches";

            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var match = new Match(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4));
                            Matches.Add(match);
                        }
                    }
                }

                conn.Close();
            }
        }

        public static void LoadBets()
        {
            Database.Bets = new BindingList<Bet>();
            var query = "SELECT * FROM bets";

            using (SqliteConnection conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var bet = new Bet(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetDouble(3), reader.GetString(4));
                            Bets.Add(bet);
                        }
                    }
                }
            }
        }

        public static void LoadDatabase()
        {
            try
            {
                LoadUsers();
                LoadTeams();
                LoadMatches();
                LoadBets();
            }
            catch (SqliteException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
