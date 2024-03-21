using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.DAL.Data.Models
{
    public class Todo
    {
        [Key]
        public int Id {  get; set; }
        public string Name {  get; set; }
        public string description {  get; set; }
        public DateTime DeadLine { get; set; }
    }
}
