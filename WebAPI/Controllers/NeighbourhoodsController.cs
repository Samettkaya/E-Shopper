using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeighbourhoodsController : ControllerBase
    {
        INeighbourhoodService _neighbourhoodService;

        public NeighbourhoodsController(INeighbourhoodService neighbourhoodService)
        {
            _neighbourhoodService = neighbourhoodService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_neighbourhoodService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _neighbourhoodService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Neighbourhood neighbourhood)
        {
            var result = _neighbourhoodService.Add(neighbourhood);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Neighbourhood neighbourhood)
        {
            var result = _neighbourhoodService.Update(neighbourhood);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Neighbourhood neighbourhood)
        {
            var result = _neighbourhoodService.Delete(neighbourhood);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
