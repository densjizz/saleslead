using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saleslead_Contract.Lead
{
    public class CreateLeadRequest : LeadRequest
    {

        public string Title { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public float Amount { get; set; }
    }
}
