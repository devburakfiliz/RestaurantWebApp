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
    public class ChefController : ControllerBase
    {
        private readonly IChefService _ChefService;

        public ChefController(IChefService chefService)
        {
            _ChefService = chefService;
        }

        [HttpGet]
        public IActionResult ChefList()
        {
            var values = _ChefService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddChef(Chef Chef)
        {
            _ChefService.TInsert(Chef);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteChef(int id)
        {
            var values = _ChefService.TGetById(id);
            _ChefService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateChef(Chef Chef)
        {
            _ChefService.TUpdate(Chef);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetChef(int id)
        {
            var values = _ChefService.TGetById(id);

            return Ok(values);
        }
    }
}
