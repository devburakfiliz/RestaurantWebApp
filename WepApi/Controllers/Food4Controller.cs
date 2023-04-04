using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Food4Controller : ControllerBase
    {
        private readonly IFood4Service _Food4Service;

        public Food4Controller(IFood4Service food4Service)
        {
            _Food4Service = food4Service;
        }

        [HttpGet]
        public IActionResult Food4List()
        {
            var values = _Food4Service.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddFood4(Food4 Food4)
        {
            _Food4Service.TInsert(Food4);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFood4(int id)
        {
            var values = _Food4Service.TGetById(id);
            _Food4Service.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateFood4(Food4 Food4)
        {
            _Food4Service.TUpdate(Food4);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetFood4(int id)
        {
            var values = _Food4Service.TGetById(id);

            return Ok(values);
        }
    }
}
