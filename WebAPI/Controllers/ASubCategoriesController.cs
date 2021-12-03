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
    public class ASubCategoriesController : ControllerBase
    {
        IASubCategoryService _aSubCategoryService;

        public ASubCategoriesController(IASubCategoryService aSubCategoryService)
        {
            _aSubCategoryService = aSubCategoryService;
        }


        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _aSubCategoryService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _aSubCategoryService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



        [HttpPost("add")]
        public IActionResult Add(ASubCategory aSubCategory)
        {
            var result = _aSubCategoryService.Add(aSubCategory);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ASubCategory aSubCategory)
        {
            var result = _aSubCategoryService.Delete(aSubCategory);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(ASubCategory aSubCategory)
        {
            var result = _aSubCategoryService.Update(aSubCategory);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
