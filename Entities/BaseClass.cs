using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW.Entities
{
    public abstract class BaseClass
    {
        #region Attributes
        public int? Id { get; set; }
        public string NameOrDescription { get; set; }
        #endregion

        public BaseClass(string nameOrDesc)
        {
            NameOrDescription = nameOrDesc;
        }

        public BaseClass(int id, string nameOrDesc) : this (nameOrDesc)
        {
            Id = id;
        }
    }
}
