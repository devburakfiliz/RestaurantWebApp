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
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _ServiceService;

        public ServiceController(IServiceService serviceService)
        {
            _ServiceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _ServiceService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddService(Service Service)
        {
            _ServiceService.TInsert(Service);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _ServiceService.TGetById(id);
            _ServiceService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service Service)
        {
            _ServiceService.TUpdate(Service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _ServiceService.TGetById(id);

            return Ok(values);
        }
    }
}
