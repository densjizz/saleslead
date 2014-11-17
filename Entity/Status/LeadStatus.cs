using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Status
{
    public class LeadStatus : Status
    {
        public int Order { get; set; }
        public override string DefaultText { get { return "Default Status"; } } 
        
    }
}
