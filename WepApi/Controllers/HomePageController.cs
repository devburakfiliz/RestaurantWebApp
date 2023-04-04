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
    public class HomePageController : ControllerBase
    {
        private readonly IHomePageService _HomePageService;

        public HomePageController(IHomePageService homePageService)
        {
            _HomePageService = homePageService;
        }

        [HttpGet]
        public IActionResult HomePageList()
        {
            var values = _HomePageService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddHomePage(HomePage HomePage)
        {
            _HomePageService.TInsert(HomePage);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteHomePage(int id)
        {
            var values = _HomePageService.TGetById(id);
            _HomePageService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateHomePage(HomePage HomePage)
        {
            _HomePageService.TUpdate(HomePage);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetHomePage(int id)
        {
            var values = _HomePageService.TGetById(id);

            return Ok(values);
        }
    }
}
