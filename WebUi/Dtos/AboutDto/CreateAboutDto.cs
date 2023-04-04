using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUi.Dtos.AboutDto
{
    public class CreateAboutDto
    {
        public string TitleOne { get; set; }
        public string TitleTwo { get; set; }
        public string TitleThree { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
