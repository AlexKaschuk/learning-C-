﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
   public abstract class Emloyee
    {
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}