using Entity.Interfaces;
using Entity.Modifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Notes
{
    public class Note
    {
        public Guid UID { get; set; }
        
        public string Title { get; set; }
        public string Message { get; set; }

        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }

        public ChangeStamp ModificationStamp { get; set; }
    }
}
