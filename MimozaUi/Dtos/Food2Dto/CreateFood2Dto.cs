﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MimozaUi.Dtos.Food2Dto
{
    public class CreateFood2Dto
    {
        public string FoodName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string FoodImage { get; set; }
    }
}
