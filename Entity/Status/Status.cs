using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Status
{
    public class Status 
    {
        public Guid UID { get; set; }
        public string Text { get; set; }

        public Status() {
            UID = Guid.NewGuid();
        }
    }
}
