﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.BusinessLogic.RequestHelpers
{
    public class ProductParams : PaginationParams
    {
        public string OrderBy { get; set;}
        public string SearchTerm { get; set;}
        public string Types { get; set;}
        public string Brands { get; set;}
    }
}
