﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Interfaces
{
    public interface IModifiable
    {
        string ModifiedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        
    }
}
