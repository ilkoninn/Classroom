﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class ClassroomException:Exception
    {
        public ClassroomException(string message) : base(message) 
        {
        }
    }    
}
