﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto : IDto
    {

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public string ProductName { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }

    }
}
