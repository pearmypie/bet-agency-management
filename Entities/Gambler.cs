using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW.Entities
{
    public class Gambler : BaseClass
    {
        #region Attributes
        public string CNP { get; set; }
        public DateTime DOB { get; set; }
        #endregion

        #region Constructors
        public Gambler(string cnp, string name, DateTime dob) : base(name)
        {
            CNP = cnp;
            DOB = dob;
        }

        public Gambler(int id, string cnp, string name, DateTime dob)
            : this(cnp, name, dob)
        {
            Id = id;
        }
        #endregion

        #region Methods

        #endregion
    }
}
