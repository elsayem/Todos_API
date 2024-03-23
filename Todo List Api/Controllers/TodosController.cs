using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.BL.DTOs;
using TodoList.BL.Survices;
using TodoList.DAL.Data.Models;
using TodoList.DAL.Repos;

namespace Todo_List_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoSurvice db;
        public TodosController(ITodoSurvice _db)
        {
            db = _db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var todos = db.GetAll();
            if (todos == null) { return NotFound(); }

            return Ok(todos);

        }

        [Route("{id:int}")]
        [HttpGet]

        public IActionResult GetById(int id)
        {
            var todo = db.GetById(id);
            return Ok(todo);

        }

        [HttpPost]
        public IActionResult Add(TodoCreateDto _dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();

            }          
           
            int? x = db.Add(_dto);
            //to display the name of the todo
            var todo = db.GetById(x.Value);
            return CreatedAtAction(nameof(GetById), new { id = x }, new { Message = $"{todo.Name} Successfully Created" });

        }


        [HttpPut("{id:int}")]
        public IActionResult Update(int id, TodoUpdateDto _dto)
        {
            bool UpdatedTodo = db.Update(id, _dto);

            if (UpdatedTodo == false)
            { return NotFound($"The {_dto.Name} is not found"); }
            var todo = db.GetById(id);
            return Ok($"{todo.Name} Successfully Updated !");


        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
             
            bool todo = db.Delete(id);
            if (todo == false) { return NotFound($"The Id is not Exist !"); }


            return Ok($"Deleted Successfully");


        }



    }
}
