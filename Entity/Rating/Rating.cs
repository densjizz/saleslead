using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Rating
{
    public class Rating
    {
        public Guid UID { get; set; }
        public string Text { get; set; }
        public virtual string DefaultText { get; private set; }

        public Rating() {
            UID = Guid.NewGuid();
            Text = DefaultText;
        }
    }
}
