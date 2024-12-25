using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHURALE.Models;

namespace SHURALE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RamController : ControllerBase
    {
        public CompHelperContext Context { get; }

        public RamController(CompHelperContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Ram> rams = Context.Rams.ToList();
            return Ok(rams);
        }

        [HttpGet("by-id/{id}")]

        public IActionResult GetById(int id)
        {
            Ram? ram = Context.Rams.Where(x => x.Ramid == id).FirstOrDefault();
            if (ram == null)
            {
                return BadRequest("Not found");
            }
            return Ok(ram);
        }

        [HttpGet("by-ram-memory-type{memoryType}")]

        public IActionResult GetByMemoryType(string memoryType)
        {
            Ram? ram = Context.Rams.Where(x => x.MemoryType == memoryType).FirstOrDefault();
            if (ram == null)
            {
                return BadRequest("Not found");
            }
            return Ok(ram);
        }

        [HttpPost]
        public IActionResult Add(string model, string memoryType, int capacity)
        {
            Ram ram = new Ram() { Model = model, MemoryType = memoryType, Capacity = capacity };
            Context.Rams.Add(ram);
            Context.SaveChanges();
            return Ok(ram);
        }
        [HttpPut]
        public IActionResult Update(int id, string model, string memoryType, int capacity)
        {
            Ram? ram = Context.Rams.Where(x => x.Ramid == id).FirstOrDefault();
            if (ram == null)
            {
                return BadRequest("Not found");
            }
            ram.Model = model;
            ram.MemoryType = memoryType;
            ram.Capacity = capacity;
            Context.SaveChanges();
            return Ok(ram);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Ram? ram = Context.Rams.Where(x => x.Ramid == id).FirstOrDefault();
            if (ram == null)
            {
                return BadRequest("Not found");
            }
            Context.Rams.Remove(ram);
            Context.SaveChanges();
            return Ok(ram);
        }
    }
}
