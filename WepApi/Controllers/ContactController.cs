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
    public class ContactController : ControllerBase
    {
        private readonly IContactService _ContactService;

        public ContactController(IContactService contactService)
        {
            _ContactService = contactService;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _ContactService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddContact(Contact Contact)
        {
            _ContactService.TInsert(Contact);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var values = _ContactService.TGetById(id);
            _ContactService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateContact(Contact Contact)
        {
            _ContactService.TUpdate(Contact);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var values = _ContactService.TGetById(id);

            return Ok(values);
        }
    }
}
