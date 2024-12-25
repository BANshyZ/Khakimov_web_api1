using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHURALE.Migrations;
using SHURALE.Models;
using static System.Net.Mime.MediaTypeNames;

namespace SHURALE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotherboardController : ControllerBase
    {
        public CompHelperContext Context { get; }

        public MotherboardController(CompHelperContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Motherboard> motherboards = Context.Motherboards.ToList();
            return Ok(motherboards);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            Motherboard? motherboard = Context.Motherboards.Where(x => x.MotherboardId == id).FirstOrDefault();
            if (motherboard == null)
            {
                return BadRequest("Not found");
            }
            return Ok(motherboard);
        }

        [HttpGet("by-motherboard-form-factor/{motherboardFormFactor}")]

        public IActionResult GetByMotherboardFormFactor(string motherboardFormFactor)
        {
            Motherboard? motherboard = Context.Motherboards.Where(x => x.MotherboardFornFactor == motherboardFormFactor).FirstOrDefault();
            if (motherboard == null)
            {
                return BadRequest("Not found");
            }
            return Ok(motherboard);
        }

        [HttpGet("by-socket{socket}")]

        public IActionResult GetBySocket(string socket)
        {
            Motherboard? motherboard = Context.Motherboards.Where(x => x.Socket == socket).FirstOrDefault();
            if (motherboard == null)
            {
                return BadRequest("Not found");
            }
            return Ok(motherboard);
        }

        [HttpGet("by-ram-memory-type{memoryType}")]

        public IActionResult GetByMemoryType(string memoryType)
        {
            Motherboard? motherboard = Context.Motherboards.Where(x => x.Ramtype == memoryType).FirstOrDefault();
            if (motherboard == null)
            {
                return BadRequest("Not found");
            }
            return Ok(motherboard);
        }

        [HttpGet("by-connection-interface/{connectionInterface}")]

        public IActionResult GetByConnectionInterface(string connectionInterface)
        {
            Motherboard? motherboard = Context.Motherboards.Where(x => x.ConnectionInterface == connectionInterface).FirstOrDefault();
            if (motherboard == null)
            {
                return BadRequest("Not found");
            }
            return Ok(motherboard);
        }

        [HttpPost]
        public IActionResult Add(string model, string socket, string ramType, string connectionInterface, string memoryInterFace, string motherboardFormFactor)
        {
            Motherboard motherboard = new Motherboard() { Model = model, Socket = socket, Ramtype = ramType, ConnectionInterface = connectionInterface, MemoryInterface = memoryInterFace, MotherboardFornFactor = motherboardFormFactor};
            Context.Motherboards.Add(motherboard);
            Context.SaveChanges();
            return Ok(motherboard);
        }
        [HttpPut]
        public IActionResult Update(int id, string model,string socket, string ramType, string connectionInterface, string memoryInterface, string formFactor) 
        {
            Motherboard? motherboard = Context.Motherboards.Where(x => x.MotherboardId == id).FirstOrDefault();
            if (motherboard == null)
            {
                return BadRequest("Not found");
            }
            motherboard.Model = model;
            motherboard.Socket = socket;
            motherboard.Ramtype = ramType;
            motherboard.ConnectionInterface = connectionInterface;
            motherboard.MemoryInterface = memoryInterface;
            motherboard.MotherboardFornFactor = formFactor;
            Context.SaveChanges();
            return Ok(motherboard);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Motherboard? motherboard = Context.Motherboards.Where(x => x.MotherboardId == id).FirstOrDefault();
            if (motherboard == null)
            {
                return BadRequest("Not found");
            }
            Context.Motherboards.Remove(motherboard);
            Context.SaveChanges();
            return Ok(motherboard);
        }
    }
}
