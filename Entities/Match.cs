using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW.Entities
{
    public class Match : BaseClass
    {
        #region Attributes
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public DateTime Date { get; set; }
        public string Winner { get; set; }
        #endregion

        #region Constructors
        public Match(string teamA, string teamB, DateTime date, string winner) : base(null)
        {
            TeamA = teamA;
            TeamB = teamB;
            Date = date;
            Winner = winner;
        }

        public Match(int id, string teamA, string teamB, DateTime date, string winner)
            : this(teamA, teamB, date, winner)
        {
            Id = id;
        }
        #endregion
    }
}
