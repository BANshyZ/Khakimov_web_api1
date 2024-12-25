using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHURALE.Models;
namespace SHURALE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessorController : ControllerBase
    {
        public CompHelperContext Context { get; }

        public ProcessorController(CompHelperContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Cpu> cpus = Context.Cpus.ToList();
            return Ok(cpus);
        }

        [HttpGet("by-id/{id}")]

        public IActionResult GetById(int id)
        {
            Cpu? cpu = Context.Cpus.Where(x => x.Cpuid == id).FirstOrDefault();
            if (cpu == null)
            {
                return BadRequest("Not found");
            }
            return Ok(cpu);
        }

        [HttpGet("by-socket{socket}")]

        public IActionResult GetBySocket(string socket)
        {
            Cpu? cpu = Context.Cpus.Where(x => x.Socket == socket).FirstOrDefault();
            if (cpu == null)
            {
                return BadRequest("Not found");
            }
            return Ok(cpu);
        }

        [HttpPost]
        public IActionResult Add(string model, string socket, int cores, int threads)
        {
            Cpu cpu = new Cpu() { Model = model, Socket = socket, Cores = cores, Threads = threads};
            Context.Cpus.Add(cpu);
            Context.SaveChanges();
            return Ok(cpu);
        }
        [HttpPut]
        public IActionResult Update(int id, string model, string socket, int cores, int threads)
        {
            Cpu? cpu = Context.Cpus.Where(x => x.Cpuid == id).FirstOrDefault();
            if (cpu == null)
            {
                return BadRequest("Not found");
            }
            cpu.Model = model;
            cpu.Socket = socket;
            cpu.Cores = cores; 
            cpu.Threads = threads;
            Context.SaveChanges();
            return Ok(cpu);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Cpu? motherboard = Context.Cpus.Where(x => x.Cpuid == id).FirstOrDefault();
            if (motherboard == null)
            {
                return BadRequest("Not found");
            }
            Context.Cpus.Remove(motherboard);
            Context.SaveChanges();
            return Ok(motherboard);
        }
    }
}
