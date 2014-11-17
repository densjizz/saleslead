using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Activity
{
    public class Action
    {
        public Guid UID { get; set; }
        public string Description { get; set; }
        public ActionStatus Status { get; set; }

        public Action() {
            UID = Guid.NewGuid();
        }
    }
}
