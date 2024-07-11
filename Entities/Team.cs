using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW.Entities
{
    public class Team : BaseClass
    {
        #region Attributes
        public string Country { get; set; }
        #endregion

        #region Constructors
        public Team(string country, string name) : base(name)
        {
            Country = country;
        }

        public Team(int id, string country, string name)
            : this(country, name)
        {
            Id = id;
        }
        #endregion

        #region Methods
        #endregion
    }
}
