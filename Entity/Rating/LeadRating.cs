using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Rating
{
    public class LeadRating : Rating
    {
        public int Order { get; set; }

        public override string DefaultText { get { return "Default Rating"; } }


    }
}
