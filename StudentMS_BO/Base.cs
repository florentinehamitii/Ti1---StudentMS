﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
   public class Base
    {
        public string InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public string LUB { get; set; }
        public DateTime LUD { get; set; }
        public int LUN { get; set; }
    }
}
