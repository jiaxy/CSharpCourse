using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext todoCtx;

        //.Net Core在创建TodoController对象时自动实现依赖注入，将TodoContext的单例对象传过来作为参数
        public TodoController(TodoContext context){
            todoCtx = context;
        }
        // GET: api/Todo
        [HttpGet]
        public ActionResult<List<TodoItem>> GetTodoItems()
        {
            return todoCtx.TodoItems.ToList();
        }

        // GET: api/Todo/1
        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetTodoItem(long id)
        {
            var todoItem = todoCtx.TodoItems.Find(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return todoItem;
        }

        // POST: api/Todo
        [HttpPost]
        public  ActionResult<TodoItem> PostTodoItem(TodoItem item)
        {
            todoCtx.TodoItems.Add(item);
            todoCtx.SaveChanges();

            return CreatedAtAction(nameof(GetTodoItem), new { id = item.Id }, item);
        }

        // PUT: api/Todo/1
        [HttpPut("{id}")]
        public ActionResult<TodoItem> PutTodoItem(long id, TodoItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            todoCtx.Entry(item).State = EntityState.Modified;
            todoCtx.SaveChanges();
            return NoContent();
        }

        // DELETE: api/Todo/1
        [HttpDelete("{id}")]
        public ActionResult<TodoItem> DeleteTodoItem(long id)
        {
            var todoItem = todoCtx.TodoItems.Find(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            todoCtx.TodoItems.Remove(todoItem);
            todoCtx.SaveChanges();
            return NoContent();
        }



    }


}