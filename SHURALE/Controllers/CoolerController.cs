﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHURALE.Models;

namespace SHURALE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoolerController : ControllerBase
    {
        public CompHelperContext Context { get; }

        public CoolerController(CompHelperContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Cooler> coolers = Context.Coolers.ToList();
            return Ok(coolers);
        }

        [HttpGet("by-id/{id}")]

        public IActionResult GetById(int id)
        {
            Cooler? cooler = Context.Coolers.Where(x => x.CoolerId == id).FirstOrDefault();
            if (cooler == null)
            {
                return BadRequest("Not found");
            }
            return Ok(cooler);
        }

        [HttpGet("by-socket-support/{socketSupport}")]
        public IActionResult GetBySocketSupport(string socketSupport)
        {
            Cooler? cooler = Context.Coolers.Where(x => x.SocketSupport == socketSupport).FirstOrDefault();
            if (cooler == null)
            {
                return BadRequest("Not found");
            }
            return Ok(cooler);
        }

        [HttpPost]
        public IActionResult Add(string model, string socketSupport, string constructionType)
        {
            Cooler cooler = new Cooler() { Model = model, SocketSupport = socketSupport, ConstructionType = constructionType };
            Context.Coolers.Add(cooler);
            Context.SaveChanges();
            return Ok(cooler);
        }
        [HttpPut]
        public IActionResult Update(int id, string model, string socketSupport, string constructionType)
        {
            Cooler? cooler = Context.Coolers.Where(x => x.CoolerId == id).FirstOrDefault();
            if (cooler == null)
            {
                return BadRequest("Not found");
            }
            cooler.Model = model;
            cooler.SocketSupport = socketSupport;
            cooler.ConstructionType = constructionType;
            Context.SaveChanges();
            return Ok(cooler);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Cooler? cooler = Context.Coolers.Where(x => x.CoolerId == id).FirstOrDefault();
            if (cooler == null)
            {
                return BadRequest("Not found");
            }
            Context.Coolers.Remove(cooler);
            Context.SaveChanges();
            return Ok(cooler);
        }
    }
}
