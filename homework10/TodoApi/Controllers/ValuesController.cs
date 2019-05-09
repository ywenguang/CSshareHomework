using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;


namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Models.TodoContext ctx;
        public ValuesController(Models.TodoContext context)
        {
            this.ctx = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<TodoItems>> GetAll()
        {
            return ctx.TodoItems.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<TodoItems> Get(int id)
        {
            var item = ctx.TodoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<TodoItems> PostNew(long id,TodoItems item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }
            ctx.TodoItems.Remove(item);
            ctx.SaveChanges();
            return NoContent();
        }
 

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<TodoItems> Put_Modify(long id)
        {
            var item = ctx.TodoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            ctx.TodoItems.Remove(item);
            ctx.SaveChanges();
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<TodoItems> Delete(long id)
        {
            var item = ctx.TodoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            ctx.TodoItems.Remove(item);
            ctx.SaveChanges();
            return NoContent();
        }
    }
}
