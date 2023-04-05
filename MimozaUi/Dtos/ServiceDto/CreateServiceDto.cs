using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MimozaUi.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        public string ServiceTitle { get; set; }
        public string Description { get; set; }
        public string ServiceIcon { get; set; }
    }
}
