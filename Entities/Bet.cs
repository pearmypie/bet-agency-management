using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW.Entities
{
    public class Bet : BaseClass
    {
        #region Attributes
        public int MatchId { get; set; }
        public int GamblerId { get; set; }
        public double Amount { get; set; }
        public string Result { get; set; }
        #endregion

        #region Constructors
        public Bet(int matchId, int gamblerId, double amount, string result) : base(null)
        {
            MatchId = matchId;
            GamblerId = gamblerId;
            Amount = amount;
            Result = result;
        }

        public Bet(int id, int matchId, int gamblerId, double amount, string result)
            : this(matchId, gamblerId, amount, result)
        {
            Id = id;
        }
        #endregion
    }
}
