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
    public class Food2Controller : ControllerBase
    {
        private readonly IFood2Service _Food2Service;

        public Food2Controller(IFood2Service food2Service)
        {
            _Food2Service = food2Service;
        }

        [HttpGet]
        public IActionResult Food2List()
        {
            var values = _Food2Service.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddFood2(Food2 Food2)
        {
            _Food2Service.TInsert(Food2);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFood2(int id)
        {
            var values = _Food2Service.TGetById(id);
            _Food2Service.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateFood2(Food2 Food2)
        {
            _Food2Service.TUpdate(Food2);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetFood2(int id)
        {
            var values = _Food2Service.TGetById(id);

            return Ok(values);
        }
    }
}
