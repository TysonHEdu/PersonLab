using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLab
{
    internal class Relation
    {
        public string RelationshipType
        { get
            {
                return this.RelationshipType;
            }
          set
            {
                if ((value == "Sister" || value == "Brother" || value == "Mother" || value == "Father")) ;
            }
        }
    }
}
