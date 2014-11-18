using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Modifications
{
    public class ChangeStamp
    {
        public string By { get; set; }
        public DateTime Date { get; set; }

        public ChangeStamp() {
            By = "";
            Date = DateTime.MinValue;
        }

        public ChangeStamp(string byUser)
        {
            By = byUser;
            Date = DateTime.Now;
        }


        public void Update(string by, DateTime time)
        {
            By = by;
            Date = time;
        }
    }
}
