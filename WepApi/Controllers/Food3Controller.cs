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
    public class Food3Controller : ControllerBase
    {
        private readonly IFood3Service _Food3Service;

        public Food3Controller(IFood3Service food3Service)
        {
            _Food3Service = food3Service;
        }

        [HttpGet]
        public IActionResult Food3List()
        {
            var values = _Food3Service.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddFood3(Food3 Food3)
        {
            _Food3Service.TInsert(Food3);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFood3(int id)
        {
            var values = _Food3Service.TGetById(id);
            _Food3Service.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateFood3(Food3 Food3)
        {
            _Food3Service.TUpdate(Food3);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetFood3(int id)
        {
            var values = _Food3Service.TGetById(id);

            return Ok(values);
        }
    }
}
