﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDVILibDI03.Classes
{
    class ProductModel
    {
        public int ProductModelID { get; set; }
        public string Name { get; set; }
        public byte[] LargePhoto { get; set; }
        public float ListPrice { get; set; }
    }
}
