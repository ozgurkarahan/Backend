using Api.Poc.OAuth.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Api.Poc.OAuth.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class TodoListController : Controller
    {
        static ConcurrentBag<TodoItem> todoStore = new ConcurrentBag<TodoItem>();

        // GET: api/values
        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            string owner = (User.FindFirst(ClaimTypes.NameIdentifier))?.Value;
            if (owner == null)
            {
                return todoStore.ToList();
            }
            return todoStore.Where(t => t.Owner == owner).ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]TodoItem Todo)
        {
            var claim = (User.FindFirst(ClaimTypes.NameIdentifier));
            string owner = claim != null ? claim.Value : Todo.Owner;
            todoStore.Add(new TodoItem { Owner = owner, Title = Todo.Title });
        }
    }
}
