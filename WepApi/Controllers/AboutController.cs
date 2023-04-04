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
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _AboutService;

        public AboutController(IAboutService aboutService)
        {
            _AboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _AboutService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _AboutService.TInsert(about);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _AboutService.TGetById(id);
            _AboutService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            _AboutService.TUpdate(about);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _AboutService.TGetById(id);

            return Ok(values);
        }
    }
}
