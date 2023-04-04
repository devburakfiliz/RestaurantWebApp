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
    public class SocialController : ControllerBase
    {
        private readonly ISocialService _SocialService;

        public SocialController(ISocialService socialService)
        {
            _SocialService = socialService;
        }

        [HttpGet]
        public IActionResult SocialList()
        {
            var values = _SocialService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSocial(Social Social)
        {
            _SocialService.TInsert(Social);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSocial(int id)
        {
            var values = _SocialService.TGetById(id);
            _SocialService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSocial(Social Social)
        {
            _SocialService.TUpdate(Social);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSocial(int id)
        {
            var values = _SocialService.TGetById(id);

            return Ok(values);
        }
    }
}
