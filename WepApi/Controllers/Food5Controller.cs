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
    public class Food5Controller : ControllerBase
    {
        private readonly IFood5Service _Food5Service;

        public Food5Controller(IFood5Service food5Service)
        {
            _Food5Service = food5Service;
        }

        [HttpGet]
        public IActionResult Food5List()
        {
            var values = _Food5Service.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddFood5(Food5 Food5)
        {
            _Food5Service.TInsert(Food5);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFood5(int id)
        {
            var values = _Food5Service.TGetById(id);
            _Food5Service.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateFood5(Food5 Food5)
        {
            _Food5Service.TUpdate(Food5);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetFood5(int id)
        {
            var values = _Food5Service.TGetById(id);

            return Ok(values);
        }
    }
}
