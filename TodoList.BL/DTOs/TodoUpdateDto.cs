using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.BL.DTOs
{
    public class TodoUpdateDto
    {
        //the Id will be sent using the routing
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
