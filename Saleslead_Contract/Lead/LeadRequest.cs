using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saleslead_Contract.Lead
{
    public class LeadRequest : Request.Request
    {
        public Guid UID { get; set; }

    }
}
