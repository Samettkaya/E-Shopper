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
    public class AddressController : ControllerBase
    {
        IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }


        [HttpPost("add")]
        public IActionResult Add(Address address)
        {
            var result = _addressService.Add(address);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Address address)
        {
            var result = _addressService.Delete(address);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(Address address)
        {
            var result = _addressService.Update(address);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _addressService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _addressService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyuser")]
        public IActionResult GetByUsers(int userId)
        {
            var result = _addressService.GetByUsers(userId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpGet("getbydto")]
        public IActionResult GetAddressCityUserDetails(int userId)
        {
            var result = _addressService.GetAddressCityUserDetails(userId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



    }
}
