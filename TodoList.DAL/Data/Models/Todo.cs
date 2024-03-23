using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DAL.Repos;
using TodoList.DAL.Validators;

namespace TodoList.DAL.Data.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [UniqueTodoName]
        public string Name {  get; set; }
        public string Description {  get; set; }
        public DateTime DeadLine { get; set; }
    }
}
