using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Interfaces
{
    public interface ICreatable
    {
        string CreateBy { get; set; }
        DateTime CreateDate { get; set; }
    }
}
