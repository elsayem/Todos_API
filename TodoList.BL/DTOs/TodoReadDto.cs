using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DAL.Validators;

namespace TodoList.BL.DTOs
{
    public class TodoReadDto
    {
        public int Id { get; set; }
        [UniqueTodoName] 
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
