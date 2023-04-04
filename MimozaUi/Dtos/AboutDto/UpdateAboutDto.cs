using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MimozaUi.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        public int AboutID { get; set; }

        public string TitleOne { get; set; }
        public string TitleTwo { get; set; }
        public string TitleThree { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
