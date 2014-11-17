using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Collaboration
{
    public class User
    {
        public string LoginName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { 
            get {
                return FirstName + " " + LastName;
            } 
        }
    }
}
