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
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _FoodService;

        public FoodController(IFoodService foodService)
        {
            _FoodService = foodService;
        }

        [HttpGet]
        public IActionResult FoodList()
        {
            var values = _FoodService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddFood(Food Food)
        {
            _FoodService.TInsert(Food);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFood(int id)
        {
            var values = _FoodService.TGetById(id);
            _FoodService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateFood(Food Food)
        {
            _FoodService.TUpdate(Food);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetFood(int id)
        {
            var values = _FoodService.TGetById(id);

            return Ok(values);
        }
    }
}
