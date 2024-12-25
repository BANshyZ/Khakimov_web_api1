﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHURALE.Models;

namespace SHURALE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PowerSupplyController : ControllerBase
    {
        public CompHelperContext Context { get; }

        public PowerSupplyController(CompHelperContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<PowerSupply> powerSupplys = Context.PowerSupplies.ToList();
            return Ok(powerSupplys);
        }

        [HttpGet("by-id/{id}")]

        public IActionResult GetById(int id)
        {
            PowerSupply? powerSupply = Context.PowerSupplies.Where(x => x.PowerSupplyId == id).FirstOrDefault();
            if (powerSupply == null)
            {
                return BadRequest("Not found");
            }
            return Ok(powerSupply);
        }

        [HttpGet("by-power-rating/{powerRating}")]

        public IActionResult GetByPowerRating(int powerRating)
        {
            PowerSupply? powerSupply = Context.PowerSupplies.Where(x => x.PowerRating == powerRating).FirstOrDefault();
            if (powerSupply == null)
            {
                return BadRequest("Not found");
            }
            return Ok(powerSupply);
        }

        [HttpPost]
        public IActionResult Add(string model, int powerRating, string formFactor)
        {
            PowerSupply powerSupply = new PowerSupply() { Model = model, PowerRating = powerRating, FormFactor = formFactor };
            Context.PowerSupplies.Add(powerSupply);
            Context.SaveChanges();
            return Ok(powerSupply);
        }
        [HttpPut]
        public IActionResult Update(int id, string model, int powerRating, string formFactor)
        {
            PowerSupply? powerSupply = Context.PowerSupplies.Where(x => x.PowerSupplyId == id).FirstOrDefault();
            if (powerSupply == null)
            {
                return BadRequest("Not found");
            }
            powerSupply.Model = model;
            powerSupply.PowerRating = powerRating;
            powerSupply.FormFactor = formFactor;
            Context.SaveChanges();
            return Ok(powerSupply);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            PowerSupply? powerSupply = Context.PowerSupplies.Where(x => x.PowerSupplyId == id).FirstOrDefault();
            if (powerSupply == null)
            {
                return BadRequest("Not found");
            }
            Context.PowerSupplies.Remove(powerSupply);
            Context.SaveChanges();
            return Ok(powerSupply);
        }
    }
}
