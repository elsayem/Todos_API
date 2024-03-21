using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.DAL.Repos;

namespace Todo_List_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepo db;
        public TodosController(ITodoRepo _db)
        {
            db = _db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Todos = db.GetAll();

            if(Todos == null)
            {
                return NotFound();
            }
            return Ok(Todos);
        }


    }
}
