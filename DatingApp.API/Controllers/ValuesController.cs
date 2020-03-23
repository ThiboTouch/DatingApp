﻿using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        // GET: api/values
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();

            return Ok(values);
        }

        [HttpGet("{id}")]
        // GET: api/values/5
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);

        }

        // POST: api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut]
        // PUT: api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete]
        // DELETE: api/values/5
        public void Delete(int id)
        {
        }
    }
}
