using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saleslead_Contract.Lead
{
    public class LeadLibraryResponse : Response.Response
    {
        public List<LeadResponse> leads { get; set; }


        public LeadLibraryResponse() {
            leads = new List<LeadResponse>();
        }
    }
}
