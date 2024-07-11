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
        #region Attributes
        public static string Filename = "database1.db";
        public static string ConnectionString = @"Data Source = ..\..\Files\database1.db";
        public static BindingList<Gambler> Users;
        public static BindingList<Team> Teams;
        public static BindingList<Bet> Bets;
        public static BindingList<Match> Matches;
        #endregion

        #region Functions
        public static void updateConnectionString()
        {
            ConnectionString = @"Data Source = ..\..\" + Filename;
        }
        #endregion
    }
}
