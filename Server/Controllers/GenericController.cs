﻿using BaseLibrary.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ServerLibrary.Repositories.Contracts;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T>(IGenericRepositoryInterface<T> genericRepositoryInterface) : 
        Controller where T : class
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAll() => Ok(await genericRepositoryInterface.GetAll());

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<T>>> GetAllQueryable()
        //{
        //    var items = await genericRepositoryInterface.GetAll().ToListAsync();
        //    return Ok(items);
        //}

        [HttpGet("single/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid request sent");
            return Ok(await  genericRepositoryInterface.GetById(id));
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid request sent");
            return Ok(await genericRepositoryInterface.DeleteById(id));
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody]T model)
        {
            if (model is null)
                return BadRequest("Bad request made");
            return Ok(await genericRepositoryInterface.Insert(model));
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(T model)
        {
            if (model is null)
                return BadRequest("Bad request made");
            return Ok(await genericRepositoryInterface.Update(model));
        }
    }
}
