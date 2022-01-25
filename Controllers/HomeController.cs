using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controllers 
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        public HomeController([FromServices] AppDbContext dbContext)   
            => this.dbContext = dbContext;

        [HttpGet("/")]
        public IActionResult Get()
            => Ok(dbContext.Todos.ToList());

        [HttpGet("/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var todo = dbContext.Todos.FirstOrDefault(todo => todo.Id == id);    
            return (todo is null) ? NotFound("Todo não encontrado") : Ok(todo);
        }

        [HttpPost("/")]
        public IActionResult Post([FromBody] TodoModel model)
        {
            var todo = dbContext.Todos.FirstOrDefault(todo => todo.Id == model.Id);    
            if (todo is not null) 
                return BadRequest("Todo já existe");

            dbContext.Todos.Add(model);
            dbContext.SaveChanges();
            return Created($"/{model.Id}", model);
        }

        [HttpPut("/")]
        public IActionResult Put([FromBody] TodoModel model)
        {
            var todo = dbContext.Todos.FirstOrDefault(todo => todo.Id == model.Id);
            
            if(todo is null)
                return NotFound("Todo não encontrado");

            todo.Title = model.Title;
            todo.Done = model.Done;

            dbContext.Todos.Update(todo);
            dbContext.SaveChanges();
            return Ok(todo);
        }

        [HttpDelete("/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var todo = dbContext.Todos.FirstOrDefault(todo => todo.Id == id);
            
            if(todo is null)
                return NotFound("Todo não encontrado");

            dbContext.Todos.Remove(todo);
            dbContext.SaveChanges();
            return Ok(todo);
        }
    }
}