using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CognizantInternship2018Workshops.Models;
using Microsoft.AspNetCore.Mvc;

namespace CognizantInternship2018Workshops.Controllers
{
    [Route("api/[controller]")]
    public class TasksController : Controller
    {
        private IList<TodoItem> _items = new List<TodoItem>()
        {
            new TodoItem()
            {
                Id=1,
                Title="Item 1",
                Description="Item 1 description",
                EndDate=DateTime.Now.AddDays(2),
                Status=TodoItemStatus.Open,
                Priority=TodoItemPriority.Low
            },
            new TodoItem()
            {
                Id=2,
                Title="Item 2",
                Description="Item 2 description",
                EndDate=DateTime.Now.AddDays(5),
                Status=TodoItemStatus.InProgress,
                Priority=TodoItemPriority.Medium
            }
        };

        // GET api/values
        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            return _items;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public TodoItem Get(long id)
        {
            return _items.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]TodoItem value)
        {
            _items.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]TodoItem value)
        {
            int idx = _items.IndexOf(_items.Where(x => x.Id == id).FirstOrDefault());
            _items[idx] = value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _items = _items.Where(x => x.Id != id).ToList();
        }
    }
}
