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
        public string Title { get; set; }
        public float Amount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
