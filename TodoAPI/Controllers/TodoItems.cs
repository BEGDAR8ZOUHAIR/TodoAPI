using Microsoft.AspNetCore.Mvc;
using TodoAPI.Models;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        // GET: api/<TodoItems>
        List<TodoItem> todoItems = new List<TodoItem>();
        public TodoItemsController()
        {

            todoItems.Add(new TodoItem
            { 
                Id = 1,
                Name = "Item1",
                IsComplete = true
            });

            todoItems.Add(new TodoItem
            {
                Id = 2,
                Name = "Item2",
                IsComplete = false
            });

        }
        [HttpGet]  // verb is GET
        public List<TodoItem> Get()
        {
            return todoItems;
        }

        // GET api/<TodoItems>/5
        [HttpGet("getById")]  // verb is GET
        public ActionResult<TodoItem> GetById(int id)   //ActionResult is a generic type to return a response with a status code
        {
            var item = todoItems.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // POST api/<TodoItems>

        [HttpPost]
        public ActionResult Post([FromBody]TodoItem item)
        {

            todoItems.Add(item);
            return CreatedAtAction("GetById", new { id = item.Id }, todoItems);
        }
        // PUT api/<TodoItems>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TodoItem item)
        {
            var eitem = todoItems.Find(x => x.Id == id);
            if (eitem == null)
            {
                return NotFound();
            }
            foreach (var todoItem in todoItems)
            {
                if (todoItem.Id == id)
                {
                    todoItem.Name = item.Name;

                }
            }
            return Ok(todoItems);
        }

        // DELETE api/<TodoItems>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var item = todoItems.Find(x => x.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            todoItems.Remove(item);
            return Ok(todoItems);
        }   

       

     

    }
}
