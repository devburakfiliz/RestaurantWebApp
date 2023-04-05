using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MimozaUi.Dtos.Food4Dto
{
    public class UpdateFood4Dto
    {
        public int Food4ID { get; set; }
        public string FoodName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string FoodImage { get; set; }
    }
}
